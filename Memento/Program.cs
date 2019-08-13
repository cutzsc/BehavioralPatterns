using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
	class Program
	{
		static void Main(string[] args)
		{
			GameHistory hist = new GameHistory();

			LevelOne(hist);
			LevelTwo(hist);
			LevelThree(hist);

			Console.ReadLine();
		}

		static void LevelOne(GameHistory hist)
		{
			Console.WriteLine("Level one");
			Inventory inv = new Inventory(5);
			for (int i = 0; i < 5; i++)
			{
				inv.Add(new Item($"Item #: {i}"));
			}
			inv.Print();

			hist.InventoryMemento = inv.SaveState();
		}

		static void LevelTwo(GameHistory hist)
		{
			Console.WriteLine("Level two");

			Inventory inv = new Inventory(5);
			inv.RestoreState(hist.InventoryMemento);

			inv.RemoveAt(4);
			inv.RemoveAt(2);
			inv.Print();

			hist.InventoryMemento = inv.SaveState();
		}

		static void LevelThree(GameHistory hist)
		{
			Console.WriteLine("Level three");

			Inventory inv = new Inventory(5);
			inv.RestoreState(hist.InventoryMemento);
			inv.Print();
		}
	}
}
