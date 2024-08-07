/*Создай структуру "Точка" с полями "X" и "Y" типа int. Напиши метод, который будет
принимать две точки и возвращать расстояние между ними.*/

using System;
using System.Drawing;
using System.Runtime.InteropServices;

class Practice3_6
{
    public struct Point
    {
 
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    public static double distance(Point point1, Point point2)
    {
        double distX = point2.X - point1.X;
        double distY = point2.Y - point1.Y;
        return Math.Sqrt(distX * distX + distY * distY);    
    }

    static void Main()
    {
        Point point1 = new Point(5, 6);
        Point point2 = new Point(13, 7);

        Console.WriteLine($"Расстояние между точками равно {distance(point1, point2):F2}");


    }
}
