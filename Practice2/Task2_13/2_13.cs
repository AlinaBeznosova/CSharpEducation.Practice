/*Напишите метод, который создаёт двумерный массив (не зубчатый). Размеры
массива передавайте через аргументы метода. Также напишите отдельный
метод для вывода двумерного массива в виде матрицы на экран консоли.
Массив заполните случайными числами.*/

using System;
using System.Runtime.InteropServices;

class Practice2_13
{
    public static int[,] createArray(int n, int m)
    {
        int[,] array = new int[n , m];
        Random rand = new Random();

        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < m; j++)
            {
                array[i, j] = rand.Next(1, 100);
            }
        }
        return array;
    }

    public static void printArray(int[,] array, int n, int m)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(array[i, j] + " ");
            }

            Console.WriteLine();
        }
    }
    static void Main()
    {
        Console.WriteLine("Введите размер двумерного массива: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int m = Convert.ToInt32(Console.ReadLine());
        int[,] arr = createArray(n, m);
        printArray(arr, n , m);


    }
}