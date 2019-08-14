using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
	class Program
	{
		static void Main(string[] args)
		{
			IMovable petrolMov = new PetrolMove();
			IMovable electricMov = new ElectricMove();
			Car c = new Car(petrolMov);

			c.Move();
			c.Movable = electricMov;
			c.Move();

			Console.ReadLine();
		}
	}
}
