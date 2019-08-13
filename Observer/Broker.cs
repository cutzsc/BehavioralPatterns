using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
	class Broker : IObserver
	{
		public string Name { get; set; }
		IObservable stock;

		public Broker(string name, IObservable o)
		{
			Name = name;
			stock = o;
			stock.AddObserver(this);
		}

		public void Update(object o)
		{
			StockInfo sInfo = (StockInfo)o;

			if (sInfo.USD > 30)
				Console.WriteLine("Брокер {0} продает доллары;  Курс доллара: {1}", this.Name, sInfo.USD);
			else
				Console.WriteLine("Брокер {0} покупает доллары;  Курс доллара: {1}", this.Name, sInfo.USD);
		}

		public void StopTrade()
		{
			stock.RemoveObserver(this);
			stock = null;
		}
	}
}
