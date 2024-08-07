using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task3_5
{
    class Book
    {
        private string nameBook;
        private string nameAuthor;
        private int yearOfPublishing = 0;

        public Book() : this("Неизвестная книга")
        { }

        public Book(string nameBook) :this(nameBook,"Неизвестный")
        { }

        public Book(string nameBook, string nameAuthor) :this (nameBook, nameAuthor, 0)
        { }

        public Book(string nameBook, string nameAuthor, int year)
        {
            this.nameBook = nameBook;
            this.nameAuthor = nameAuthor;
            this.yearOfPublishing = year; 

        }
        public void printInfo()
        {
            Console.WriteLine($"Название : {nameBook} ");
            Console.WriteLine($"Автор :{nameAuthor}");
            if (yearOfPublishing == 0)
                Console.WriteLine("Год издания неизвестен");
           else
            Console.WriteLine($"Год издания :{yearOfPublishing}");
        }
    }
}
