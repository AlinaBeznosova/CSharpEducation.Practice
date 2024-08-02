using System;

class PracticeTask2_2
{
    static void Main()
    {
        Console.Write("Введите число в метрах "); //метры в километры
        string? userInput = Console.ReadLine();
        double meters = Convert.ToDouble(userInput);
        double kilometers = meters / 1000;
        Console.WriteLine($"{meters} м равно {kilometers} км");


        Console.Write("Введите число в километрах "); //километры в сантиметры
        userInput = Console.ReadLine();
        kilometers = Convert.ToDouble(userInput);
        double santemeters = kilometers * 100000;
        Console.WriteLine($"{kilometers} км равно {santemeters} см");


        Console.Write("Введите скорость в м/с "); //м/с в км/ч
        userInput = Console.ReadLine();
        double speed_m = Convert.ToDouble(userInput);
        double speed_km = speed_m * 3.6;
        Console.WriteLine($"{speed_m} м/с равно {speed_km} км/ч");

        Console.Write("Введите температуру в С "); //градусы C в градусы F
        userInput = Console.ReadLine();
        double temperatureC = Convert.ToDouble(userInput);
        double temperatureF = ( temperatureC * 1.8) + 32;
        Console.WriteLine($"{temperatureC} градусов по Цельсию эквивалентно {temperatureF} градусам по Фаренгейту");
    }
}
       