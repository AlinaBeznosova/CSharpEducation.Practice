namespace Practice5
{
	/// <summary>
	/// Класс сотрудник.
	/// </summary>
	class Employee
	{
		#region Поля и свойства.

		/// <summary>
		/// Имя сотрудника.
		/// </summary>
		public string name;

		/// <summary>
		/// Зарплата сотрудника.
		/// </summary>
		public double salary;

		/// <summary>
		/// Свойство.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Свойство.
		/// </summary>
		public double Salary
		{
			get
			{
				return salary;
			}

			set
			{
				if (salary < 0)
					Console.WriteLine("Error");
				else
					salary = value;
			}
		}

		#endregion

		#region Методы.

		/// <summary>
		/// Вывод информации о сотруднике в консоль.
		/// </summary>
		public virtual void PrintInfo()
		{
			Console.WriteLine($"Имя: {name} Зарпалата: {salary}");
		}

		/// <summary>
		/// Вычисления бонуса.
		/// </summary>
		public virtual void CalculateBonus()
		{
			Console.WriteLine($"Бонус сотрудника {name} с зарплатой {salary} равен {salary * 0.1}");
		}

		#endregion

		#region Конструкторы.

		/// <summary>
		/// Конструктор.
		/// </summary>
		/// <param name="name">Имя сотрудника.</param>
		public Employee(string name)
		{
			this.name = name;
		}

		/// <summary>
		/// Конструктор.
		/// </summary>
		/// <param name="name">Имя сотрудника.</param>
		/// <param name="salary">Зарпалата сотрудника.</param>
		public Employee(string name, double salary) : this(name)
		{
			this.salary = salary;
		}

		#endregion
	}
}
