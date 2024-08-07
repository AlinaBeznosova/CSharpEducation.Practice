/*Создай класс "Книга" с полями "Название" и "Автор". Реализуй два конструктора:
один с параметрами для инициализации полей, другой без параметров, который
будет устанавливать значения по умолчанию.*/

using System;
using Task3_4;

class Practice3_4
{
    static void Main()
    {
        Book book1 = new Book();
        Console.WriteLine("Книга 1 ");
        book1.printInfo();

        Book book2 = new Book("Сияние", "Стивен Кинг");
        Console.WriteLine("Книга 2 ");
        book2.printInfo();
    }
}
