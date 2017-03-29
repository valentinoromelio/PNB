
using System.Collections.Generic;

namespace Proj2
{
    public class BattleField
    {
        public short MaxY;
        public short MaxX;
        private static BattleField instance;
        private List<iRobot> robots = new List<iRobot>();

        private BattleField() { }

        public static BattleField Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BattleField();
                }
                return instance;
            }
        }

        public void AddRobot(iRobot robot)
        {
            robots.Add(robot);
        }

        public void Run()
        {
            foreach (var robot in robots)
            {
                robot.Run();
            }
        }
    }
}
