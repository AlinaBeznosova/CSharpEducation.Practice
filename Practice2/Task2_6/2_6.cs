/*Введите с клавиатуры строку произвольной длины и подсчитайте процент
вхождения заданного символа в строку.*/

using System;

class PracticeTask2_6
{
    static void Main(string[] args)
    {
        //строка и символ указываются программно
        var str = "У любого места на земле есть свое время суток, когда оно выглядит неотразимо";
        var symbol = 'е';
        double count = 0;
        int length = str.Length;

        for (int i = 0; i < length; i++)
        {
            if (str[i] == symbol)
            {
                count++;
            }
        }

        double result = count / length * 100;

        Console.WriteLine($"Процент вхождения символа 'е' в строку  { str }  равен : { result.ToString("F2") } %" );


        //строка и символ указываются пользователем в консоли
        Console.WriteLine("Введите произвольную строку:");
        str = Console.ReadLine();
        length = str.Length;
        Console.WriteLine("Введите символ: ");
        ConsoleKeyInfo input = Console.ReadKey();
        symbol = input.KeyChar;
        count = 0;

        for (int i = 0; i < length; i++)
        {
            if (str[i] == symbol)
            {
                count++;
            }
        }

        result = count / length * 100;
        Console.WriteLine();
        Console.WriteLine($"Процент вхождения символа '{symbol}' в строку {str} равен : {result.ToString("F2")} %");

        //строка и символ указываются через аргументы командной строки
        if (args.Length != 2)
        {
            Console.WriteLine("Неправильное количество аргументов. Требуется строка и символ.");
            return;
        }

       string str1 = args[0];
       char symbol1 = Convert.ToChar(args[1]);
       length = args[0].Length;  
       count = 0;

        foreach (char c in str1)
        {
            if (c == symbol1)
            {
                count++;
            }
        }

        result = count / length * 100;



        Console.WriteLine($"Процент вхождения символа '{symbol1}' в строке '{str1}' равен {result:F2}%");

        
    }
}