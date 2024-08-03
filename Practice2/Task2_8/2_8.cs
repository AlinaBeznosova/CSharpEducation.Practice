/*Составить алгоритм увеличения всех трех, введенных с клавиатуры,
переменных на 5,если среди них есть хотя бы две равные. В противном случае
выдать ответ «равных нет».*/

using System;

class PracticeTask2_8
{
    static void Main()
    {
        int a, b, c;
        Console.WriteLine($"Введите три переменных:");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        c = Convert.ToInt32(Console.ReadLine());

        if ((a == b) || (a == c) || (b == c))
        {
            Console.WriteLine($"Результат: {a + 5} {b + 5} {c + 5}");
        }
        else
        {
            Console.WriteLine("Равных нет");
        }
    }
}