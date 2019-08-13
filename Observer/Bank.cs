using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
	class Bank : IObserver
	{
		public string Name { get; set; }
		IObservable stock;

		public Bank(string name, IObservable o)
		{
			Name = name;
			stock = o;
			stock.AddObserver(this);
		}

		public void Update(object o)
		{
			StockInfo sInfo = (StockInfo)o;

			if (sInfo.Euro > 40)
				Console.WriteLine("Банк {0} продает евро;  Курс евро: {1}", this.Name, sInfo.Euro);
			else
				Console.WriteLine("Банк {0} покупает евро;  Курс евро: {1}", this.Name, sInfo.Euro);
		}
	}
}
