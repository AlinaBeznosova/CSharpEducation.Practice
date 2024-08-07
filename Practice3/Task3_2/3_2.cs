/*Создай класс "Студент" с полями "Имя" и "Возраст". Напиши метод, который будет
выводить информацию о студенте в консоль. Добавь в класс "Студент" свойство
"Средний балл". Реализуй геттер и сеттер для этого свойства. Добавь проверку в
сеттер, чтобы значение среднего балла было в диапазоне от 0 до 5.*/

using System;
using Task3_2;

namespace Task3_2
{
    class Practice3_1
    {

        static void Main()
        {
            Student Alina = new Student();
            int studentAge = 27;
            string studentName = "Alina";
            double mark = 4.7;

            Alina.Name = studentName;
            Alina.Age = studentAge;
            Alina.Average = mark;

            Alina.printInfo();

        }
    }
}