
using System;

class Program
{
    static void Main()
    {
        // Задание 1. Список оценок
        Console.WriteLine("ЗАДАНИЕ 1. СПИСОК ОЦЕНОК");

        int[] grades = new int[5];

        for (int i = 0; i < grades.Length; i++)
        {
            Console.Write("Введите оценку " + (i + 1) + ": ");
            grades[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Оценки студента:");

        foreach (int grade in grades)
        {
            Console.Write(grade + " ");
        }

        Console.WriteLine();
        Console.WriteLine();


        // Задание 2. Сумма элементов
        Console.WriteLine("ЗАДАНИЕ 2. СУММА ЭЛЕМЕНТОВ");

        int[] numbers = new int[6];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Введите число " + (i + 1) + ": ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Сумма элементов: " + CalculateSum(numbers));
        Console.WriteLine();


        // Задание 3. Чётные и нечётные числа
        Console.WriteLine("ЗАДАНИЕ 3. ЧЁТНЫЕ И НЕЧЁТНЫЕ ЧИСЛА");

        int[] numbers2 = new int[10];

        for (int i = 0; i < numbers2.Length; i++)
        {
            Console.Write("Введите число " + (i + 1) + ": ");
            numbers2[i] = Convert.ToInt32(Console.ReadLine());
        }

        int evenCount = 0;
        int oddCount = 0;

        for (int i = 0; i < numbers2.Length; i++)
        {
            if (IsEven(numbers2[i]))
            {
                evenCount++;
            }
            else
            {
                oddCount++;
            }
        }

        Console.WriteLine("Чётных чисел: " + evenCount);
        Console.WriteLine("Нечётных чисел: " + oddCount);
        Console.WriteLine();


        // Задание 4. Поиск максимального значения
        Console.WriteLine("ЗАДАНИЕ 4. МАКСИМАЛЬНОЕ ЧИСЛО");

        int[] numbers3 = new int[7];

        for (int i = 0; i < numbers3.Length; i++)
        {
            Console.Write("Введите число " + (i + 1) + ": ");
            numbers3[i] = Convert.ToInt32(Console.ReadLine());
        }

        int max = numbers3[0];
        int maxIndex = 0;

        for (int i = 1; i < numbers3.Length; i++)
        {
            if (numbers3[i] > max)
            {
                max = numbers3[i];
                maxIndex = i;
            }
        }

        Console.WriteLine("Максимальное число: " + max);
        Console.WriteLine("Индекс: " + maxIndex);
        Console.WriteLine();


        // Задание 5. Анализ успеваемости
        Console.WriteLine("ЗАДАНИЕ 5. АНАЛИЗ УСПЕВАЕМОСТИ");

        Console.Write("Количество студентов: ");
        int count = Convert.ToInt32(Console.ReadLine());

        while (count <= 0)
        {
            Console.Write("Введите положительное количество студентов: ");
            count = Convert.ToInt32(Console.ReadLine());
        }

        int[] studentGrades = new int[count];

        for (int i = 0; i < studentGrades.Length; i++)
        {
            Console.Write("Оценка студента " + (i + 1) + ": ");
            studentGrades[i] = Convert.ToInt32(Console.ReadLine());

            while (studentGrades[i] < 0 || studentGrades[i] > 100)
            {
                Console.Write("Введите оценку от 0 до 100: ");
                studentGrades[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("Средний балл: " +
            CalculateAverage(studentGrades).ToString("F2"));

        Console.WriteLine("Максимальный балл: " +
            FindMax(studentGrades));

        Console.WriteLine("Минимальный балл: " +
            FindMin(studentGrades));

        Console.WriteLine("Студентов с оценкой 70 и выше: " +
            CountPassed(studentGrades));
    }


    // Метод для вычисления суммы
    static int CalculateSum(int[] numbers)
    {
        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum = sum + numbers[i];
        }

        return sum;
    }


    // Задание 3. Проверка чётности числа
    static bool IsEven(int number)
    {
        return number % 2 == 0;
    }


    // Задание 5. Вычисление среднего балла
    static double CalculateAverage(int[] grades)
    {
        int sum = 0;

        for (int i = 0; i < grades.Length; i++)
        {
            sum += grades[i];
        }

        return (double)sum / grades.Length;
    }


    // Задание 5. Поиск максимальной оценки
    static int FindMax(int[] grades)
    {
        int max = grades[0];

        for (int i = 1; i < grades.Length; i++)
        {
            if (grades[i] > max)
            {
                max = grades[i];
            }
        }

        return max;
    }


    // Задание 5. Поиск минимальной оценки
    static int FindMin(int[] grades)
    {
        int min = grades[0];

        for (int i = 1; i < grades.Length; i++)
        {
            if (grades[i] < min)
            {
                min = grades[i];
            }
        }

        return min;
    }


    // Задание 5. Подсчёт студентов с оценкой 70 и выше
    static int CountPassed(int[] grades)
    {
        int count = 0;

        for (int i = 0; i < grades.Length; i++)
        {
            if (grades[i] >= 70)
            {
                count++;
            }
        }

        return count;
    }
}
