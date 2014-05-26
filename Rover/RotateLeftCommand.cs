using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover
{
    class RotateLeftCommand : Command
    {

        public RotateLeftCommand(Rover rover)
            : base(rover)
        {

        }

        public override void Execute()
        {
            rover.Rotate(RotatePosition.Left);
        }
      
    }
}
