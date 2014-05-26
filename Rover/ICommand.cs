using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover
{
    abstract class Command
    {
        protected Rover rover;

        public Command(Rover rover)
        {
            this.rover = rover;
        }

        public abstract void Execute();

    }
}
