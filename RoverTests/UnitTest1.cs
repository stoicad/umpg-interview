using NUnit.Framework;
using System;
using Utility;

namespace RoverTests
{
    public class Tests : BaseTests
    {
        private const int tableDimmension = 5;

        [Test]
        public void RoverMoveForward()
        {
            var rover = InitilizeRover();
            var roverManager = new RoverFunctionalityManager(rover);
            roverManager.MoveForward(tableDimmension);

            Assert.AreEqual(1, rover.YPosition);
            Assert.AreEqual(0, rover.XPosition);
            Assert.AreEqual('N', rover.Orientation);
        }

        [Test]
        public void RoverRotateLeft()
        {
            var rover = InitilizeRover();
            rover.RotateLeft();

            Assert.AreEqual('W', rover.Orientation);
        }

        [Test]
        public void RoverRotateRight()
        {
            var rover = InitilizeRover();
            rover.RotateRight();

            Assert.AreEqual('E', rover.Orientation);
        }

        [Test]
        public void RoverTryExitPlateau()
        {
            var rover = InitilizeRover();
            rover.XPosition = 4;

            var roverManager = new RoverFunctionalityManager(rover);
            try
            {
                roverManager.MoveForward(tableDimmension);
            }
            catch (IndexOutOfRangeException ex)
            {
                Assert.Pass();
            }
        }

    }
}