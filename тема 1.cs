using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Выберите задание:");
        Console.WriteLine("1 - Информация о человеке");
        Console.WriteLine("2 - Стоимость товара");
        Console.WriteLine("3 - Возраст в месяцах и днях");
        Console.WriteLine("4 - Расчёт зарплаты");
        Console.WriteLine("5 - Расчёт стоимости поездки");
        Console.WriteLine("6 - Средний балл");

        Console.Write("Введите номер задания: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        if (choice == 1)
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите город: ");
            string city = Console.ReadLine();

            Console.Write("Введите специальность: ");
            string speciality = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Меня зовут " + name + ". Мне " + age +
                " лет. Я живу в городе " + city +
                ". Моя специальность — " + speciality + ".");
        }
        else if (choice == 2)
        {
            Console.Write("Введите название товара: ");
            string product = Console.ReadLine();

            Console.Write("Введите цену товара: ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите количество: ");
            int count = Convert.ToInt32(Console.ReadLine());

            double total = price * count;

            Console.WriteLine();
            Console.WriteLine("Товар: " + product);
            Console.WriteLine("Цена: " + price);
            Console.WriteLine("Количество: " + count);
            Console.WriteLine("Итого: " + total + " тг.");
        }
        else if (choice == 3)
        {
            Console.Write("Введите ваш возраст в годах: ");
            int age = Convert.ToInt32(Console.ReadLine());

            int months = age * 12;
            int days = age * 365;

            Console.WriteLine();
            Console.WriteLine("Месяцев: " + months);
            Console.WriteLine("Дней: " + days);
        }
        else if (choice == 4)
        {
            Console.Write("Введите количество часов: ");
            double hours = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите оплату за один час: ");
            double payment = Convert.ToDouble(Console.ReadLine());

            double salary = hours * payment;

            Console.WriteLine();
            Console.WriteLine("Итоговая зарплата: " + salary + " тг.");
        }
        else if (choice == 5)
        {
            Console.Write("Введите расстояние в км: ");
            double distance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите расход на 100 км: ");
            double rashod = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите стоимость 1 литра бензина: ");
            double price = Convert.ToDouble(Console.ReadLine());

            double liters = distance * rashod / 100;
            double cost = liters * price;

            Console.WriteLine();
            Console.WriteLine("Потребуется бензина: " + liters + " л");
            Console.WriteLine("Стоимость поездки: " + cost + " тг.");
        }
        else if (choice == 6)
        {
            Console.Write("Введите оценку по 1 предмету: ");
            double grade1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите оценку по 2 предмету: ");
            double grade2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите оценку по 3 предмету: ");
            double grade3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите оценку по 4 предмету: ");
            double grade4 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите оценку по 5 предмету: ");
            double grade5 = Convert.ToDouble(Console.ReadLine());

            double average = (grade1 + grade2 + grade3 + grade4 + grade5) / 5;

            Console.WriteLine();
            Console.WriteLine("Средний балл: " + average);
        }
        else
        {
            Console.WriteLine("Такого задания нет.");
        }
    }
}