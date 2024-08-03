﻿/*Напишите игру Угадай число. Программа случайно генерирует число от 1 до
100, а пользователь пытается угадать это число. При успешной догадке
выводите поздравление пользователя. Также покажите количество попыток,
принятых пользователем.
a. Сделайте ограничение по попыткам. Например, если попыток больше 10,
то пользователь проиграл
b. Сделайте подсказки для пользователя. Если предположенное число
больше загаданного, то писать в консоль об этом. Аналогично и для
меньшего числа.*/

using System;
class Practice2_21
{
    static void Main()
    {
        Random rand = new Random();
        int mysteryNum = rand.Next(1, 100);
        int count = 0;

        Console.WriteLine("Компьютер загадал число от 1 до 100. У вас есть 10 попыток, чтобы его угадать");

        while (true)
        {
            Console.Write("Введите число: ");
            int input = Convert.ToInt32(Console.ReadLine());
            count++;
            if (input == mysteryNum)
            {
                Console.WriteLine("Поздравляем! Вы угадали!");
                break;
            }

            else if (count == 11)
            {
                Console.WriteLine("У вас закончились попытки. Вы проиграли :(");
            }
            else if (input < mysteryNum)
            {
                Console.WriteLine("Загаланное число больше. Попробуйте еще раз");
            }
            else
            {
                Console.WriteLine("Загаданное число меньше. Попробуйте еще раз");
            }
             
        }
        Console.WriteLine($"Вы угадали число с {count} попыток");
    }
}