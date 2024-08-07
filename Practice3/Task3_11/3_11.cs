/*Создай класс "Книга" с полями "Название" и "Автор". Напиши метод, который будет
принимать объект класса "Книга" и возвращать информацию о книге в виде строки.*/

using System;
using Task3_11;

class Practice3_11
{
    public static void printInfo(Book book)
    {
        Console.WriteLine($"Название книги: {book.nameBook} Автор: {book.nameAuthor} ");
    }
    static void Main()
    {
        Book book1 = new Book();
        Book book2 = new Book("Сияние");
        Book book3 = new Book("Куджо", "Стивен Кинг");

        printInfo(book1);
        printInfo(book2);
        printInfo(book3);   

    }
}