public class GameSettings {
    private int width;
    private int height;
    private int winCondition;

    public GameSettings(int width, int height, int winCondition) {
        this.width = width;
        this.height = height;
        this.winCondition = winCondition;
    }

    public int getWidth() {
        return width;
    }

    public int getHeight() {
        return height;
    }

    public int getWinCondition() {
        return winCondition;
    }
}
