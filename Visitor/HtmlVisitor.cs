using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
	class HtmlVisitor : IVisitor
	{
		public void VisitCompanyAcc(Company acc)
		{
			string result = "<table><tr><td>Свойство<td><td>Значение</td></tr>";
			result += "<tr><td>Name<td><td>" + acc.Name + "</td></tr>";
			result += "<tr><td>RegNumber<td><td>" + acc.RegNumber + "</td></tr>";
			result += "<tr><td>Number<td><td>" + acc.AccNumber + "</td></tr></table>";
			Console.WriteLine(result);
		}

		public void VisitPersonAcc(Person acc)
		{
			string result = "<table><tr><td>Свойство<td><td>Значение</td></tr>";
			result += "<tr><td>Name<td><td>" + acc.Name + "</td></tr>";
			result += "<tr><td>Number<td><td>" + acc.AccNumber + "</td></tr></table>";
			Console.WriteLine(result);
		}
	}
}
