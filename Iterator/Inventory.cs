using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
	class Inventory : IItemNumerable
	{
		Item[] items;


		public Inventory(int capacity)
		{
			items = new Item[capacity];
			for (int i = 0; i < capacity; i++)
			{
				items[i] = new Item($"Item number {i + 1}");
			}
		}

		public Item this[int index] { get { return items[index]; } }

		public int Count { get { return items.Length; } }

		public IItemIterator CreateNumerator()
		{
			return new InventoryNumerator(this);
		}
	}
}
