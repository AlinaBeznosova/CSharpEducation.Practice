/*Создайте и реализуйте метод, который принимает на вход массив и
инвертирует его. Вызовите его в методе Main. Исходный массив задайте сами.
Инвертированный массив выведите на экран консоли*/

using System;

class Practice2_15
{
    public static int[] createArray(int n)
    {
        int[] array = new int[n];
        Random rand = new Random();

        for (int i = 0; i < n; i++)
        {
            array[i] = rand.Next(1, 20);
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
    public static int[] invertArray(int [] array)
    {
        int n = array.Length;
        int k = n / 2;
        int temp;

        for(int i = 0; i < k; i++)
        {
            temp = array[i];
            array[i] = array[n - i - 1];
            array[n - i - 1] = temp;
        }
        return array;
    }
    static void Main()
    {
        Console.WriteLine("Введите размер массива:");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = createArray(n);

        Console.WriteLine("Исходный массив: ");
        printArray(arr);

        arr = invertArray(arr);

        Console.WriteLine("Инвертированный массив: ");
        printArray(arr);
    }
}