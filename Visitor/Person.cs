using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
	class Person : IAccount
	{
		public string Name { get; set; }
		public string AccNumber { get; set; }

		public void Accept(IVisitor visitor)
		{
			visitor.VisitPersonAcc(this);
		}
	}
}
