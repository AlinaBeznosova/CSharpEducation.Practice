/*Нарисуйте прямоугольный треугольник звёздочками. Чтобы высоту
треугольника можно было задавать программно.*/

using System;

class PracticeTask2_4
{
    static void Main()
    {
        Console.Write("Введите высоту первого треугольника: "); //первый треугольник
        string? input = Console.ReadLine();
        int height;
       
        if (int.TryParse(input, out height))
        {
            for (int i = 0; i < height + 1; i++)
            {
                for (int j = 0; j < i ; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Неправильный ввод. Пожалуйста, введите целое число.");
        }


        Console.Write("Введите высоту второго треугольника: "); //зеркальный треугольник
        input = Console.ReadLine();

        if (int.TryParse(input, out height))
        {
            for (int i = 0; i < height + 1; i++)
            {
                for (int j = 0; j < height - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i; k ++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Неправильный ввод. Пожалуйста, введите целое число.");
        }


        Console.Write("Введите высоту третьего треугольника: "); //нарисовать треугольник другим символом
        input = Console.ReadLine();

        Console.Write("Введите символ, которым будет нарисован треугольник: ");
        ConsoleKeyInfo inputSymbol = Console.ReadKey();
        char symbol = inputSymbol.KeyChar;

        if (int.TryParse(input, out height))
        {
            for (int i = 0; i < height + 1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Неправильный ввод. Пожалуйста, введите целое число.");
        }

    }
}
