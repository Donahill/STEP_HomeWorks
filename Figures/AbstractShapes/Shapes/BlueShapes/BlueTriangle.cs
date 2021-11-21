using System;

namespace AbstractShapes
{
    class BlueTriangle : Triangle
    {
        public BlueTriangle(int x, int y, int width, int height)
            : base(x, y, width, height, ConsoleColor.Blue)
        {
        }
    }
}
