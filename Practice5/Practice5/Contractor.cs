namespace Practice5
{
	/// <summary>
	/// Класс подрядчик.
	/// </summary>
	class Contractor : Employee
	{
		#region

		/// <summary>
		/// Почасовая ставка.
		/// </summary>
		private int HourlyRate;

		#endregion

		#region Методы.

		/// <summary>
		/// Вывод информации о подрядчике на консоль.
		/// </summary>
		public override void PrintInfo()
		{
			base.PrintInfo();
			Console.WriteLine($"Почасовая ставка {HourlyRate}");
			;
		}

		/// <summary>
		/// Вычисление бонуса.
		/// </summary>
		/// <param name="hoursWorked">Количество отработанных часов.</param>
		public void CalculateBonus(int hoursWorked)
		{
			Console.WriteLine($"Бонус подрядчика {name} с зарплатой {salary} за {hoursWorked} часов равен {HourlyRate * hoursWorked * 0.1}");
		}

		#endregion

		#region Конструктор.

		/// <summary>
		/// Конструктор.
		/// </summary>
		/// <param name="name">Имя подрядчика.</param>
		/// <param name="salary">Зарпалата подрядчика.</param>
		/// <param name="hourlyrate">Почасовая ставка.</param>
		public Contractor(string name, double salary, int hourlyrate)
				: base(name, salary)
		{
			HourlyRate = hourlyrate;
		}

		#endregion
	}
}
