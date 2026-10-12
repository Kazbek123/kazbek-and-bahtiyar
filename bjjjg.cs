using System;

class Program
{
    static void Main()
    {
        // Задание 1. Числа от 1 до N
        Console.WriteLine("Задание 1");
        Console.Write("Введите N: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine();

        // Задание 2. Чётные числа
        Console.WriteLine("\nЗадание 2");
        Console.Write("Введите N: ");
        n = Convert.ToInt32(Console.ReadLine());

        for (int i = 2; i <= n; i += 2)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine();

        // Задание 3. Сумма чисел от 1 до N
        Console.WriteLine("\nЗадание 3");
        Console.Write("Введите N: ");
        n = Convert.ToInt32(Console.ReadLine());

        int sum = 0;

        for (int i = 1; i <= n; i++)
        {
            sum = sum + i;
        }

        Console.WriteLine("Сумма: " + sum);

        // Задание 4. Таблица умножения
        Console.WriteLine("\nЗадание 4");
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(number + " x " + i + " = " + (number * i));
        }

        // Задание 5. Сумма и среднее арифметическое
        Console.WriteLine("\nЗадание 5");
        Console.Write("Сколько чисел хотите ввести? ");
        int count = Convert.ToInt32(Console.ReadLine());

        int total = 0;

        for (int i = 1; i <= count; i++)
        {
            Console.Write("Введите число: ");
            int value = Convert.ToInt32(Console.ReadLine());

            total = total + value;
        }

        Console.WriteLine("Сумма: " + total);

        if (count > 0)
        {
            double average = (double)total / count;
            Console.WriteLine("Среднее арифметическое: " + average);
        }

        // Задание 6. Угадай число
        Console.WriteLine("\nЗадание 6");

        int secret = 37;
        int guess = 0;
        int attempts = 0;

        while (guess != secret)
        {
            Console.Write("Угадайте число: ");
            guess = Convert.ToInt32(Console.ReadLine());

            attempts++;

            if (guess > secret)
            {
                Console.WriteLine("Слишком большое число.");
            }
            else if (guess < secret)
            {
                Console.WriteLine("Слишком маленькое число.");
            }
            else
            {
                Console.WriteLine("Вы угадали!");
                Console.WriteLine("Количество попыток: " + attempts);
            }
        }
    }
}