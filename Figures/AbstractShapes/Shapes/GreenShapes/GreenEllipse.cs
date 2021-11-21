using System;

namespace AbstractShapes
{
    class GreenEllipse : Ellipse
    {
        public GreenEllipse(int x, int y, int width, int height)
            : base(x, y, width, height, ConsoleColor.Green)
        {
        }
    }
}
