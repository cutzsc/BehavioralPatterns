using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
	class PetrolMove : IMovable
	{
		public void Move()
		{
			Console.WriteLine("Переменещие на бензине");
		}
	}
}
