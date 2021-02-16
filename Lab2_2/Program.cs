using System;
using static System.Math;

namespace Lab2_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Результати обчислення функції y=(1/Tan(x))-(2*Sin(x)) \nна проміжку [-(PI/2), PI/2] з кроком PI/20\n");
            Console.WriteLine("-------------------------");
            Console.WriteLine("|    x   |    y=f(x)    |\n|-----------------------|");
            double a = -(PI / 2); // від
            double b = PI / 2; // до
            double dx = PI / 20; // крок 
            double x = a;
            double y; // функція яку треба обчислити
            while (x <= b) // на промыжку а б
            {
                y = (1 / Tan(x)) - (2 * Sin(x)); // функція яку треба обчислити
                Console.WriteLine("| {0,6:N2} {2} {1,12:N2} |", x, y, "|"); // Виведення результату в вигляді таблиці
                x += dx; // збільшеннч х на крок dx
            }
            Console.WriteLine("-------------------------");
            _ = Console.ReadKey(); // пазуа
        }
    }
}
