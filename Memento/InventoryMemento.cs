using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
	class InventoryMemento
	{
		public List<Item> Items { get; private set; }
		public int Capacity { get; private set; }
		public InventoryMemento(List<Item> items, int capacity)
		{
			Items = items;
			Capacity = capacity;
		}
	}
}
