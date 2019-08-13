using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
	class Program
	{
		static void Main(string[] args)
		{
			Inventory inv = new Inventory(5);

			IItemIterator iterator = inv.CreateNumerator();
			while (iterator.HasNext())
			{
				Item item = iterator.Next();
				Console.WriteLine(item.name);
			}

			Console.ReadLine();
		}
	}
}
