public abstract class GameObject {
    protected int x;
    protected int y;
    protected char type;
    public GameObject(int x, int y, char type) {
        this.x = x; this.y = y; this.type = type;
    }
    public char getType() { return type; }
    public int getX() { return x; }
    public int getY() { return y; }
    public void setPosition(Cell cell) {
        this.x = cell.getX(); this.y = cell.getY();
    }
    // Абстрактные методы
    public abstract int getValue();
    public abstract GameObject clone();
    // Виртуальный метод
    public void print() { System.out.print(type); }
}
