/*Создайте и реализуйте метод, который будет принимать массив на вход убирать
из него отрицательные числа и возвращать новый изменённый массив. Через
out параметр возвращать количество удалённых символов.*/

using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
class Practice2_17
{
    public static int[] createArray(int n)
    {
        int[] array = new int[n];
        Random rand = new Random();

        for (int i = 0; i < n; i++)
        {
            array[i] = rand.Next(-20, 20);
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

    public static int[] deleteNegative(int[] array, out int count)
    {
        count = 0;
        List<int> positiveValue = new List<int>();

        for (int i = 0; i < array.Length;i++)
        {
            if (array[i] >= 0)
            {
                positiveValue.Add(array[i]);
            }
            else
            {
                count++;
            }
        }
 
        return positiveValue.ToArray();
    }
    static void Main()
    {
        Console.WriteLine("Введите размер массива:");
        int n = Convert.ToInt32(Console.ReadLine());
        int count;
        int[] arr = new int[n];
        arr = createArray(n);
        Console.WriteLine("Исходный массив:");
        printArray(arr);

        arr = deleteNegative(arr, out count);
        Console.WriteLine($"Новый массив без отрицательных чисел:");
        printArray(arr);
        Console.WriteLine($"Количество отрицательных чисел равно {count}");
       
    }
}