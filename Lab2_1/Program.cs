using System;

namespace Lab2_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n; // Зберігає введений рік
            do
            {
                Console.Write("Введіть рік в діапазоні 20-69: ");
            } while (!int.TryParse(Console.ReadLine(), out n)); // Запитує користувача рік доки не буде введено число
            Console.WriteLine("\n Результат: {0}", n + " " + Declension(n)); // виводить на екран рік який ввів користувач та результат Declension для цього року

            _ = Console.ReadKey(); // пауза
        }

        public static string Declension(int year) // повертає відповідний рядок враховуючи передане число
        {
            switch (year)
            {
                case 20:
                case 25:
                case 26:
                case 27:
                case 28:
                case 29:
                case 30:
                case 35:
                case 36:
                case 37:
                case 38:
                case 39:
                case 40:
                case 45:
                case 46:
                case 47:
                case 48:
                case 49:
                case 50:
                case 55:
                case 56:
                case 57:
                case 58:
                case 59:
                case 60:
                case 65:
                case 66:
                case 67:
                case 68:
                case 69:
                    return "Років"; // Для вишеперечислених чисел повертає рядок: "Років"

                case 21:
                case 31:
                case 41:
                case 51:
                case 61:
                    return "Рік"; // Для вишеперечислених чисел повертає рядок: "Рік"

                case 22:
                case 23:
                case 24:
                case 32:
                case 33:
                case 34:
                case 42:
                case 43:
                case 44:
                case 52:
                case 53:
                case 54:
                case 62:
                case 63:
                case 64:
                    return "Роки"; // Для вишеперечислених чисел повертає рядок: "Роки"

                default: return "не в діапазоні [20-69]"; // Якщо введене користувачем число не попадає в діапазон, повертає рядок: "не в діапазоні [20-69]"
            }
        }
    }
}
