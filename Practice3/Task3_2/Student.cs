using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_2
{
    class Student
    {
        private string name;
        private int age;
        private double average;


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
            Console.WriteLine($"Имя : {name}");
            Console.WriteLine($"Возраст : {age}");
            Console.WriteLine($"Средний балл : {average}");
        }

        public double Average
        {
            get { return this.average; }

            set
            {
                if (this.average < 0 || this.average > 5)
                    Console.WriteLine("Средний балл должен быть в диапазоне от 0 до 5");
                else { this.average = value; }
            }

        }

    }
}