/*Напишите программу для сравнения двух целых чисел. Ввод осуществляйте
через консоль*/

using System;

class PracticeTask2_5
{
    static void Main()
    {
        int a, b;

        Console.Write("Введите первое число ");
        string? input = Console.ReadLine();
        a = Convert.ToInt32(input);

        Console.Write("Введите второе число ");
        input = Console.ReadLine();
        b = Convert.ToInt32(input);

        if (a > b)
        {
            Console.WriteLine($"{a} больше {b}");
        }
        else if (a < b)
        {
            Console.WriteLine($"{a} меньше {b}");
        }
        else if (a == b)
        {
            Console.WriteLine($"{a} равно {b}");
        }
    }
}