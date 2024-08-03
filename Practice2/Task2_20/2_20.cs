/*Создайте двумерный массив целых чисел произвольной длины и заполните
случайными числами от 1 до 100. Выведите на экран разницу максимального и
минимального значений в каждой строке массива*/

using System;
class Practice2_20
{
    public static int[,] createArray(int n, int m)
    {
        int[,] array = new int[n, m];
        Random rand = new Random();

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
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
        int n = 4;
        int m = 4;
        int[,] arr = createArray(n, m);
        Console.WriteLine("Двумерный массив из рандомных чисел от 1 до 100: ");
        printArray(arr, n ,m);

        
        for (int i = 0; i < n; i++)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            for (int j = 0; j < m; j++)
            {
               if (arr[i,j] < min)
                {
                    min = arr[i, j];
                }
               if (arr[i,j]> max)
                {
                    max = arr[i, j];
                }
            }
            int difference = max - min;
            Console.WriteLine($"Максимальное число в {i+1}-ой строке равно {max} , минимальное число в {i+1}-ой строке равно {min} , их разница равна {difference} ");
        } 
    }
}