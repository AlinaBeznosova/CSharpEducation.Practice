using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_1
{
    internal class Student
    {
        public string name;
        public int age;

        public void printInfo()
        {
            Console.WriteLine($"Имя : {name} Возраст {age}");
        }
    }
}
