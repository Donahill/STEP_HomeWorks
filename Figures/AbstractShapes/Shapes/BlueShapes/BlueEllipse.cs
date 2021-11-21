using System;

namespace AbstractShapes
{
    class BlueEllipse : Ellipse
    {
        public BlueEllipse(int x, int y, int width, int height)
            : base(x, y, width, height, ConsoleColor.Blue)
        {
        }
    }
}
