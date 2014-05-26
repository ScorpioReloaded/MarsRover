using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover
{
    class MoveForwardCommand : Command
    {

        public MoveForwardCommand(Rover rover)
            : base(rover)
        {

        }

        public override void Execute()
        {
            rover.Move(RoverMove.Forward);
        }

    }
}
