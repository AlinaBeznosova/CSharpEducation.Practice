/* Напишите программу, в которой создаётся массив строк, который заполняется
пользователем через консоль. Затем этот массив должен быть выведен на
экран консоли*/

using System;

class Practice2_12
{
    static void Main()
    {
        Console.WriteLine("Введите размер массива: ");
        int n = Convert.ToInt32(Console.ReadLine());
        string[] array = new string[n];

        Console.WriteLine("Заполните массив строками");
        for(int i = 0; i < n; i++)
        {
            Console.WriteLine($"Введите {i+1} строку:");
            array[i] = Console.ReadLine();
        }

        Console.WriteLine("Результат:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}