public class BonusObject extends GameObject {
    private int bonusValue;
    private static int bonusCount = 0;

    public BonusObject(int x, int y, char type, int bonus) {
        super(x, y, type);
        this.bonusValue = bonus;
        bonusCount++;
    }
    // Конструктор копирования
    public BonusObject(BonusObject other) {
        super(other.x, other.y, other.type);
        this.bonusValue = other.bonusValue;
        bonusCount++;
    }
    @Override
    public int getValue() { return bonusValue; }
    @Override
    public void print() { System.out.print("[Бонус:" + type + "+" + bonusValue + "]"); }
    // Вызов метода базового класса
    public void showBase() { super.print(); }

    @Override
    public GameObject clone() { return new BonusObject(this); }
    public static int getBonusCount() { return bonusCount; }
}