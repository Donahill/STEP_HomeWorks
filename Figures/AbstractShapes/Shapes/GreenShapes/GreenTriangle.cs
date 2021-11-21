using System;

namespace AbstractShapes
{
    class GreenTriangle : Triangle
    {
        public GreenTriangle(int x, int y, int width, int height)
            : base(x, y, width, height, ConsoleColor.Green)
        {
        }
    }
}
