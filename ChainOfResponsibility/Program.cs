using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
	class Program
	{
		static void Main(string[] args)
		{
			Receiver receiver = new Receiver(false, true, true);

			PaymentHandler bank = new BankPaymentHandler();
			PaymentHandler money = new MoneyPaymentHandler();
			PaymentHandler pp = new PayPalPaymentHandler();

			bank.Successor = pp;
			pp.Successor = money;

			bank.Handle(receiver);

			Console.ReadLine();
		}
	}
}
