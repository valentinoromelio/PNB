using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proj2
{
    public partial class Pro2 : Form
    {
        public Pro2()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            BattleField battleField = BattleField.Instance;
            battleField.MaxX = 5;
            battleField.MaxY = 5;

            Position startPositionRobotA = new Position(1, 2, Direction.N);
            Position startPositionRobotB = new Position(3, 3, Direction.E);
            List<Move> stepsRobotA = new List<Move>();
            stepsRobotA.Add(Proj2.Move.L);
            stepsRobotA.Add(Proj2.Move.M);
            stepsRobotA.Add(Proj2.Move.L);
            stepsRobotA.Add(Proj2.Move.M);
            stepsRobotA.Add(Proj2.Move.L);
            stepsRobotA.Add(Proj2.Move.M);
            stepsRobotA.Add(Proj2.Move.L);
            stepsRobotA.Add(Proj2.Move.M);
            stepsRobotA.Add(Proj2.Move.M);
            List<Move> stepsRobotB = new List<Move>();
            stepsRobotB.Add(Proj2.Move.M);
            stepsRobotB.Add(Proj2.Move.M);
            stepsRobotB.Add(Proj2.Move.R);
            stepsRobotB.Add(Proj2.Move.M);
            stepsRobotB.Add(Proj2.Move.M);
            stepsRobotB.Add(Proj2.Move.R);
            stepsRobotB.Add(Proj2.Move.M);
            stepsRobotB.Add(Proj2.Move.R);
            stepsRobotB.Add(Proj2.Move.R);
            stepsRobotB.Add(Proj2.Move.M);
            iRobot robotA = new Robot(startPositionRobotA, stepsRobotA, battleField);
            iRobot robotB = new Robot(startPositionRobotB, stepsRobotB, battleField);
            battleField.AddRobot(robotA);
            battleField.AddRobot(robotB);

            battleField.Run();
        }
    }
}
