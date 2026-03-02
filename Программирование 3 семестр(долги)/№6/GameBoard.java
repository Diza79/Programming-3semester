public class GameBoard {
    private GameObject[][] board;
    private int width;
    private int height;

    public GameBoard(int width, int height) {
        this.width = width;
        this.height = height;
        board = new GameObject[height][width];
    }

    public void setCell(int x, int y, GameObject obj) {
        if (x >= 0 && x < height && y >= 0 && y < width) { board[x][y] = obj; }
    }

    public GameObject getCell(int x, int y) {
        if (x >= 0 && x < height && y >= 0 && y < width) { return board[x][y]; }
        return null;
    }

    public void displayBoard() {
        for (int i = 0; i < height; i++) {
            for (int j = 0; j < width; j++) {
                if (board[i][j] != null) {
                    board[i][j].print();  //полиморфизм
                } else { System.out.print('.'); }
                System.out.print(' ');
            }
            System.out.println();
        }
    }
    public int getWidth() { return width; }
    public int getHeight() { return height; }
}
