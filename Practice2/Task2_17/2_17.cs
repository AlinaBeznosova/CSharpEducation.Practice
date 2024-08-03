/*Создайте и реализуйте метод, который будет принимать два числа и менять их
значения местами. Вызовите метод в Main*/

using System;
class Practice2_17
{
    public static void swapValue(ref int number1,ref int number2)
    {
        int temp = number1;
        number1 = number2;
        number2 = temp;       
    }
    static void Main()
    {
        Console.WriteLine("Введите первое число");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите второе число");
        int number2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"До обмена первое число равно {number1} , второе число равно {number2}");
        swapValue(ref number1,ref number2);

        Console.WriteLine($"После обмена первое число равно {number1} , второе число равно {number2}");

    }
}