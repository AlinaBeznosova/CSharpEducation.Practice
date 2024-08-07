using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_11
{
    class Book
    {
        public string nameBook;
        public string nameAuthor;

        public Book() : this("Неизвестно")
        { }

        public Book(string nameBook) : this(nameBook, "Неизвестный")
        { }

        public Book(string nameBook, string nameAuthor)
        {
            this.nameBook = nameBook;
            this.nameAuthor = nameAuthor;

        }

    }
}
