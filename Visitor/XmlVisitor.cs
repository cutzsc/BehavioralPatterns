using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
	class XmlVisitor : IVisitor
	{
		public void VisitCompanyAcc(Company acc)
		{
			string result = "<Company><Name>" + acc.Name + "</Name>" +
				"<RegNumber>" + acc.RegNumber + "</RegNumber>" +
				"<Number>" + acc.AccNumber + "</Number><Company>";
			Console.WriteLine(result);
		}

		public void VisitPersonAcc(Person acc)
		{
			string result = "<Person><Name>" + acc.Name + "</Name>" +
				"<Number>" + acc.AccNumber + "</Number><Person>";
			Console.WriteLine(result);
		}
	}
}
