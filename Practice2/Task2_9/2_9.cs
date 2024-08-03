/*Напишите метод, который создаёт массив целых чисел и возвращает его.
Размер массива нужно передавать в качестве аргумента. Вдобавок напишите
метод, который выводит переданный массив на экран консоли.*/

using System;

class PracticeTask2_9
{
     public static int[] createArray(int n)
    {
        int[] array = new int[n];
        Random rand = new Random();
        
        for(int i = 0; i < n; i++) 
        {
           array[i] = rand.Next(1,20);
        }
        return array;
        
    }

    public static void printArray(int[] array)
    {
        
       for (int i = 0; i< array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
       Console.WriteLine();
    }
    static void Main()
    {
        Console.WriteLine("Введите размер массива:");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];
        arr = createArray(n);
        printArray(arr);
        

    }
}
