using System;

namespace Lab2_3B
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[SetSizeArray()]; // ініціалізація масива розміром який задав користувач

            SetValueArray(arr); // встановлення значень елементів масива
            PrintArray(arr); // друк масива в консоль

            Console.WriteLine("1) Кількість додатних елементав: {0}", NumMoreZero(arr)); // NumMoreZero - повертає кількість додатних елементів
            Console.WriteLine("2) добуток елементів масиву, розташованих до мінімального \n   за модулем елемента: {0}", DobutokToMinimumModul(arr)); // DobutokToMinimumModul - повертає добуток елементів масиву, розташованих до мінімального за модулем елемента.
            _ = Console.ReadKey();
        }

        public static int SetSizeArray(string str = null) // запит корректного розміру масива
        {
            int sizeArray; // для збереження розміру масива
            bool test = Test(str); // перевірка, чи дані для введення має задавати користувач чи вони вже є. Для тесту 
            do
            {
                do
                {
                    Console.Write("Введіть розмір масиву: ");
                    if (!test) { str = Console.ReadLine(); } // якщо це не тестовий запуск, запитує ввід від користувача
                } while (!int.TryParse(str, out sizeArray)); // запитує розмір масива доки не буде введено число

                if (sizeArray < 1)
                {
                    Console.WriteLine("\nРозмір масива не може бути менше одиниці!\n");
                }
            } while (sizeArray < 1); // надоїдає доки число менше одиниці
            Console.WriteLine();

            return sizeArray; // повертає розмір масива
        }

        public static void SetValueArray(int[] arr) // встановлення значень елементів масива
        {
            Random aRand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = aRand.Next(-100, 100); // генерація чисел в діапазоні [-100, 100]
            }
        }

        public static void PrintArray(int[] arr) // друк масива в консоль
        {
            Console.WriteLine("\nВведений масив:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("arr[{0}] = {1}", i, arr[i]);
            }
            Console.WriteLine();
        }

        public static uint NumMoreZero(int[] arr) // повертає кількість додатних елементів
        {
            uint numMoreZero = 0; // збереження кількості додатних чисел

            foreach (int elem in arr)
            {
                if (elem > 0) // якщо елемент масива додатній
                {
                    ++numMoreZero; // збільшення на одиницю
                }
            }
            return numMoreZero; // повернення кількості додатніх чисел
        }

        public static string DobutokToMinimumModul(int[] arr)
        {
            long dobutokToMinimumModul = 1; // перший множник одиниця
            int minModul = arr[0];
            foreach (int elem in arr) // знаходження мінімального за модулем елемента
            {
                if (Math.Abs(elem) < Math.Abs(minModul))
                {
                    minModul = elem;
                }
            }

            if (minModul == arr[0]) // якщо мінімальне число перше в масиві, повертає нуль
            {
                return "0";
            }

            try
            {
                for (int i = 0; i < Array.IndexOf(arr, minModul); i++) // множення всіх чисел в масиві до мінімального за модулем (не включно)
                {
                    dobutokToMinimumModul = checked(dobutokToMinimumModul * arr[i]);
                }
            }
            catch (OverflowException ex)
            {
                return ex.Message; // якщо при множенні було переповнення повідомляє про це користувача
            }

            return Convert.ToString(dobutokToMinimumModul); // повертає добуток елементів масиву, розташованих до мінімального за модулем елемента.
        }


        public static bool Test(string str)
        {
            return str != null; // якщо дані вводяться вручну повертає false
        }

    }
}
