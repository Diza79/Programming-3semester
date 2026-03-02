import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        // Настройки игры
        GameSettings settings = new GameSettings(10, 10, 15); // Ширина, высота, условие победы
        Game game = new Game(settings, "Игрок 1");
        game.play(); // Запуск игры
    }
}
