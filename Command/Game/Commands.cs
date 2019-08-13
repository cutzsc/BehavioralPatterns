using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Game
{
	class JumpCommand : Command
	{
		public override void Execute(GameActor actor)
		{
			actor.Jump();
		}
	}

	class FireCommand : Command
	{
		public override void Execute(GameActor actor)
		{
			actor.Fire();
		}
	}

	class SwapWeaponCommand : Command
	{
		public override void Execute(GameActor actor)
		{
			actor.SwapWeapon();
		}
	}

	class Lurch : Command
	{
		public override void Execute(GameActor actor)
		{
			actor.Lurch();
		}
	}
}
