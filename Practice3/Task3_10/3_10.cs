/*Создай класс "Автомобиль" с полем "Марка". Напиши метод, который будет
принимать объект класса "Автомобиль" и выводить информацию о марке
автомобиля в консоль.*/

using System;
using Task3_10;
class Practice3_10
{
    public static void printModel(Auto car)
    {
        Console.WriteLine($"Марка автомобиля {car.model}");
    }
    static void Main()
    {
        Auto car = new Auto("BMW");
        printModel(car);
    }
}