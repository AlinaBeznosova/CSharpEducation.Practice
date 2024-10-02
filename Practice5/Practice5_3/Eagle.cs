using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5_3
{
	/// <summary>
	/// Класс орел.
	/// </summary>
	public class Eagle : IFlyable
	{

		/// <summary>
		/// Орел парит высоко.
		/// </summary>
		public void Fly()
		{
			Console.WriteLine("Eagle is soaring high");
		}

	}
}
