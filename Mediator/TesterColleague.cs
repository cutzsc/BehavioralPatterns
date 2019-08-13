using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
	class TesterColleague : Colleague
	{
		public TesterColleague(Mediator m)
			: base(m) { }

		public override void Notify(string message)
		{
			Console.WriteLine("Сообщение тестеру: " + message);
		}
	}
}
