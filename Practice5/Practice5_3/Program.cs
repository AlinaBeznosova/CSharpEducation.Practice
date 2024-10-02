
using Practice5_3;
class Program
{
	static void Main()
	{
		Animal bear = new Animal("Misha", 3);
		Cat cat = new Cat("Markus", 4);
		Dog dog = new Dog("Bobik", 4);
		Parrot parrot = new Parrot("Kesha", 2, "Yellow");
		Eagle eagle = new Eagle();


		List<Animal> animals = new List<Animal> { cat, dog, parrot };

		foreach (var animal in animals)
		{
			if (animal is Parrot popugai)
			{
				popugai.PrintInfo();
				Console.WriteLine("Скажите фразу для попугая: ");
				string words = Console.ReadLine();
				popugai.MakeSound(words);
			}
			else
			{
				animal.PrintInfo();
				animal.MakeSound();
			}
		}

		IFlyable[] flyables = new IFlyable[2] { parrot, eagle };
		
		foreach (var fliable in  flyables)
		{
			fliable.Fly();
		}

	}
}