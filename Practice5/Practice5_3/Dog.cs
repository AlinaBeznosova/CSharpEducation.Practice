namespace Practice5_3
{
	/// <summary>
	/// Класс собака.
	/// </summary>
	class Dog : Animal
	{
		#region Методы

		/// <summary>
		/// Переопределнный метод какой хвук издает собака.
		/// </summary>
		public override void MakeSound()
		{
			Console.WriteLine("Woof!");
		}

		/// <summary>
		/// Переопределенный метод вывод информации о собаке..
		/// </summary>
		public override void PrintInfo()
		{
			Console.WriteLine($"Name of dog {name} , age {age}");
		}

		#endregion

		#region Конструкторы

		/// <summary>
		/// Базовый конструктор.
		/// </summary>
		/// <param name="name">Имя собаки.</param>
		/// <param name="age">Возраст собаки.</param>
		public Dog(string name, int age) : base(name, age)
		{
			Console.WriteLine("Dog is created");
		}

		#endregion
	}
}
