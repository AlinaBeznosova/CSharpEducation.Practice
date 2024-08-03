/*Напишите программу, в которой создаётся массив и выводится на экран
консоли. Размер массива передавайте в качестве первого аргумента командной
строки. Число, которым будет заполняться массив передайте через второй
аргумент командной строки*/

using System;

class Practice2_11
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(args[0]);
        int[] array = new int[n];
        int value = Convert.ToInt32(args[1]);

        for (int i = 0; i < n; i++)
        {
            array[i] = value;
            Console.Write(array[i] + " ");
        }

        Console.ReadLine();
    }
}