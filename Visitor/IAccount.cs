﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
	interface IAccount
	{
		void Accept(IVisitor visitor);
	}
}
