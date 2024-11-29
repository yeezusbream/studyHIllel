using System;
using System.Collections.Generic;

class ToDoListApp
{
    static List<string> toDoList = new List<string>();

    static void Main()
    {
        Console.WriteLine("Добро пожаловать в приложение \"Список дел\"!");

        while (true)
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Добавить новое дело");
            Console.WriteLine("2. Показать все дела");
            Console.WriteLine("3. Отметить дело как выполненное");
            Console.WriteLine("4. Удалить дело");
            Console.WriteLine("5. Показать список дел (если он существует)");
            Console.WriteLine("6. Выход");

            Console.Write("\nВведите номер команды: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    ShowTasks();
                    break;
                case "3":
                    MarkTaskAsDone();
                    break;
                case "4":
                    DeleteTask();
                    break;
                case "5":
                    LoadTasks();
                    break;
                case "6":
                    Console.WriteLine("До свидания!");
                    return;
                default:
                    Console.WriteLine("Неверная команда. Попробуйте снова.");
                    break;
            }
        }
    }

    static void AddTask()
    {
        Console.Write("Введите новое дело: ");
        string newTask = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(newTask))
        {
            toDoList.Add(newTask);
            Console.WriteLine($"Дело \"{newTask}\" добавлено.");
        }
        else
        {
            Console.WriteLine("Дело не может быть пустым!");
        }
    }

    static void ShowTasks()
    {
        if (toDoList.Count == 0)
        {
            Console.WriteLine("Список дел пуст.");
            return;
        }

        Console.WriteLine("\nВаш список дел:");
        for (int i = 0; i < toDoList.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {toDoList[i]}");
        }
    }

    static void MarkTaskAsDone()
    {
        if (toDoList.Count == 0)
        {
            Console.WriteLine("\nСписок дел пуст.");
            return;
        }

        Console.Write("\nВведите номер дела, которое выполнено: ");
        if (int.TryParse(Console.ReadLine(), out int taskIndex) && taskIndex > 0 && taskIndex <= toDoList.Count)
        {
            toDoList[taskIndex - 1] += " (≧∇≦)ﾉ";
            Console.WriteLine("Дело отмечено как выполненное.");
        }
        else
        {
            Console.WriteLine("Неверный номер дела.");
        }
    }

    static void DeleteTask()
    {
        if (toDoList.Count == 0)
        {
            Console.WriteLine("Список дел пуст.");
            return;
        }

        Console.Write("Введите номер дела, которое хотите удалить: ");
        if (int.TryParse(Console.ReadLine(), out int taskIndex) && taskIndex > 0 && taskIndex <= toDoList.Count)
        {
            Console.WriteLine($"Дело \"{toDoList[taskIndex - 1]}\" удалено.");
            toDoList.RemoveAt(taskIndex - 1);
        }
        else
        {
            Console.WriteLine("Неверный номер дела.");
        }
    }

    static void LoadTasks()
    {
        if (toDoList.Count == 0)
        {
            Console.WriteLine("Список дел пуст.");
        }
        else
        {
            Console.WriteLine("Ваш текущий список дел:");
            ShowTasks();
        }
    }
}
