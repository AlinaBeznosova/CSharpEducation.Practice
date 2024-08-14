namespace MyLibPerson
{
    public class Person
    {
        string? name;
        int age;
        public string? Name
        {
            get => this.name;
            set
            {
                if (value == null)
                    Console.WriteLine($"Не корректный ввод. Не бывает людей без имени.");
                else this.name = value;
            }
        }
        

        public int Age
        {
            get => this.age;

            set
            {
                if (value < 0 || value > 120)
                    Console.WriteLine($"Некорректный возраст. ");
                else this.age = value;
            }
        }
        
        
        public void PrintInfo() => Console.WriteLine($"Имя: {name} , Возраст: {age}");
    }
}
