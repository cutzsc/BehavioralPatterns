using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
	interface IItemNumerable
	{
		IItemIterator CreateNumerator();
		int Count { get; }
		Item this[int index] { get; }
	}
}
