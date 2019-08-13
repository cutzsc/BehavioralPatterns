using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
	class ManagerMediator : Mediator
	{
		public Colleague Customer { get; set; }
		public Colleague Programmer { get; set; }
		public Colleague Tester { get; set; }

		public override void Send(string message, Colleague colleague)
		{
			if (Customer == colleague)
				Programmer.Notify(message);

			if (colleague == Programmer)
				Tester.Notify(message);

			if (colleague == Tester)
				Customer.Notify(message);
		}
	}
}
