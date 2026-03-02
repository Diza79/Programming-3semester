public class GameBoard {
    private GameObject[][] board;

    public GameBoard(int width, int height) {
        board = new GameObject[height][width];
    }

    public void setCell(int x, int y, GameObject obj) {
        board[x][y] = obj;
    }

    public GameObject getCell(int x, int y) {
        return board[x][y];
    }

    public void displayBoard() {
        for (GameObject[] row : board) {
            for (GameObject cell : row) {
                System.out.print(cell != null ? cell.getType() : '.');
                System.out.print(' ');
            }
            System.out.println();
        }
    }
}
