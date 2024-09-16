using Practice5;

class Program
{
	static void Main()
	{
		Employee doctor = new Employee("Alex", 100000);
		Manager tomManager = new Manager("Tom", 130000);

		Console.Write("Введите имя учителя ");
		string name = Console.ReadLine();
		Console.Write("Введите зарплату учителя ");
		double salary = Convert.ToDouble(Console.ReadLine());

		Employee teacher = new Employee(name, salary);

		Manager samManager = new Manager("Sam", 80000, 4);

		Manager kateManager = new Manager("Kate", 80000, 6);

		Contractor bobContractor = new Contractor("Bob", 140000, 500);

		int hourWorked = 100;


		List<Employee> employees = new List<Employee> { doctor, tomManager, teacher, samManager, kateManager, bobContractor };

		foreach (var emp in employees)
		{
			if (emp is Contractor contractor)
			{
				contractor.CalculateBonus(hourWorked);
			}
			else
			{
				emp.CalculateBonus();
			}
		}
	}
}