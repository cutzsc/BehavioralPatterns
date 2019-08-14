using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
	class Car
	{
		public IMovable Movable { private get; set; }

		public Car(IMovable movable)
		{
			Movable = movable;
		}

		public void Move()
		{
			Movable.Move();
		}
	}
}
