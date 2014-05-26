using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rover
{
    class CommandEngine
    {

        public String Execute(string inputCommand)
        {
            //Read and parse command to char array
            char[] parsedCommand = inputCommand.ToUpper().ToCharArray(); 

            //Creating Rover, command and comman Invoker
            LandscapeGrid landScapeGrid = LandscapeGrid.Create(0, 0, 4, 4); //Create Singleton landScape for Rover to walk on
            Rover rover = Rover.Create(0, 0, landScapeGrid); //Create Singleton Rover and pass Land Scape Grid to walk over
            Command command;
            CommandInvoker invoker = new CommandInvoker(); //Invoker of command pattern to invoke command

             //Rover is on a Walk
            Console.WriteLine("Ahan! Rover is walking now..." + Environment.NewLine);
            for (int i = 0; i < parsedCommand.Length; i++)
            {
                switch(parsedCommand[i])
                {
                    case 'R':
                        command = new RotateRightCommand(rover); //Set appropiate command
                        InvokerExecuteCommand(invoker, command); //Set and execute command on invoker
                        break;
                    case 'L':
                        command = new RotateLeftCommand(rover);//Set appropiate command
                        InvokerExecuteCommand(invoker, command); //Set and execute command on invoker
                        break;
                    case 'F':
                        command = new MoveForwardCommand(rover);//Set appropiate command
                        InvokerExecuteCommand(invoker, command); //Set and execute command on invoker
                        break;
                    //Case 'B': for application extension to move rover to backword
                }

               
            }

            return rover.roverCurrentPosition.ToString();
        }

         /// <summary>
        /// Invoker setting and Executing Command
        /// </summary>
        /// <param name="command"></param>
        private static void InvokerExecuteCommand(CommandInvoker invoker, Command command)
        {
                invoker.SetCommand(command);
                invoker.ExecuteCommand();
        }
    }
}
