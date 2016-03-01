using System.Diagnostics;

namespace ZConsole.General
{

    [DebuggerDisplay("[{X}, {Y}]")]
    internal struct Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
