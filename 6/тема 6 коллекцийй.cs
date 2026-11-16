using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("===== ГЛАВНОЕ МЕНЮ =====");
            Console.WriteLine("1. Список покупок");
            Console.WriteLine("2. Телефонная книга");
            Console.WriteLine("3. Уникальные участники");
            Console.WriteLine("4. Очередь в поликлинике");
            Console.WriteLine("5. История действий");
            Console.WriteLine("0. Выход");

            Console.Write("Выберите задание: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                ShoppingList();
            }
            else if (choice == 2)
            {
                PhoneBook();
            }
            else if (choice == 3)
            {
                Participants();
            }
            else if (choice == 4)
            {
                HospitalQueue();
            }
            else if (choice == 5)
            {
                ActionHistory();
            }
            else if (choice == 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Неверный выбор!");
            }
        }
    }

    // ЗАДАНИЕ 1. СПИСОК ПОКУПОК  
    static void ShoppingList()
    {
        List<string> products = new List<string>();

        while (true)
        {
            Console.WriteLine("\n===== СПИСОК ПОКУПОК =====");
            Console.WriteLine("1. Добавить товар");
            Console.WriteLine("2. Показать товары");
            Console.WriteLine("3. Удалить товар");
            Console.WriteLine("4. Выход");

            Console.Write("Выберите действие: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Введите товар: ");
                string product = Console.ReadLine();

                products.Add(product);

                Console.WriteLine("Товар добавлен.");
            }
            else if (choice == 2)
            {
                if (products.Count == 0)
                {
                    Console.WriteLine("Список пуст.");
                }
                else
                {
                    Console.WriteLine("Список товаров:");

                    int number = 1;

                    foreach (string product in products)
                    {
                        Console.WriteLine(number + ". " + product);
                        number++;
                    }
                }
            }
            else if (choice == 3)
            {
                Console.Write("Введите товар для удаления: ");
                string product = Console.ReadLine();

                if (products.Remove(product))
                {
                    Console.WriteLine("Товар удалён.");
                }
                else
                {
                    Console.WriteLine("Такого товара нет.");
                }
            }
            else if (choice == 4)
            {
                break;
            }
        }
    }

    // ЗАДАНИЕ 2. ТЕЛЕФОННАЯ КНИГА  
    static void PhoneBook()
    {
        Dictionary<string, string> contacts =
            new Dictionary<string, string>(
                StringComparer.OrdinalIgnoreCase);

        while (true)
        {
            Console.WriteLine("\n===== ТЕЛЕФОННАЯ КНИГА =====");
            Console.WriteLine("1. Добавить контакт");
            Console.WriteLine("2. Найти номер");
            Console.WriteLine("3. Удалить контакт");
            Console.WriteLine("4. Показать контакты");
            Console.WriteLine("5. Выход");

            Console.Write("Выберите действие: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Имя: ");
                string name = Console.ReadLine();

                Console.Write("Телефон: ");
                string phone = Console.ReadLine();

                if (!contacts.ContainsKey(name))
                {
                    contacts.Add(name, phone);
                    Console.WriteLine("Контакт добавлен.");
                }
                else
                {
                    Console.WriteLine("Такое имя уже существует.");
                }
            }
            else if (choice == 2)
            {
                Console.Write("Введите имя: ");
                string name = Console.ReadLine();

                if (contacts.ContainsKey(name))
                {
                    Console.WriteLine("Телефон: " + contacts[name]);
                }
                else
                {
                    Console.WriteLine("Контакт не найден.");
                }
            }
            else if (choice == 3)
            {
                Console.Write("Введите имя: ");
                string name = Console.ReadLine();

                if (contacts.Remove(name))
                {
                    Console.WriteLine("Контакт удалён.");
                }
                else
                {
                    Console.WriteLine("Контакт не найден.");
                }
            }
            else if (choice == 4)
            {
                if (contacts.Count == 0)
                {
                    Console.WriteLine("Телефонная книга пуста.");
                }
                else
                {
                    foreach (var contact in contacts)
                    {
                        Console.WriteLine(
                            contact.Key + " - " + contact.Value);
                    }
                }
            }
            else if (choice == 5)
            {
                break;
            }
        }
    }

    // ЗАДАНИЕ 3. УНИКАЛЬНЫЕ УЧАСТНИКИ  
    static void Participants()
    {
        HashSet<string> students =
            new HashSet<string>(
                StringComparer.OrdinalIgnoreCase);

        while (true)
        {
            Console.Write("Введите имя (стоп для завершения): ");
            string name = Console.ReadLine();

            if (name == "стоп")
            {
                break;
            }

            if (name == "")
            {
                Console.WriteLine("Имя не может быть пустым.");
            }
            else if (students.Contains(name))
            {
                Console.WriteLine("Такой участник уже зарегистрирован.");
            }
            else
            {
                students.Add(name);
                Console.WriteLine("Участник добавлен.");
            }
        }

        Console.WriteLine("Всего уникальных участников: "
            + students.Count);
    }

    // ЗАДАНИЕ 4. ОЧЕРЕДЬ В ПОЛИКЛИНИКЕ  
    static void HospitalQueue()
    {
        Queue<string> patients = new Queue<string>();

        while (true)
        {
            Console.WriteLine("\n===== ПОЛИКЛИНИКА =====");
            Console.WriteLine("1. Добавить пациента");
            Console.WriteLine("2. Вызвать следующего");
            Console.WriteLine("3. Посмотреть следующего");
            Console.WriteLine("4. Показать очередь");
            Console.WriteLine("5. Выход");

            Console.Write("Выберите действие: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Введите имя пациента: ");
                string name = Console.ReadLine();

                patients.Enqueue(name);

                Console.WriteLine("Пациент добавлен.");
            }
            else if (choice == 2)
            {
                if (patients.Count > 0)
                {
                    string name = patients.Dequeue();

                    Console.WriteLine("Пациент " + name + " вызван.");
                }
                else
                {
                    Console.WriteLine("Очередь пуста.");
                }
            }
            else if (choice == 3)
            {
                if (patients.Count > 0)
                {
                    Console.WriteLine(
                        "Следующий пациент: " + patients.Peek());
                }
                else
                {
                    Console.WriteLine("Очередь пуста.");
                }
            }
            else if (choice == 4)
            {
                if (patients.Count == 0)
                {
                    Console.WriteLine("Очередь пуста.");
                }
                else
                {
                    Console.WriteLine("Список пациентов:");

                    int number = 1;

                    foreach (string patient in patients)
                    {
                        Console.WriteLine(number + ". " + patient);
                        number++;
                    }
                }
            }
            else if (choice == 5)
            {
                break;
            }
        }
    }

    // ЗАДАНИЕ 5. ИСТОРИЯ ДЕЙСТВИЙ  
    static void ActionHistory()
    {
        Stack<string> history = new Stack<string>();

        while (true)
        {
            Console.WriteLine("\n===== ИСТОРИЯ ДЕЙСТВИЙ =====");
            Console.WriteLine("1. Выполнить действие");
            Console.WriteLine("2. Отменить последнее действие");
            Console.WriteLine("3. Посмотреть последнее действие");
            Console.WriteLine("4. Показать историю");
            Console.WriteLine("5. Выход");

            Console.Write("Выберите действие: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Введите действие: ");
                string action = Console.ReadLine();

                history.Push(action);

                Console.WriteLine("Действие сохранено.");
            }
            else if (choice == 2)
            {
                if (history.Count > 0)
                {
                    string action = history.Pop();

                    Console.WriteLine("Отменено: " + action);
                }
                else
                {
                    Console.WriteLine("История пустая.");
                }
            }
            else if (choice == 3)
            {
                if (history.Count > 0)
                {
                    Console.WriteLine(
                        "Последнее действие: " + history.Peek());
                }
                else
                {
                    Console.WriteLine("История пустая.");
                }
            }
            else if (choice == 4)
            {
                if (history.Count == 0)
                {
                    Console.WriteLine("История пустая.");
                }
                else
                {
                    Console.WriteLine("История действий:");

                    foreach (string action in history)
                    {
                        Console.WriteLine(action);
                    }
                }
            }
            else if (choice == 5)
            {
                break;
            }
        }
    }

}