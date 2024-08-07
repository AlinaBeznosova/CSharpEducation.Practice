/*Создай класс "Студент" с полями "Имя" и "Возраст". Напиши метод, который будет
выводить информацию о студенте в консоль.*/

using System;

namespace Task3_1
{
    class Practice3_1
    {

        static void Main()
        {
            Student Alina = new Student();
            string studentName = Alina.name;
            Alina.name = "Alina";

            int studentAge = Alina.age;
            Alina.age = 27;

            Alina.printInfo();

        }
    }
}