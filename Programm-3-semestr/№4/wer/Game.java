import java.util.Random;
import java.util.Scanner;

public class Game {
    private GameBoard board; // Указатель на игровое поле
    private Player player; // Указатель на игрока
    private Score score; // Указатель на счет
    private GameSettings settings; // Настройки игры
    private boolean isGameOver;
    private Random random; // Для генерации букв

    public Game(GameSettings settings, String playerName) {
        this.settings = settings;
        board = new GameBoard(settings.getWidth(), settings.getHeight());
        player = new Player(playerName);
        score = new Score();
        isGameOver = false;
        random = new Random();
        initializeBoard(); // Инициализация игрового поля
    }

    private void initializeBoard() {
        // Заполнение поля случайными буквами из первых 7 букв алфавита
        for (int i = 0; i < settings.getHeight(); i++) {
            for (int j = 0; j < settings.getWidth(); j++) {
                board.setCell(i, j, generateRandomLetter());
            }
        } 
    }

    private GameObject generateRandomLetter() {
        char letter = (char) ('A' + random.nextInt(7)); // Генерация случайной буквы от A до G
        return new GameObject(0, 0, letter);
    }

    public void display() {
        System.out.println("Игрок: " + player.getName());
        System.out.println("Счет: " + score.getCurrentScore());
        System.out.println("Количество ходов: " + score.getMoveCount());
        System.out.println("Игровое поле:");
        board.displayBoard();
    }

    public void makeMove(Cell from, Cell to) {
        // Проверка на выход за пределы игрового поля
        if (from.getX() < 0 || from.getX() >= settings.getHeight() ||
            from.getY() < 0 || from.getY() >= settings.getWidth() ||
            to.getX() < 0 || to.getX() >= settings.getHeight() ||
            to.getY() < 0 || to.getY() >= settings.getWidth()) {
            System.out.println("Ошибка: выход за пределы игрового поля.");
            return;
        }

        // Проверка на диагональное перемещение
        if (from.getX() != to.getX() && from.getY() != to.getY()) {
            System.out.println("Ошибка: перемещение возможно только по горизонтали или вертикали.");
            return;
        }

        GameObject movingObject = board.getCell(from.getX(), from.getY());
        GameObject targetObject = board.getCell(to.getX(), to.getY());

        if (movingObject != null) {
            // Сохраняем буквы для замены
            char tempLetter = targetObject != null ? targetObject.getType() : '.';

            // Перемещение объекта на новое место
            board.setCell(to.getX(), to.getY(), movingObject);
            // Удаляем объект из старой позиции
            board.setCell(from.getX(), from.getY(), new GameObject(from.getX(), from.getY(), tempLetter));
            movingObject.setPosition(to); // Обновляем позицию объекта

            // Увеличиваем счетчик ходов
            score.incrementMoveCount();

            // Проверяем на наличие трио
            if (checkForTrio()) {
                score.updateScore(3); // Начисляем очки за трио
                System.out.println("Вы собрали комбинацию из трех букв!");
                generateNewLetters();
            }
        } else {
            System.out.println("Невозможно переместить: клетка пуста.");
        }
    }

    private boolean checkForTrio() {
        boolean foundTrio = false;

        // Проверка по горизонтали
        for (int i = 0; i < settings.getHeight(); i++) {
            for (int j = 0; j < settings.getWidth() - 2; j++) {
                GameObject first = board.getCell(i, j);
                GameObject second = board.getCell(i, j + 1);
                GameObject third = board.getCell(i, j + 2);
                if (first != null && second != null && third != null &&
                    first.getType() == second.getType() && first.getType() == third.getType()) {
                    foundTrio = true;
                    // Удаляем трио
                    board.setCell(i, j, new GameObject(i, j, '.'));
                    board.setCell(i, j + 1, new GameObject(i, j + 1, '.'));
                    board.setCell(i, j + 2, new GameObject(i, j + 2, '.'));
                }
            }
        }

        // Проверка по вертикали
        for (int j = 0; j < settings.getWidth(); j++) {
            for (int i = 0; i < settings.getHeight() - 2; i++) {
                GameObject first = board.getCell(i, j);
                GameObject second = board.getCell(i + 1, j);
                GameObject third = board.getCell(i + 2, j);
                if (first != null && second != null && third != null &&
                    first.getType() == second.getType() && first.getType() == third.getType()) {
                    foundTrio = true;
                    // Удаляем трио
                    board.setCell(i, j, new GameObject(i, j, '.'));
                    board.setCell(i + 1, j, new GameObject(i + 1, j, '.'));
                    board.setCell(i + 2, j, new GameObject(i + 2, j, '.'));
                }
            }
        }

        return foundTrio;
    }

