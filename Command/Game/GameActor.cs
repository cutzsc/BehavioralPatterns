using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Game
{
	class GameActor
	{
		public void Jump()
		{
			Console.WriteLine("Actor jumped");
		}

		public void Fire()
		{
			Console.WriteLine("Actor shooting");
		}

		public void SwapWeapon()
		{
			Console.WriteLine("Actor swapped weapon");
		}

		public void Lurch()
		{
			Console.WriteLine("Actor lurching");
		}
	}
}
