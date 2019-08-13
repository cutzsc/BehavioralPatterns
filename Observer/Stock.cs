using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
	class Stock : IObservable
	{
		List<IObserver> observers;

		StockInfo sInfo;

		public Stock()
		{
			observers = new List<IObserver>();
			sInfo = new StockInfo();
		}

		public void AddObserver(IObserver o)
		{
			observers.Add(o);
		}

		public void NotifyObservers()
		{
			foreach (IObserver o in observers)
				o.Update(sInfo);
		}

		public void RemoveObserver(IObserver o)
		{
			observers.Remove(o);
		}

		Random rnd = new Random();
		public void Market()
		{
			sInfo.USD = rnd.NextDouble() * rnd.Next(10, 80);
			sInfo.Euro = rnd.NextDouble() * rnd.Next(30, 300);
			NotifyObservers();
		}
	}
}
