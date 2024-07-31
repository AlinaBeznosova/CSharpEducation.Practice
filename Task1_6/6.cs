using System;

class PracticeTask6
{
    static void Main(string[] args)
    {
        double cathetus1 = 3;
        double cathetus2 = 4;
        double hypotenuse = Math.Sqrt(Math.Pow(cathetus1, 2) + Math.Pow(cathetus2, 2));

        Console.WriteLine("Гипотенуза треугольника с катетами 3 и 4 равна " + hypotenuse);

        cathetus1 = 6;
        hypotenuse = 10;
        cathetus2 = Math.Sqrt(Math.Pow(hypotenuse, 2) - Math.Pow(cathetus1, 2));

        Console.WriteLine("Катет треугольника с гипотенузой 10 и другим катетом 6 равен " + cathetus2);

    }
}