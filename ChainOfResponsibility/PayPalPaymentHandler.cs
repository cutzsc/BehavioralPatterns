using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
	class PayPalPaymentHandler : PaymentHandler
	{
		public override void Handle(Receiver receiver)
		{
			if (receiver.PayPalTransfer)
				Console.WriteLine("Выполняем перевод через PayPal");
			else
				Successor?.Handle(receiver);
		}
	}
}
