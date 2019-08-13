using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
	class Inventory
	{
		List<Item> items;

		int capacity;

		public Inventory(int capacity)
		{
			this.capacity = capacity;
			items = new List<Item>(capacity);
		}

		public void Add(Item item)
		{
			if (items.Count != capacity)
				items.Add(item);
			else
				Console.WriteLine("Inventory is full");
		}

		public void Remove(Item item)
		{
			items.Remove(item);
		}

		public void RemoveAt(int index)
		{
			items.RemoveAt(index);
		}

		public InventoryMemento SaveState()
		{
			Console.WriteLine("");
			return new InventoryMemento(items, capacity);
		}

		public void RestoreState(InventoryMemento memento)
		{
			items = memento.Items;
			capacity = memento.Capacity;
		}

		public void Print()
		{
			Console.WriteLine("==========Inventory=========================================");
			Console.WriteLine($"==========with capacity: {capacity}");
			Console.WriteLine($"==========and next items:");
			foreach (Item i in items) Console.WriteLine(i.Name);
			Console.WriteLine("============================================================");
		}
	}
}
