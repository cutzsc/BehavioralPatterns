using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
	class BankPaymentHandler : PaymentHandler
	{
		public override void Handle(Receiver receiver)
		{
			if (receiver.BankTransfer)
				Console.WriteLine("Выполняем банковский перевод");
			else
				Successor?.Handle(receiver);
		}
	}
}
