using System;
using System.Collections.Generic;
using System.Text;
using Utility.Models;

namespace RoverTests
{
    public class BaseTests
    {
        protected Rover InitilizeRover()
        {
            return new Rover
            {
                XPosition = 0,
                YPosition = 0,
                Orientation = 'N'
            };
        }
    }
}
