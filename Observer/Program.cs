using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
	class Program
	{
		static void Main(string[] args)
		{
			Stock stock = new Stock();
			Bank bank = new Bank("Steel", stock);
			Broker broker = new Broker("Alex", stock);

			stock.Market();
			stock.Market();
			stock.Market();

			broker.StopTrade();

			stock.Market();
			stock.Market();

			Console.ReadLine();
		}
	}
}
