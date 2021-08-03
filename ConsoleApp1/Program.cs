using System;
using Utility;
using Utility.Models;

namespace ConsoleApp1
{
    class Program
    {
        public const int tableDimmension = 5;

        static void Main(string[] args)
        {
            Rover roverInstance = InitializeRover();

            Console.WriteLine("Insert rover commands");
            var listOfCommands = Console.ReadLine().ToCharArray();

            var roverFunctionalityManager = new RoverFunctionalityManager(roverInstance);
            foreach (var command in listOfCommands)
            {
                switch (command)
                {
                    case 'M':
                        roverFunctionalityManager.MoveForward(tableDimmension);
                        break;
                    case 'L':
                        roverInstance.RotateLeft();
                        break;
                    case 'R':
                        roverInstance.RotateRight();
                        break;
                    default:
                        throw new ArgumentException("Unknown command");
                }
            }

            Console.WriteLine($"Rover last positions are :{roverInstance.XPosition}, {roverInstance.YPosition}, {roverInstance.Orientation}");
        }

        private static Rover InitializeRover()
        {
            Console.WriteLine("Insert rover position and orientation: (ex: 2,3,N) ");

            var positionAndOrientation = (Console.ReadLine()).Split(',');
            var roverInstance = new Rover
            {
                XPosition = int.Parse(positionAndOrientation[0]),
                YPosition = int.Parse(positionAndOrientation[1]),
                Orientation = char.Parse(positionAndOrientation[2])
            };

            return roverInstance;
        }
    }
}
