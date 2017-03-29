using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proj2;
using System.Collections.Generic;


/** Valentino Rijhen
 * 0615310513
 */
namespace TestRobotsPositions
{
    [TestClass]
    public class UnitTest1
    {
        BattleField battleField = BattleField.Instance;

        [TestMethod]
        public void TestRobotA()
        {
            //Define input
            battleField.MaxX = 5;
            battleField.MaxY = 5;
            Position startPositionRobotA = new Position(1, 2, Direction.N);
            List<Move> stepsRobotA = new List<Move>();
            stepsRobotA.Add(Move.L);
            stepsRobotA.Add(Move.M);
            stepsRobotA.Add(Move.L);
            stepsRobotA.Add(Move.M);
            stepsRobotA.Add(Move.L);
            stepsRobotA.Add(Move.M);
            stepsRobotA.Add(Move.L);
            stepsRobotA.Add(Move.M);
            stepsRobotA.Add(Move.M);   
            Robot robotA = new Robot(startPositionRobotA, stepsRobotA, battleField);
            battleField.AddRobot(robotA);
            battleField.Run();

            //Define output according to acceptance criteria
            Assert.IsTrue(robotA.Position.X==1);
            Assert.IsTrue(robotA.Position.Y==3);
            Assert.IsTrue(robotA.Position.D==Direction.N);
        }

        [TestMethod]
        public void TestRobotB()
        {
            //Define input
            battleField.MaxX = 5;
            battleField.MaxY = 5;
            Position startPositionRobotB = new Position(3, 3, Direction.E);
            List<Move> stepsRobotB = new List<Move>();
            stepsRobotB.Add(Move.M);
            stepsRobotB.Add(Move.M);
            stepsRobotB.Add(Move.R);
            stepsRobotB.Add(Move.M);
            stepsRobotB.Add(Move.M);
            stepsRobotB.Add(Move.R);
            stepsRobotB.Add(Move.M);
            stepsRobotB.Add(Move.R);
            stepsRobotB.Add(Move.R);
            stepsRobotB.Add(Move.M);
            Robot robotB = new Robot(startPositionRobotB, stepsRobotB, battleField);
            battleField.AddRobot(robotB);
            battleField.Run();

            //Define output according to acceptance criteria
            Assert.IsTrue(robotB.Position.X == 5);
            Assert.IsTrue(robotB.Position.Y == 1);
            Assert.IsTrue(robotB.Position.D == Direction.E);
        }
    }
}