    private void generateNewLetters() {
        // Обновляем поле, чтобы буквы падали вниз
        for (int j = 0; j < settings.getWidth(); j++) {
            for (int i = settings.getHeight() - 1; i >= 0; i--) {
                if (board.getCell(i, j).getType() == '.') {
                    // Сдвигаем буквы вниз
                    for (int k = i - 1; k >= 0; k--) {
                        GameObject letter = board.getCell(k, j);
                        if (letter != null) {
                            board.setCell(i, j, letter); // Перемещаем букву вниз
                            board.setCell(k, j, new GameObject(k, j, '.')); // Освобождаем старую позицию
                            break;
                        }
                    }
                    // Генерация новых букв для пустых клеток
                    if (board.getCell(i, j).getType() == '.') {
                        board.setCell(i, j, generateRandomLetter());
                    }
                }
            }
        }

        // Проверяем снова на наличие трио после генерации новых букв
        if (checkForTrio()) {
            score.updateScore(1); // Начисляем очки за новое трио
            generateNewLetters(); // Рекурсивно вызываем, если снова есть трио
        }
    }

    public boolean checkWin() {
        return score.getCurrentScore() >= settings.getWinCondition();
    }

    public void play() {
        Scanner scanner = new Scanner(System.in);
        while (!isGameOver) {
            display();
            System.out.print("Введите координаты откуда (x y) или 'exit' для выхода: ");
            
            // Проверка на ввод команды выхода
            String input = scanner.nextLine();
            if (input.equalsIgnoreCase("exit")) {
                System.out.println("Вы вышли из игры. Спасибо за игру!");
                break; // Выход из цикла
            }

            // Парсинг координат
            String[] coordinates = input.split(" ");
            if (coordinates.length != 2) {
                System.out.println("Ошибка: введите два числа для координат.");
                continue; // Возвращаемся к началу цикла
            }

            int fromX, fromY, toX, toY;
            try {
                fromX = Integer.parseInt(coordinates[0]);
                fromY = Integer.parseInt(coordinates[1]);
            } catch (NumberFormatException e) {
                System.out.println("Ошибка: введите корректные числа.");
                continue; // Возвращаемся к началу цикла
            }

            System.out.print("Введите координаты куда (x y): ");
            input = scanner.nextLine();
            if (input.equalsIgnoreCase("exit")) {
                System.out.println("Вы вышли из игры. Спасибо за игру!");
                break; // Выход из цикла
            }

            coordinates = input.split(" ");
            if (coordinates.length != 2) {
                System.out.println("Ошибка: введите два числа для координат.");
                continue; // Возвращаемся к началу цикла
            }

            try {
                toX = Integer.parseInt(coordinates[0]);
                toY = Integer.parseInt(coordinates[1]);
            } catch (NumberFormatException e) {
                System.out.println("Ошибка: введите корректные числа.");
                continue; // Возвращаемся к началу цикла
            }

            // Создаем объекты для клеток
            Cell fromCell = new Cell(fromX, fromY);
            Cell toCell = new Cell(toX, toY);

            // Выполняем перемещение
            makeMove(fromCell, toCell);

            // Проверяем на победу
            if (checkWin()) {
                System.out.println("Поздравляем! Вы выиграли с " + score.getCurrentScore() + " очками!");
                isGameOver = true; // Завершаем игру
            }
        }
        scanner.close();
    }
}


