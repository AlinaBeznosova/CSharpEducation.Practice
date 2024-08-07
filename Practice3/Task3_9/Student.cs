using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_9
{
    class Student
    {
        public string name;
        public int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if ((this.age < 0) || (this.age > 120))
                    Console.WriteLine("Некорректный ввод возраста");
                else
                    this.age = value;
            }
        }
        public void printInfo()
        {
            Console.WriteLine($"Имя: {name}  Возраст: {age}");
        }

        
    }
}

