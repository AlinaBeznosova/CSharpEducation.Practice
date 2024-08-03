/*Создайте и реализуйте метод, который принимает на вход размер массива n и
возвращает пустой массив указанного размера. Вызовите метод в методе Main
и заполните его полученный массив. Содержимое массива выведите на экран.*/

using System;

class Practice2_14
{
    public static int[] createEmptyArray(int n)
    {
        int[] array = new int[n];
        
        for(int i = 0; i < n; i++)
        {
             array[i] = 0;
        }

        return array;
    }
    static void Main()
    {
        Console.WriteLine("Введите размер массива: ");
        int n = Convert.ToInt32 (Console.ReadLine());
        int[] arr = createEmptyArray(n);

        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }

        Console.WriteLine();

        Random rand = new Random();

        for (int i = 0; i < n; i++)
        {
            arr[i] = rand.Next(1,10);
            Console.Write(arr[i] + " ");
        }

    }
}