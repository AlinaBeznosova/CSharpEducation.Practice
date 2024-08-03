/*Создайте перечисление(enum) для дней недели. Напишите программу, которая
выводит на экран дни недели по названиям*/

using System;
class Practice2_24
{
    public enum WeekDays
    {
        Monday,
        Tuesday,
        Wensday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    static void Main()
    {
        foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
        {
            Console.WriteLine(day);
        }
    }
}