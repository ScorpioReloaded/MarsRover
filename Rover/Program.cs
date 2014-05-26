using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Rover is wating for your command.... :)" + Environment.NewLine);

            //Read and parse command to char array
            string inputCommand = Console.ReadLine();
            
          
            //Rover is on a Walk
            CommandEngine commandEngine = new CommandEngine();
            string roverPosition = commandEngine.Execute(inputCommand);
     
           

            //Rover done with command
            Console.WriteLine("Rover reached its destination!...");
            Console.WriteLine(string.Format(":-) {0}", roverPosition));

            Console.ReadKey();


        }

       
    }
}
