import java.util.*;
public class Main {
    // Демонстрация полиморфизма (LR-6)
    static void demonstratePolymorphism() {
        System.out.println("\n=== ПОЛИМОРФИЗМ ===");
       
        List<GameObject> objects = new ArrayList<>();
        objects.add(new BonusObject(0, 0, 'A', 5));
        objects.add(new BonusObject(1, 1, 'B', 10));
        objects.add(new ObstacleObject(2, 2, false));
        objects.add(new ObstacleObject(3, 3, true));
        System.out.println("Бонусов создано: " + BonusObject.getBonusCount());
        
        for (int i = 0; i < objects.size(); i++) {
            System.out.print("Объект " + i + ": "); objects.get(i).print();
            System.out.println(", ценность = " + objects.get(i).getValue());
        }
    }
    
    // Клонирование (LR-6)
    static void demonstrateCloning() {
        System.out.println("\n=== КЛОНИРОВАНИЕ ===");
        
        BonusObject original = new BonusObject(5, 5, 'X', 20);
        System.out.print("Оригинал: ");
        original.print();
        System.out.println();
        
        BonusObject clone = new BonusObject(original);
        System.out.print("Клон: ");
        clone.print();
        System.out.println();
        
        original.setPosition(new Cell(10, 10));
        System.out.println("Оригинал теперь: (" + original.getX() + "," + original.getY() + ")");
        System.out.println("Клон остался: (" + clone.getX() + "," + clone.getY() + ")");
    }
    
    // Исключения (LR-6)
    static void demonstrateExceptions() {
        System.out.println("\n=== ИСКЛЮЧЕНИЯ ===");
        try {
            GameSettings settings = new GameSettings(10, 10, 15);
            Game game = new Game(settings, "Тест");
            game.makeMove(-1, 0, 0, 0);  // Выход за границы
        } catch (Exception e) {System.out.println("Перехвачено исключение: " + e.getMessage());}
    }
    

    // Контейнеры, сортировка и поиск от LR-8
    static void demonstrateContainer() {
        System.out.println("\n=== КОНТЕЙНЕРЫ И АЛГОРИТМЫ ===");
        
        // Контейнер с объектами базового и производных классов
        List<GameObject> gameObjects = new ArrayList<>();
        
        // Добавляем объекты разных типов
        for (int i = 0; i < 3; i++) { gameObjects.add(new BonusObject(i, i, (char)('A' + i), i * 10)); }
        for (int i = 0; i < 2; i++) { gameObjects.add(new ObstacleObject(i, i + 5, i % 2 == 0)); }
        gameObjects.add(new BonusObject(5, 5, 'Z', 50)); 
        System.out.println("Всего объектов в контейнере: " + gameObjects.size());
        
        // Выводим до сортировки
        System.out.println("\nДо сортировки:");
        for (int i = 0; i < gameObjects.size(); i++) {
            System.out.print("  " + i + ": ");
            gameObjects.get(i).print();
            System.out.println(" (ценность=" + gameObjects.get(i).getValue() + ")");
        }
        
        // Сортировка по ценности (убывание)
        Collections.sort(gameObjects, (a, b) -> 
            Integer.compare(b.getValue(), a.getValue()));
 
        System.out.println("\nПосле сортировки по убыванию ценности:");
        for (int i = 0; i < gameObjects.size(); i++) {
            System.out.print("  " + i + ": ");
            gameObjects.get(i).print();
            System.out.println(" (ценность=" + gameObjects.get(i).getValue() + ")");
        }
        
        // Поиск объекта с ценностью > 15
        System.out.println("\nПоиск объектов с ценностью > 15:");
        for (GameObject obj : gameObjects) {
            if (obj.getValue() > 15) {
                System.out.print("  Найден: "); obj.print();
                System.out.println(" (ценность=" + obj.getValue() + ")");
            }
        }
        
        // Поиск с использованием Stream API
        Optional<GameObject> found = gameObjects.stream()
            .filter(obj -> obj.getType() == 'Z')
            .findFirst();
        
        if (found.isPresent()) {
            System.out.print("\nНайден объект с типом 'Z': ");
            found.get().print(); System.out.println();
        }
        
        // Фильтрация: только бонусы
        System.out.println("\nТолько бонусные объекты:");
        gameObjects.stream()
            .filter(obj -> obj instanceof BonusObject)
            .forEach(obj -> { obj.print(); System.out.print(" "); });
        System.out.println();
    }
    
    // Демонстрация делегирования (LR-7)
    static void demonstrateDelegation() {
        System.out.println("\n=== ДЕЛЕГИРОВАНИЕ ===");
        System.out.println("Класс MatchChecker делегирует проверку комбинаций");
        System.out.println("Game вызывает checker.checkAndRemoveTrios()");
        System.out.println("Game вызывает checker.applyGravity()");
    }
    
    public static void main(String[] args) {
        System.out.println("=================================");
        System.out.println("=========  Работы 6, 7, 8 ============");
        System.out.println("=================================");
        
        // LR-6
        demonstratePolymorphism();
        demonstrateCloning();
        demonstrateExceptions();
        // LR-7
        demonstrateDelegation();
        // LR-8
        demonstrateContainer();
        
        // Запуск игры
        System.out.println("\n=== ЗАПУСК ИГРЫ ===");
        GameSettings settings = new GameSettings(6, 6, 10);
        Game game = new Game(settings, "Даниил");
        game.play();
    }
}