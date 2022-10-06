using System;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Open();
        }
        static void Open()
        {
            Console.Clear(); // очистить консоль
            Console.WriteLine("Выберите программу, которую хотите запустить");
            Console.WriteLine("1. Угадайте число");
            Console.WriteLine("2. Таблицы умножения");
            Console.WriteLine("3. Вывод делителей числа");
            Console.WriteLine("4. Закрыть программу");
            Input(Console.ReadLine());
        }
        static void Input(string input)
        {
            Console.Clear(); // очистить консоль
            if (Convert.ToInt32(input) == 1)
            {
                int min = 0, max = 2;
                Console.WriteLine($"Добро пожаловать в - Угадайте число от {min} до {max}");
                Console.WriteLine("Чтобы выйти напишите - exit");

                Random rnd = new Random(); //Создание объекта для генерации чисел
                Randomer(rnd.Next(min, max)); //Получить случайное число (в диапазоне от 0 до 10)
            }
            else if (Convert.ToInt32(input) == 2)
            {
                Console.WriteLine($"Добро пожаловать в - Таблицу умножения");
                for (int i = 2; i < 11; i++)
                {
                    for (int j = 2; j < 11; j++)
                    {
                        int result = i * j;
                        Console.Write($"{i}*{j}={result}\t");
                    }
                    Console.WriteLine();
                }
                Console.Write("Нажмите на любую кнопку... ");
                Console.ReadLine();
                Open();
            }
            else if (Convert.ToInt32(input) == 3)
            {
                Console.WriteLine($"Добро пожаловать в - Вывод делителей числа");
                Console.WriteLine("Чтобы выйти напишите - exit");
                Value1();
            }
            else if (Convert.ToInt32(input) == 4) Environment.Exit(0);
        }
        static void Randomer(int value)
        {
            Console.Write("Ввод: ");
            string input = Console.ReadLine();
            if (input == "exit") Open();
            else if (Convert.ToInt32(input) > value) Console.WriteLine("Надо меньше");
            else if (Convert.ToInt32(input) < value) Console.WriteLine("Надо больше");

            if (Convert.ToInt32(input) == value) Open();
            else Randomer(value);
        }
        static void Value1()
        {
            Console.Write("Ввод: ");
            string input = Console.ReadLine();
            if (input == "exit") Open();
            else Value2(Convert.ToInt32(input));
        }
        static void Value2(int value)
        {
            Console.Write($"Число {value}:\t");
            for (int i = 1; i <= value; i++) if (value % i == 0) Console.Write($"{i}\t"); 
            Console.WriteLine();
            Value1();
        }
    }
}
