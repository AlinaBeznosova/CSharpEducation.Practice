using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task3_4
{
    class Book
    {
        private string nameBook;
        private string nameAuthor;

        public Book() : this ("Неизвестно","Неизвестный")
        { }
        public Book(string nameBook, string nameAuthor)
        {
            this.nameBook = nameBook;
            this.nameAuthor = nameAuthor;

        }
        public void printInfo()
        {
            Console.WriteLine($"Название : {nameBook} ");
            Console.WriteLine($"Автор :{nameAuthor}");
        }
    }
}
