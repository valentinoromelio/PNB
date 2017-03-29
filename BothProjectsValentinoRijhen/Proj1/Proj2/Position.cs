namespace Proj2
{
    public enum Direction { N, S, W, E}
    public enum Move { L, R, M }
    public class Position
    {
        public short X;
        public short Y;
        public Direction D;

        public Position(short x, short y, Direction d)
        {
            X = x;
            Y = y;
            D = d;
        }
    }
}
