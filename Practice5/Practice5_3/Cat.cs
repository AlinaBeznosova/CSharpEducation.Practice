namespace Practice5_3
{
	/// <summary>
	/// Класс кот.
	/// </summary>
	class Cat : Animal
	{
		#region Методы

		/// <summary>
		/// Переопределенный метод какой звук издает кот.
		/// </summary>
		public override void MakeSound()
		{
			Console.WriteLine("Meow!");
		}

		/// <summary>
		/// Переопределенный метод вывод информации о коте.
		/// </summary>
		public override void PrintInfo()
		{
			Console.WriteLine($"Name of cat {name} , age {age}");
		}

		#endregion

		#region Конструкторы

		/// <summary>
		/// Конструктор базового класса.
		/// </summary>
		/// <param name="name">Имя кота.</param>
		/// <param name="age">Возраст кота.</param>
		public Cat(string name, int age) : base(name, age)
		{
			Console.WriteLine("Cat is created");
		}

		#endregion
	}
}
