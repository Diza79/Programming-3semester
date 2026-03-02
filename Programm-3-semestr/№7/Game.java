import java.util.*;

public class Game {
    private GameBoard board;
    private Player player;
    private Score score;
    private GameSettings settings;
    private MatchChecker checker;  // ДЕЛЕГАТ
    private boolean isGameOver;
    private Random random;
    private static int gameCount = 0;

    public Game(GameSettings settings, String playerName) {
        this.settings = settings;
        this.board = new GameBoard(settings.getWidth(), settings.getHeight());
        this.player = new Player(playerName);
        this.score = new Score();
        this.checker = new MatchChecker();  // СОЗДАЁМ ДЕЛЕГАТА
        this.isGameOver = false;
        this.random = new Random();
        gameCount++;
        initializeBoard();
    }

    private void initializeBoard() {
        for (int i = 0; i < settings.getHeight(); i++) {
            for (int j = 0; j < settings.getWidth(); j++) {
                if (random.nextInt(5) == 0) {
                    board.setCell(i, j, 
                        new BonusObject(i, j, (char)('A' + random.nextInt(3)), 10));
                } else if (random.nextInt(8) == 0) {
                    board.setCell(i, j, 
                     new ObstacleObject(i, j, true));
                } else {
                    board.setCell(i, j, 
                        new BonusObject(i, j, (char)('A' + random.nextInt(5)), 1));
                }
            }
        }
    }

    public void makeMove(int fromX, int fromY, int toX, int toY) {
        try {
            if (fromX < 0 || fromX >= settings.getHeight() ||
                fromY < 0 || fromY >= settings.getWidth() ||
                toX < 0 || toX >= settings.getHeight() ||
                toY < 0 || toY >= settings.getWidth()) {
                throw new IllegalArgumentException("Выход за пределы поля!");
            }
            GameObject fromCell = board.getCell(fromX, fromY);
            GameObject toCell = board.getCell(toX, toY);

            if (fromCell == null) {
                throw new IllegalStateException("Исходная клетка пуста!");
            }

            if (toCell != null) {
                throw new IllegalStateException("Целевая клетка занята!");
            }

            // Перемещение
            board.setCell(toX, toY, fromCell);
            board.setCell(fromX, fromY, null);
            fromCell.setPosition(new Cell(toX, toY));
            
            score.incrementMoveCount();

            // ДЕЛЕГИРОВАНИЕ проверки комбинаций
            if (checker.checkAndRemoveTrios(board, score)) {
                System.out.println("Найдена комбинация! Очки: " + score.getCurrentScore());
                checker.applyGravity(board);
            }

        } catch (IllegalArgumentException | IllegalStateException e) {
            System.out.println("Ошибка: " + e.getMessage());
        }
    }

    public void display() {
        System.out.println("\n=== ИГРОК: " + player.getName() + " ===");
        System.out.println("Счёт: " + score.getCurrentScore());
        System.out.println("Ходов: " + score.getMoveCount());
        System.out.println("Всего игр создано: " + gameCount);
        board.displayBoard();
    }

    public static int getGameCount() {
        return gameCount;
    }

    public boolean checkWin() {
        return score.getCurrentScore() >= settings.getWinCondition();
    }

    public void play() {
        Scanner scanner = new Scanner(System.in);
        
        while (!isGameOver) {
            display();
            
            try {
                System.out.print("Введите X и Y откуда (или exit): ");
                String input = scanner.nextLine();
                if (input.equalsIgnoreCase("exit")) break;
                
                String[] fromCoords = input.split(" ");
                if (fromCoords.length != 2) {
                    System.out.println("Нужно 2 координаты!");
                    continue;
                }
                
                int fromX = Integer.parseInt(fromCoords[0]);
                int fromY = Integer.parseInt(fromCoords[1]);
                
                System.out.print("Введите X и Y куда: ");
                String[] toCoords = scanner.nextLine().split(" ");
                if (toCoords.length != 2) {
                    System.out.println("Нужно 2 координаты!");
                    continue;
                }
                
                int toX = Integer.parseInt(toCoords[0]);
                int toY = Integer.parseInt(toCoords[1]);
                
                makeMove(fromX, fromY, toX, toY);
                
                if (checkWin()) {
                    System.out.println("ПОБЕДА! Счёт: " + score.getCurrentScore());
                    isGameOver = true;
                }
                
            } catch (NumberFormatException e) {
                System.out.println("Ошибка: введите числа!");
            }
        }
        
        scanner.close();
    }
}
