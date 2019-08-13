using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
	class MoneyPaymentHandler : PaymentHandler
	{
		public override void Handle(Receiver receiver)
		{
			if (receiver.MoneyTransfer)
				Console.WriteLine("Выполняем перевод через системы денежных переводов");
			else
				Successor?.Handle(receiver);
		}
	}
}
