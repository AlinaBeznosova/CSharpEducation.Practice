/*Напишите программу для вычисления выражения (а + b — f / а) + f * a * a — (a +
b). Все переменные задаются пользователем. Учтите деление на 0.*/

using System;

class PracticeTask2_3
{
    static void Main()
    {
        Console.WriteLine("Посчитаем значение выражения (а + b — f / а) + f * a * a — (a + b)");
        int a, b, f;
        Console.Write("Введите переменную a, неравную 0: ");
        
       
        string? userInput = Console.ReadLine();
        a = Convert.ToInt32(userInput);

        while (a == 0)
        {
            Console.Write("Вы ввели 0. Введите другое число ");
            userInput = Console.ReadLine();
            a = Convert.ToInt32(userInput);
            if ( a != 0)
                break;
        }
        

        Console.Write("Введите переменную b: ");
        userInput = Console.ReadLine();
        b = Convert.ToInt32(userInput);

        Console.Write("Введите переменную f: ");
        userInput = Console.ReadLine();
        f = Convert.ToInt32(userInput);

        double result = (a + b - f / a) + f * a * a - (a + b);
        Console.WriteLine("Значение выражения (а + b — f / а) + f * a * a — (a + b) = " + result);


    }
}