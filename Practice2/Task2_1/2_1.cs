using System;

class PracticeTask2_1
{
    static void Main()
    {
        //цикл for, выводящий в консоль значение своего же счётчика

        int i;
        Console.WriteLine("Цикл for:");
        for (i = 0; i < 5; i++)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine();

        //цикл while, выводящий в консоль значение своего же счётчика

        Console.WriteLine("Цикл while:");
        i = 0;
        while (i < 5)
        {
            Console.Write(i + " ");
            i++;
        }

        Console.WriteLine();

        //цикл do while, выводящий в консоль значение своего же счётчика

        i = 0;
        Console.WriteLine("Цикл do while:");
        do
        {
            Console.Write(i + " ");
            i++;
        }
        while (i < 5);

        Console.WriteLine();

        /*цикл for, в котором у пользователя запрашиваются слова, затем
        выводится полная фраза, слова в которой разделены пробелами.*/

        Console.WriteLine("Соберем фразу из 4х слов");

        int n = 4; 
        string?[] words = new string[n];

        for (i = 0; i < n; i++)
        {
            Console.Write($"Введите слово {i + 1}: ");
            words[i] = Console.ReadLine();
        }

        string phrase = string.Join(" ", words);
        Console.WriteLine($"Полная фраза: {phrase}");

        /*цикл while, в котором у пользователя запрашиваются слова, затем
        выводится полная фраза, слова в которой разделены пробелами.*/

        Console.WriteLine("Соберем фразу из 4х слов");
        i = 0;
        n = 4;
        words = new string[n];

        while (i < n )
        {
            Console.Write($"Введите слово {i + 1}: ");
            words[i] = Console.ReadLine();
            i++;
        }

        phrase = string.Join(" ", words);
        Console.WriteLine($"Полная фраза: {phrase}");


        /*цикл do while, в котором у пользователя запрашиваются слова, затем
        выводится полная фраза, слова в которой разделены пробелами.*/

        Console.WriteLine("Соберем фразу из 3х слов");
        i = 0;
        n = 3;
        words = new string[n];

        do
        {
            Console.Write($"Введите слово {i + 1}: ");
            words[i] = Console.ReadLine();
            i++;
        }
        while (i < n);

        phrase = string.Join(" ", words);
        Console.WriteLine($"Полная фраза: {phrase}");

    }
}