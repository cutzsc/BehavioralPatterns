using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
	class Program
	{
		static void Main(string[] args)
		{
			Water water = new Water(WaterState.Gas);

			water.Heat();
			water.Frost();
			water.Heat();
			water.Frost();
			water.Frost();
			water.Frost();

			Console.ReadLine();
		}
	}
}
