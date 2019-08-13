using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
	class ProgrammerColleague : Colleague
	{
		public ProgrammerColleague(Mediator m)
			: base(m) { }

		public override void Notify(string message)
		{
			Console.WriteLine("Сообщение программисту: " + message);
		}
	}
}
