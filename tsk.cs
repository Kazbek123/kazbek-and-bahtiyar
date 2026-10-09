using System;

class Program
{
    static void Main()
    {
        // Задание 1. Совершеннолетие
        Console.WriteLine("ЗАДАНИЕ 1");
        Console.Write("Введите возраст: ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age >= 18)
        {
            Console.WriteLine("Доступ разрешен.");
        }
        else
        {
            Console.WriteLine("Доступ запрещен.");
        }


        // Задание 2. Положительное или отрицательное
        Console.WriteLine("\nЗАДАНИЕ 2");
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number > 0)
        {
            Console.WriteLine("Число положительное.");
        }
        else if (number < 0)
        {
            Console.WriteLine("Число отрицательное.");
        }
        else
        {
            Console.WriteLine("Число равно нулю.");
        }


        // Задание 3. Четное или нечетное
        Console.WriteLine("\nЗАДАНИЕ 3");
        Console.Write("Введите целое число: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        if (number2 % 2 == 0)
        {
            Console.WriteLine("Число четное.");
        }
        else
        {
            Console.WriteLine("Число нечетное.");
        }


        // Задание 4. Максимальное число
        Console.WriteLine("\nЗАДАНИЕ 4");
        Console.Write("Введите первое число: ");
        int first = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int second = Convert.ToInt32(Console.ReadLine());

        if (first > second)
        {
            Console.WriteLine("Большее число: " + first);
        }
        else if (second > first)
        {
            Console.WriteLine("Большее число: " + second);
        }
        else
        {
            Console.WriteLine("Числа одинаковые.");
        }


        // Задание 5. Система оценивания
        Console.WriteLine("\nЗАДАНИЕ 5");
        Console.Write("Введите количество баллов: ");
        int points = Convert.ToInt32(Console.ReadLine());

        if (points < 0 || points > 100)
        {
            Console.WriteLine("Ошибка: значение должно быть от 0 до 100.");
        }
        else if (points <= 49)
        {
            Console.WriteLine("Неудовлетворительно");
        }
        else if (points <= 69)
        {
            Console.WriteLine("Удовлетворительно");
        }
        else if (points <= 89)
        {
            Console.WriteLine("Хорошо");
        }
        else
        {
            Console.WriteLine("Отлично");
        }


        // Задание 6. Стоимость доставки
        Console.WriteLine("\nЗАДАНИЕ 6");
        Console.Write("Введите сумму заказа: ");
        int order = Convert.ToInt32(Console.ReadLine());

        int delivery;

        if (order < 5000)
        {
            delivery = 1000;
        }
        else if (order <= 10000)
        {
            delivery = 500;
        }
        else
        {
            delivery = 0;
        }

        int total = order + delivery;

        Console.WriteLine("Стоимость товаров: " + order + " тг.");
        Console.WriteLine("Стоимость доставки: " + delivery + " тг.");
        Console.WriteLine("Итоговая сумма: " + total + " тг.");
    }
}