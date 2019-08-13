using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
	class Item
	{
		public string Name { get; private set; }
		public Item(string name) => Name = name;
	}
}
