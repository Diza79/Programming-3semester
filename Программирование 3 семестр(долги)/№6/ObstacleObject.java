public class ObstacleObject extends GameObject {
    private boolean isDestructible;
    public ObstacleObject(int x, int y, boolean destructible) {
        super(x, y, '#');
        this.isDestructible = destructible;
    }
    // Конструктор копирования
    public ObstacleObject(ObstacleObject other) {
        super(other.x, other.y, other.type);
        this.isDestructible = other.isDestructible;
    }
    @Override
    public int getValue() { return 0; }
    @Override
    public void print() { System.out.print(isDestructible ? '%' : '#'); }

    @Override
    public GameObject clone() {return new ObstacleObject(this); }
}
