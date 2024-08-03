//Напишите программу, которая переводит строку в разные регистры

using System;

class PracticeTask2_7
{
    static void Main(string[] args)
    {
       // a.в верхний регистр: f->F
        Console.WriteLine($"Введите строку 1: ");
        string? str = Console.ReadLine();
        string upperStr = str.ToUpper();
        Console.WriteLine($"Строка в верхнем регистре: {upperStr}");

        //b.в нижний регистр: F->f
        Console.WriteLine($"Введите строку 2: ");
        str = Console.ReadLine();
        string downStr = str.ToLower();
        Console.WriteLine($"Строка в нижнем регистре: {downStr}");

        //c. делает заглавную букву в слове: привет -> Привет
        Console.WriteLine($"Введите строку 3: ");
        str = Console.ReadLine();
        string firstLetter = str.Substring(0, 1).ToUpper() + str.Substring(1).ToLower();
        Console.WriteLine($"Строка с заглавной буквы: {firstLetter}");

    }
}