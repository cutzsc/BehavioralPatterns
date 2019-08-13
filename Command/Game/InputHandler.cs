using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Game
{
	class InputHandler
	{
		public Command buttonX;
		Command buttonY;
		Command buttonA;
		Command buttonB;



		public Command HandleInput()
		{
			if (Console.ReadLine() == "x")
				return buttonX;
			if (Console.ReadLine() == "y")
				return buttonY;
			if (Console.ReadLine() == "a")
				return buttonA;
			if (Console.ReadLine() == "b")
				return buttonB;

			return null;
		}
	}
}
