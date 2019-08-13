using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Game;

namespace Command
{
	class Program
	{
		static void Main(string[] args)
		{
			GameActor player = new GameActor();

			InputHandler inputHandler = new InputHandler();
			FireCommand fc = new FireCommand();
			inputHandler.buttonX = fc;

			Game.Command c = inputHandler.HandleInput();
			c?.Execute(player);

			Console.ReadLine();
		}
	}
}
