public class Score {
    private int currentScore;
    private int highScore;
    private int moveCount; // Счетчик ходов

    public Score() {
        currentScore = 0;
        highScore = 0;
        moveCount = 0; // Инициализация счетчика ходов
    }

    public void updateScore(int score) {
        currentScore += score;
        if (currentScore > highScore) {
            highScore = currentScore;
        }
    }

    public int getCurrentScore() {
        return currentScore;
    }

    public int getHighScore() {
        return highScore;
    }

    public void incrementMoveCount() {
        moveCount++;
    }

    public int getMoveCount() {
        return moveCount;
    }
}
