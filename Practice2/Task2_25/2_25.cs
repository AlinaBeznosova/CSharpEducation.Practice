/*Создайте перечисление (enum) для дней недели. Напишите программу, которая
считывает ввод пользователя и в зависимости от его ввода (число от 1 до 7)
будет выводиться на экран консоли соответствующий день недели*/

using System;
using System.Security.Cryptography;
class Practice2_25
{
    public enum WeekDays
    {
        Monday = 1,
        Tuesday = 2,
        Wensday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7
    }
    static void Main()
    {
        Console.WriteLine("Введите число от 1 до 7 для получения соответствующего дня недели: ");
        int input = Convert.ToInt32(Console.ReadLine());
        if (input >=1 && input <=7)
        {
            WeekDays day = (WeekDays)input;

            // Выводим день недели на экран
            Console.WriteLine($"День недели: {day}");
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Введите число от 1 до 7");
        }
    }
}