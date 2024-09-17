namespace Practice5
{
	/// <summary>
	/// Класс менеджер.
	/// </summary>
	class Manager : Employee
	{
		#region Поля

		/// <summary>
		/// Размер команды.
		/// </summary>
		private int TeamSize;

		#endregion

		#region Методы

		/// <summary>
		/// Вывод информации о менеджере в консоль.
		/// </summary>
		public override void PrintInfo()
		{
			base.PrintInfo();
			Console.WriteLine($"Команда {TeamSize} человек");
		}

		/// <summary>
		/// Вычисление бонуса для менеджера.
		/// </summary>
		public override void CalculateBonus()
		{
			double bonus = Salary * 0.2;
			if (TeamSize == 0)
			{
				Console.WriteLine($"Бонус менеджера {name} с зарплатой {salary} равен {bonus}");
				return;
			}
			else if (TeamSize > 5)
			{
				bonus += bonus * 0.05;
			}
			Console.WriteLine($"Бонус менеджера {name} с командой из {TeamSize} человек и зарплатой {salary} равен {bonus}");

		}

		#endregion

		#region Конструкторы

		/// <summary>
		/// Конструктор.
		/// </summary>
		/// <param name="name">Имя менеджера.</param>
		/// <param name="salary">Зарпалата менеджера.</param>
		public Manager(string name, double salary)
				: base(name, salary)
		{ }

		/// <summary>
		/// Конструктор.
		/// </summary>
		/// <param name="name">Имя менеджера.</param>
		/// <param name="salary">Зарпалата менеджера.</param>
		/// <param name="teamSize">Размер команды.</param>
		public Manager(string name, double salary, int teamSize)
				: base(name, salary)
		{
			TeamSize = teamSize;
		}

		#endregion
	}
}
