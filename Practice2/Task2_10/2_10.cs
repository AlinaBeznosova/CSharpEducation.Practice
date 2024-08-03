/*Напишите программу, в которой создаётся массив и выводится на экран
консоли. Размер массива передавайте в качестве первого аргумента командной
строки.*/

using System;

class Practice2_10
{
   static void Main(string[] args)
    {
        int n = Convert.ToInt32(args[0]);
        int[] array = new int[n];  
        Random rnd = new Random(); 

        for(int i=0; i < n; i++)
        {
            array[i] = rnd.Next(1,100);
            Console.Write(array[i] + " ");
        }
        Console.ReadLine();
    }
}