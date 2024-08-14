using System;
using MyLib;

class Program
{
    static void Main()
    {
        double a;
        double b;

        Console.WriteLine($"Введите два числа для сложения: ");
        a = Convert.ToDouble(Console.ReadLine());
        b = Convert.ToDouble(Console.ReadLine());

        MathHelper.Addition(a, b);

        Console.WriteLine($"Введите два числа для вычитания: ");
        a = Convert.ToDouble(Console.ReadLine());
        b = Convert.ToDouble(Console.ReadLine());

        MathHelper.Substraction(a, b);

        Console.WriteLine($"Введите два числа для умножения: ");
        a = Convert.ToDouble(Console.ReadLine());
        b = Convert.ToDouble(Console.ReadLine());

        MathHelper.Multiplication(a, b);

        Console.WriteLine($"Введите два числа для деления: ");
        a = Convert.ToDouble(Console.ReadLine());
        b = Convert.ToDouble(Console.ReadLine());

        MathHelper.Division(a, b);
    }
}

