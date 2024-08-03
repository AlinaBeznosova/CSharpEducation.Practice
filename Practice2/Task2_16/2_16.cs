/*Создайте и реализуйте метод, который будет принимать число по ссылке (ref) и
менять его знак на противоположный. Метод должен принимать один аргумент и
не возвращать ничего.*/

using System;
class Practice2_16
{
    public static void changeSign (ref int n)
    {
        n = -n;
    }

    static void Main()
    {
        Console.WriteLine("Введите число:");
        int n = Convert.ToInt32(Console.ReadLine());

        changeSign(ref n);
        Console.WriteLine($"Новое число : {n}");
    }
}