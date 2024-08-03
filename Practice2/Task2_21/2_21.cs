/*Напишите игру Угадай число. Программа случайно генерирует число от 1 до
100, а пользователь пытается угадать это число. При успешной догадке
выводите поздравление пользователя.*/

using System;
class Practice2_21
{
    static void Main()
    {
        Random rand = new Random();
        int mysteryNum = rand.Next(1,100);

        Console.WriteLine("Компьютер загадал число от 1 до 100, а вам нужно его угадать");

        while(true)
        {
            Console.Write("Введите число: ");
            int input = Convert.ToInt32(Console.ReadLine());

            if(input == mysteryNum)
            {
                Console.WriteLine("Поздравляем! Вы угадали!");
                break;
            }
            

            else
            {
                Console.WriteLine("Упс! Неверно. Попробуйте еще раз");
            }
        }
    }
}