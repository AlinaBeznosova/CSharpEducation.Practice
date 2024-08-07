/*Cоздай структуру "Прямоугольник" с полями "Ширина" и "Высота" типа double.
Напиши метод, который будет вычислять площадь прямоугольника*/

using System;
using System.Runtime.InteropServices;

class Practice3_8
{
    struct Rectangle
    {
        public double width;
        public double height;

        public double Square ()
        {
           return width * height;
        }
    }
    static void Main()
    {
        Rectangle rect = new Rectangle();

        Console.WriteLine("Введите ширину прямоугольника");
        rect.width = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите длину прямоугольника");
        rect.height = Convert.ToDouble(Console.ReadLine());

        double s = rect.Square();

        Console.WriteLine($"Площадь прямоугольника с шириной {rect.width} и длиной {rect.height} равна: {s} ");
    }
}