/*Создай перечисление "Месяцы" с элементами, представляющими названия
месяцев года. Напиши метод, который будет принимать месяц и возвращать
количество дней в этом месяце*/

using System;
using System.Security.Cryptography.X509Certificates;

class Practice3_7
{
    public enum Months
    {
        Январь = 1,
        Февраль ,
        Март ,
        Апрель ,
        Май ,
        Июнь ,
        Июль ,
        Август ,
        Сентябрь ,
        Октябрь ,
        Ноябрь ,
        Декабрь 
    }
    public static int GetDaysInMonth(Months month, int year)
    {
        
        return DateTime.DaysInMonth(year, (int)month);
    }


    static void Main()
    {
        Months month = 0;
        Console.WriteLine("Введите год: ");
        int year = Convert.ToInt32(Console.ReadLine());

         Console.WriteLine("Введите число от 1 до 12, соответствующее месяцу: ");
        int input = Convert.ToInt32(Console.ReadLine());

        if (input < 1 && input > 12)
        {
            Console.WriteLine("Некорректный ввод. Введите число от 1 до 12");
            
        }
        else
        {
            month = (Months)input;
            
        }


        int daysInMonth = GetDaysInMonth(month, year);
        Console.WriteLine($"Количество дней в {month}'{year} : {daysInMonth}");

    }
}