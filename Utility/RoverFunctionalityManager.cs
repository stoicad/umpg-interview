using System;
using Utility.Models;

namespace Utility
{
    public class RoverFunctionalityManager
    {
        private readonly Rover _rover;
        public RoverFunctionalityManager(Rover rover)
        {
            _rover = rover;
        }

        public void MoveForward(int tableDimmension)
        {
            switch (_rover.Orientation)
            {
                case 'N':
                    _rover.YPosition += 1;
                    break;
                case 'S':
                    _rover.YPosition -= 1;
                    break;
                case 'W':
                    _rover.XPosition -= 1;
                    break;
                case 'E':
                    _rover.XPosition += 1;
                    break;

                default:
                    break;
            }

            if (_rover.XPosition > (tableDimmension - 1) || _rover.YPosition < 0 || _rover.XPosition < 0 || _rover.YPosition > (tableDimmension - 1))
            {
                throw new IndexOutOfRangeException("Rover is trying to exit his plateau.");
            }
        }

    }
}
