namespace Practice5_3
{
	/// <summary>
	/// Класс животное.
	/// </summary>
	class Animal
	{
		#region Поля и свойства

		/// <summary>
		/// Имя животного.
		/// </summary>
		public string name;

		/// <summary>
		/// Возраст животного.
		/// </summary>
		public int age;

		/// <summary>
		/// Свойство.
		/// </summary>
		public int Age { get; set; }

		/// <summary>
		/// Свойство.
		/// </summary>
		public string Name { get; set; }

		#endregion

		#region Методы

		/// <summary>
		/// Животное ест.
		/// </summary>
		public void Eat()
		{
			Console.WriteLine("Animal is eating");
		}

		/// <summary>
		/// Животное спит.
		/// </summary>
		public void Sleep()
		{
			Console.WriteLine("Animal is sleeping");
		}

		/// <summary>
		/// Вывод информации о животном.
		/// </summary>
		public virtual void PrintInfo()
		{
			Console.WriteLine($"Name {name} , age {age}");
		}

		/// <summary>
		/// Какой звук издает животное.
		/// </summary>
		public virtual void MakeSound()
		{
			Console.WriteLine("Some generic animal sound");
		}
		#endregion

		#region Конструкторы

		/// <summary>
		/// Конструктор.
		/// </summary>
		/// <param name="name">Имя животного.</param>
		/// <param name="age">Возраст животного.</param>
		public Animal(string name, int age)
		{
			this.name = name;
			this.age = age;
		}

		#endregion
	}
}
