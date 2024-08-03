/*Напишите программу для вычисления високосного года.
a. год, номер которого кратен 400, — високосный;
остальные годы, номер которых кратен 100, — невисокосные
остальные годы, номер которых кратен 4, — високосный;
все остальные годы — невисокосные.*/

using System;
class Practice2_23
{
    public static bool checkYear(int year)
    {
        return (year % 400 == 0) || ((year % 100 != 0) && (year % 4 == 0));
    }
    static void Main()
    {
        Console.WriteLine("Давайте выясним, является ли год високосным. Введите год:");
        int year = Convert.ToInt32(Console.ReadLine());

        if (checkYear(year))
        {
            Console.WriteLine("Год високосный");
        }   
        else
        {
            Console.WriteLine("Год невисокосный");
        }
    }

}