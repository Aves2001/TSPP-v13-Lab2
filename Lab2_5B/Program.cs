using System;

namespace Lab2_5A
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] A = new int[SetSizeArray(0), SetSizeArray(1)]; // ініціалізація двохвимірного масиву (розмір задає користувач)
            GenerationArrayValues(A); // генерація значень елементів масива
            PrintArray(A); // вивід вмісту масива на екран
            ReplacementTwoElements(A); // 2 найменші елементи заміняє нулями, якщо найменшими елементами є 0 – то заміняє їх одиницями
            PrintArray(A); // вивід вмісту масива на екран
            _ = Console.ReadKey(); //пауза
        }

        public static int SetSizeArray(int size, string str = null) // задає розмір масива
        {
            int sizeArray = -1; // для збереження розміру масива
            bool test = Test(str); // перевірка, чи дані для введення має задавати користувач чи вони вже є. Для тесту 
            if (size == 0) // якщо задається розмір для рядків - це супроводжується відповідним текстом
            {
                do
                {
                    do
                    {
                        Console.Write("\nВведіть кількість рядків масиву: ");
                        if (!test) { str = Console.ReadLine(); } // якщо це не тестовий запуск, запитує ввід від користувача
                    } while (!int.TryParse(str, out sizeArray)); // запитує розмір масива доки не буде введено число

                    if (sizeArray < 1)
                    {
                        Console.WriteLine("\nКількість рядків не може бути менше одиниці!\n");
                    }
                } while (sizeArray < 1); // надоїдає доки число менше одиниці
            }
            else if (size == 1) // якщо задається розмір для стовпців - це супроводжується відповідним текстом
            {
                do
                {
                    do
                    {
                        Console.Write("Введіть кількість стовпців масиву: ");
                        if (!test) { str = Console.ReadLine(); } // якщо це не тестовий запуск, запитує ввід від користувача
                    } while (!int.TryParse(str, out sizeArray)); // запитує розмір масива доки не буде введено число

                    if (sizeArray < 1)
                    {
                        Console.WriteLine("\nКількість стовпців не може бути менше одиниці!\n");
                    }
                } while (sizeArray < 1); // надоїдає доки число менше одиниці
            }
            return sizeArray;
        }

        public static void GenerationArrayValues(int[,] arr) // генерація значень елементів масива
        {
            Random aRand = new Random();
            for (int i = 0; i < arr.GetLength(0); i++) // цикл по рядках
            {
                for (int j = 0; j < arr.GetLength(1); j++) // цикл по стовпцях
                {
                    arr[i, j] = aRand.Next(-100, 100); // генерація чисел в діапазоні [-100, 100]
                }
            }
        }

        public static void PrintArray(int[,] arr) // вивід вмісту масива на екран
        {
            Console.WriteLine("\nВведений масив:");
            for (int i = 0; i < arr.GetLength(0); i++) // цикл по рядках
            {
                for (int j = 0; j < arr.GetLength(1); j++) // цикл по стовпцях
                {
                    Console.Write("A[{0}][{1}] = {2}\t", i, j, arr[i, j]);
                }
                Console.WriteLine(); // відступ в один рядок
            }
        }

        public static void ReplacementTwoElements(int[,] arr) // 2 найменші елементи заміняє нулями, якщо найменшими елементами є 0 – то заміняє їх одиницями
        {
            int min1 = int.MaxValue; // перший мінімальний елемент
            int min1_i = -1; // рядок в якому він знаходиться
            int min1_j = -1; // стовпчик в якоку він знаходиться

            for (int i = 0; i < arr.GetLength(0); i++) // цикл по рядках
            {
                for (int j = 0; j < arr.GetLength(1); j++) // цикл по стовпцях
                {
                    if (arr[i, j] < min1) // пошук мінімального числа
                    {
                        min1 = arr[i, j]; // збереження мінімального числа
                        min1_i = i; // рядок в якому він знаходиться
                        min1_j = j; // стовпчик в якому він знаходиться
                    }
                }
            }

            Console.WriteLine("\nРезультат:");
            if ((int)arr.GetValue(min1_i, min1_j) == 0) // якщо перше мінімальне число це 0, замінити його на одиницю
            {
                arr.SetValue(1, min1_i, min1_j);
                Console.WriteLine("Мінімальний елемент A[{0}][{1}] = {2}, замінено на одиницю", min1_i, min1_j, min1);
            }
            else // інакше замінити його на нуль
            {
                arr.SetValue(0, min1_i, min1_j);
                Console.WriteLine("Мінімальний елемент A[{0}][{1}] = {2}, замінено на нуль", min1_i, min1_j, min1);
            }

            if (arr.Length > 1) // якщо в масиві більше одного елемента знаходить друге мінімальне число
            {
                int min2 = int.MaxValue;  // другий мінімальний елемент
                int min2_i = -1; // рядок в якому він знаходиться
                int min2_j = -1; // стовпчик в якоку він знаходиться

                for (int i = 0; i < arr.GetLength(0); i++) // цикл по рядках
                {
                    for (int j = 0; j < arr.GetLength(1); j++) // цикл по стовпцях
                    {
                        if (i == min1_i && j == min1_j) // якщо перевіряється число яке уже збережено як перше мінімальне, пропустити ітерацію
                        {
                            continue;
                        }
                        else if (arr[i, j] < min2) // інакше якщо воно менше зберегти його як друге мінімальне число
                        {
                            min2 = arr[i, j]; // збереження другоо мінімального числа
                            min2_i = i; // рядок в якому він знаходиться
                            min2_j = j; // стовпчик в якому він знаходиться
                        }
                    }
                }

                if ((int)arr.GetValue(min2_i, min2_j) == 0) // якщо друге мінімальне число це 0, замінити його на одиницю
                {
                    arr.SetValue(1, min2_i, min2_j);
                    Console.WriteLine("Мінімальний елемент A[{0}][{1}] = {2}, замінено на одиницю", min2_i, min2_j, min2);
                }
                else // інакше замінити його на нуль
                {
                    arr.SetValue(0, min2_i, min2_j);
                    Console.WriteLine("Мінімальний елемент A[{0}][{1}] = {2}, замінено на нуль", min2_i, min2_j, min2);
                }
            }
        }

        public static bool Test(string str)
        {
            return str != null; // якщо дані вводяться вручну повертає false
        }
    }
}
