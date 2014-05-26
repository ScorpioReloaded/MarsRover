using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover
{
    class RotateRightCommand : Command
    {

        public RotateRightCommand(Rover rover)
            : base(rover)
        {

        }

        public override void Execute()
        {
            rover.Rotate(RotatePosition.Right);
        }
      
    }
}
