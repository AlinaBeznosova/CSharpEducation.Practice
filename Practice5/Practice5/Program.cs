using Practice5;
using ClassLibrary;

class Program
{
	static void Main()
	{
		var consoleLogger = new ConsoleLogger("Program");
		var fileLogger = new FileLogger("Program");

		Employee doctor = new Employee("Alex", 100000);
		consoleLogger.Info("Создан объект Employee");
		fileLogger.Info("Создан объект Employee");

		Manager tomManager = new Manager("Tom", 130000);
		consoleLogger.Info("Создан объект Manager");
		fileLogger.Info("Создан объект Manager");

		Manager samManager = new Manager("Sam", 80000, 4);
		consoleLogger.Info("Создан объект Manager");
		fileLogger.Info("Создан объект Manager");

		Manager kateManager = new Manager("Kate", 80000, 6);
		consoleLogger.Info("Создан объект Manager");
		fileLogger.Info("Создан объект Manager");

		Contractor bobContractor = new Contractor("Bob", 140000, 500);
		consoleLogger.Info("Создан объект Contractor");
		fileLogger.Info("Создан объект Contractor");

		int hourWorked = 100;


		List<Employee> employees = new List<Employee> { doctor, tomManager, samManager, kateManager, bobContractor };

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