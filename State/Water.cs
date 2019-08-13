using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
	class Water
	{
		public WaterState State { get; set; }

		public Water(WaterState state)
		{
			State = state;
		}

		public void Heat()
		{
			if (State == WaterState.Solid)
			{
				Console.WriteLine("Превращаем лед в жидкость");
				State = WaterState.Liquid;
			}
			else if (State == WaterState.Liquid)
			{
				Console.WriteLine("Превращаем жидкость в пар");
				State = WaterState.Gas;
			}
			else if (State == WaterState.Gas)
			{
				Console.WriteLine("Повышаем температуру водяного пара");
			}
		}

		public void Frost()
		{
			if (State == WaterState.Liquid)
			{
				Console.WriteLine("Превращаем жидкость в лед");
				State = WaterState.Solid;
			}
			else if (State == WaterState.Gas)
			{
				Console.WriteLine("Превращаем водяной пар в жидкость");
				State = WaterState.Liquid;
			}
			else if (State == WaterState.Solid)
			{
				Console.WriteLine("Понижаем температуру льда");
			}
		}
	}
}
