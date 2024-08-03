/*Создайте одномерный массив целых чисел произвольной длины и заполните
случайными числами от 1 до 100. Выведите на экран разницу максимального и
минимального значений в нём*/

using System;
class Practice2_19
{
    public static int[] createArray(int n)
    {
        int[] array = new int[n];
        Random rand = new Random();

        for (int i = 0; i < n; i++)
        {
            array[i] = rand.Next(1, 100);
        }
        return array;
    }

    public static void printArray(int[] array)
    {

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
    }
    static void Main()
    {
        int n = 15;
        int[] array = createArray(n);
        Console.WriteLine("Массив из рандомных чисел от 1 до 100: ");
        printArray(array);

        int min = array.Min();
        int max = array.Max();
        int difference = max - min;

        Console.WriteLine($"Максимальное число в массиве равно {max} , минимальное число в массиве равно {min} , их разница равна {difference} ");

    }
}