namespace Practice5_3
{
	/// <summary>
	/// Класс попугай.
	/// </summary>
	class Parrot : Animal , IFlyable
	{
		#region Поля и свойства

		/// <summary>
		/// Цвет попугая.
		/// </summary>
		public string color;

		/// <summary>
		/// Свойство.
		/// </summary>
		public string Color { get; set; }

		#endregion

		#region Методы

		/// <summary>
		/// Переопределенный метод какой звук издает попугай.
		/// </summary>
		public new void MakeSound()
		{
			Console.WriteLine("Parrot is talking");
		}

		/// <summary>
		/// Перегруженный метод что говорит попугай.
		/// </summary>
		/// <param name="words">Что говорит попугай.</param>
		public void MakeSound(string words)
		{
			Console.WriteLine($"Попугай говорит: {words}");
		}

		/// <summary>
		/// Переопределенный метод вывод информации о попугае.
		/// </summary>
		public override void PrintInfo()
		{
			Console.WriteLine($"Name of parrot {name} , age {age} , color {color}");
		}

		/// <summary>
		/// Попугай летает.
		/// </summary>
		public void Fly()
		{
			Console.WriteLine("Parrot is flying");
		}
		#endregion

		#region Конструкоры

		/// <summary>
		/// Конструктор.
		/// </summary>
		/// <param name="name">Имя попугая.</param>
		/// <param name="age">Возраст попугая.</param>
		/// <param name="color">Цвет попугая.</param>
		public Parrot(string name, int age, string color) : base(name, age)
		{
			this.color = color;
		}

		#endregion
	}
}
