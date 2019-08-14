using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
	class Program
	{
		static void Main(string[] args)
		{
			Bank bank = new Bank();
			bank.Add(new Person { Name = "Alex", AccNumber = "21551235317" });
			bank.Add(new Person { Name = "Sam", AccNumber = "42316421449" });
			bank.Add(new Person { Name = "Jessie", AccNumber = "1541255215" });
			bank.Add(new Company { Name = "Microsoft", RegNumber = "13684", AccNumber = "69254638726" });

			IVisitor vis = new HtmlVisitor();
			bank.Accept(vis);

			vis = new XmlVisitor();
			bank.Accept(vis);


			Console.ReadLine();
		}
	}
}
