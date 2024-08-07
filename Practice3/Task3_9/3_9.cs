/*Создай класс "Студент" с полями "Имя" и "Возраст". Напиши метод, который будет
принимать объект класса "Студент" и изменять его имя на "Аноним".*/

using System;
using System.Xml.Linq;
using Task3_9;

class Practice3_9
{
    public static void СhangeNameStudent(Student student)
    {
        student.Name = "Аноним";
    }
    static void Main()
    {
        Student alina = new Student();
        alina.Name = "Алина";
        alina.Age = 27;
        alina.printInfo();

        СhangeNameStudent(alina);
        alina.printInfo();
    }  

}
