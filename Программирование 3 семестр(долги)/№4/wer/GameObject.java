public class GameObject {
    private int x;
    private int y;
    private char type;

    public GameObject(int x, int y, char type) {
        this.x = x;
        this.y = y;
        this.type = type;
    }

    public char getType() {
        return type;
    }

    public void setPosition(Cell cell) {
        this.x = cell.getX();
        this.y = cell.getY();
    }
}
