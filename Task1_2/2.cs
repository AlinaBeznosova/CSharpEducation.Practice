using System;

class PracticeTask2
{
    static void Main(string[] args)
    {
        int age = 27;
        string name = "Алина";
        float temperature = 20;
        bool isFemale = true;

        Console.WriteLine("Возраст: " + age);
        Console.WriteLine("Имя: " + name);
        Console.WriteLine("Температура за окном: " + temperature + " градусов");

        if (isFemale == true)
            Console.WriteLine("Пол: женский ");
        else
            Console.WriteLine("Пол: мужской ");
    }
}
