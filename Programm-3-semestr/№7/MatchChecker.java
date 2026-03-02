public class MatchChecker {
    // Интерфейс для демонстрации
    public interface IMatchChecker {
        boolean checkAndRemoveTrios(GameBoard board, Score score);
        void applyGravity(GameBoard board);
    }

    public boolean checkAndRemoveTrios(GameBoard board, Score score) {
        boolean foundTrio = false; int height = 10;  int width = 10;
        // Горизонтальная проверка
        for (int i = 0; i < height; i++) {
            for (int j = 0; j < width - 2; j++) {
                GameObject obj1 = board.getCell(i, j);
                GameObject obj2 = board.getCell(i, j + 1);
                GameObject obj3 = board.getCell(i, j + 2);
                if (obj1 != null && obj2 != null && obj3 != null &&
                    obj1.getType() == obj2.getType() &&
                    obj1.getType() == obj3.getType()) {
                    
                    foundTrio = true;
                    score.updateScore(
                        obj1.getValue() + 
                        obj2.getValue() + 
                        obj3.getValue()
                    );

                    board.setCell(i, j, null);
                    board.setCell(i, j + 1, null);
                    board.setCell(i, j + 2, null);
                }
            }
        }
        // Вертикальная проверка
        for (int j = 0; j < width; j++) {
            for (int i = 0; i < height - 2; i++) {
                GameObject obj1 = board.getCell(i, j);
                GameObject obj2 = board.getCell(i + 1, j);
                GameObject obj3 = board.getCell(i + 2, j);

                if (obj1 != null && obj2 != null && obj3 != null &&
                    obj1.getType() == obj2.getType() &&
                    obj1.getType() == obj3.getType()) {
                   
                    foundTrio = true;
                    score.updateScore(
                        obj1.getValue() + 
                        obj2.getValue() + 
                        obj3.getValue()
                    );
                    board.setCell(i, j, null);
                    board.setCell(i + 1, j, null);
                    board.setCell(i + 2, j, null);
                }
            }
        }

        return foundTrio;
    }

    public void applyGravity(GameBoard board) {
        int height = 10; int width = 10;

        for (int j = 0; j < width; j++) {
            for (int i = height - 1; i >= 0; i--) {
                if (board.getCell(i, j) == null) {
                    for (int k = i - 1; k >= 0; k--) {
                        GameObject obj = board.getCell(k, j);
                        if (obj != null) {
                            board.setCell(i, j, obj);
                            board.setCell(k, j, null);
                            break;
                        }
                    }
                }
            }
        }
    }
}
