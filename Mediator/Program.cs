using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
	class Program
	{
		static void Main(string[] args)
		{
			ManagerMediator m = new ManagerMediator();
			CustomerColleague customer = new CustomerColleague(m);
			ProgrammerColleague programmer = new ProgrammerColleague(m);
			TesterColleague tester = new TesterColleague(m);
			m.Customer = customer;
			m.Programmer = programmer;
			m.Tester = tester;

			customer.Send("Есть заказ, надо сделать программу");
			programmer.Send("Программа готова, надо протестировать");
			tester.Send("Программа протестирована и готова к продаже");

			Console.ReadLine();
		}
	}
}
