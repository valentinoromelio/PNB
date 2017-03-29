using System;
using System.Collections.Generic;

namespace Proj2
{
    public class Robot : iRobot
    {
        private List<Move>  _Steps;
        private Position    _Position;
        private BattleField _BattleField;

        public Robot(Position startPosition, List<Move> steps, BattleField battleField)
        {
            _Position = startPosition;
            _Steps = steps;
            _BattleField = battleField;
        }

        public Position Position
        {
            get {
                return _Position;
            }
        }

        public void Run()
        {
            int count = 0;

            foreach (Move item in _Steps)
            {
                if (item == Move.L)
                {
                    if (_Position.D == Direction.N)
                        _Position.D = Direction.W;
                    else if (_Position.D == Direction.W)
                        _Position.D = Direction.S;
                    else if (_Position.D == Direction.S)
                        _Position.D = Direction.E;
                    else if (_Position.D == Direction.E)
                        _Position.D = Direction.N;
                }
                else if (item == Move.R)
                {
                    if (_Position.D == Direction.N)
                        _Position.D = Direction.E;
                    else if (_Position.D == Direction.E)
                        _Position.D = Direction.S;
                    else if (_Position.D == Direction.S)
                        _Position.D = Direction.W;
                    else if (_Position.D == Direction.W)
                        _Position.D = Direction.N;
                }
                else if(item == Move.M)
                {
                    if (_Position.D==Direction.N)
                    {
                        if (_Position.Y < _BattleField.MaxY)
                        {
                            _Position.Y++;
                        }
                    }
                    if (_Position.D == Direction.S)
                    {
                        if (Position.Y > 0)
                        {
                            _Position.Y--;
                        }
                    }

                    if (_Position.D == Direction.W)
                    {
                        if (Position.X > 0)
                        { 
                            _Position.X--;
                        }
                    }
                    if (_Position.D == Direction.E)
                    {
                        if (Position.X < _BattleField.MaxX)
                        {
                            _Position.X++;
                        }
                    }

                    count++;
                }
            }
        }
    }
}
