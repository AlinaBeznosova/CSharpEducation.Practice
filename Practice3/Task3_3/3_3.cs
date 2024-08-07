/*Создай класс "Калькулятор" с методами для выполнения основных арифметических
операций (сложение, вычитание, умножение, деление). Пусть эти методы
принимают два числа и возвращают результат операции.*/

using System;

namespace Task3_3
{
    class Practice3_3
    {
        static void Main()
        {
            Console.WriteLine($"5 + 7 = {Calculator.Add(5, 7)}");
            Console.WriteLine($"10 - 3 = {Calculator.Subtract(10, 3)}");
            Console.WriteLine($"8 * 4 = {Calculator.Multiply(8, 4)}");
            Console.WriteLine($"27 / 9 = {Calculator.Devide(27, 9)}");
        }
    }
}