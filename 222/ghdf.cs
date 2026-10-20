using System;

class Program
{
    // Задание 1. Персональное приветствие
    static void PrintGreeting(string name)
    {
        Console.WriteLine("Привет, " + name + "! Добро пожаловать!");
    }

    // Задание 2. Площадь прямоугольника
    static int CalculateArea(int length, int width)
    {
        return length * width;
    }

    // Задание 3. Проверка числа на четность
    static bool IsEven(int number)
    {
        if (number % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Задание 4. Таблица умножения
    static void PrintMultiplicationTable(int number)
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(number + " x " + i + " = " + (number * i));
        }
    }

    // Задание 5. Калькулятор

    static double Add(double a, double b)
    {
        return a + b;
    }

    static double Subtract(double a, double b)
    {
        return a - b;
    }

    static double Multiply(double a, double b)
    {
        return a * b;
    }

    static double Divide(double a, double b)
    {
        return a / b;
    }

    static void Main()
    {
        // Задание 1
        Console.WriteLine("ЗАДАНИЕ 1. ПРИВЕТСТВИЕ");
        Console.Write("Введите имя: ");
        string name = Console.ReadLine();

        PrintGreeting(name);

        // Задание 2
        Console.WriteLine();
        Console.WriteLine("ЗАДАНИЕ 2. ПЛОЩАДЬ ПРЯМОУГОЛЬНИКА");

        Console.Write("Введите длину: ");
        int length = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите ширину: ");
        int width = Convert.ToInt32(Console.ReadLine());

        int area = CalculateArea(length, width);

        Console.WriteLine("Площадь: " + area);

        // Задание 3
        Console.WriteLine();
        Console.WriteLine("ЗАДАНИЕ 3. ПРОВЕРКА ЧИСЛА");

        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (IsEven(number))
        {
            Console.WriteLine("Число четное");
        }
        else
        {
            Console.WriteLine("Число нечетное");
        }

        // Задание 4
        Console.WriteLine();
        Console.WriteLine("ЗАДАНИЕ 4. ТАБЛИЦА УМНОЖЕНИЯ");

        Console.Write("Введите число: ");
        int tableNumber = Convert.ToInt32(Console.ReadLine());

        PrintMultiplicationTable(tableNumber);

        // Задание 5
        Console.WriteLine();
        Console.WriteLine("ЗАДАНИЕ 5. КАЛЬКУЛЯТОР");

        string answer = "да";

        while (answer == "да")
        {
            Console.Write("Введите первое число: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("1. Сложение");
            Console.WriteLine("2. Вычитание");
            Console.WriteLine("3. Умножение");
            Console.WriteLine("4. Деление");

            Console.Write("Выберите операцию: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Результат: " + Add(a, b));
            }
            else if (choice == 2)
            {
                Console.WriteLine("Результат: " + Subtract(a, b));
            }
            else if (choice == 3)
            {
                Console.WriteLine("Результат: " + Multiply(a, b));
            }
            else if (choice == 4)
            {
                if (b == 0)
                {
                    Console.WriteLine("На ноль делить нельзя!");
                }
                else
                {
                    Console.WriteLine("Результат: " + Divide(a, b));
                }
            }
            else
            {
                Console.WriteLine("Неправильный выбор операции!");
                            Console.Write("Хотите продолжить? (да/нет): ");
            answer = Console.ReadLine().ToLower();
        }
    }
}}