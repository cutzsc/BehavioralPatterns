using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
	class InventoryNumerator : IItemIterator
	{
		IItemNumerable aggregate;
		int index = 0;

		public InventoryNumerator(IItemNumerable a)
		{
			aggregate = a;
		}

		public bool HasNext()
		{
			return index < aggregate.Count;
		}

		public Item Next()
		{
			return aggregate[index++];
		}
	}
}
