using System;

namespace AbstractShapes
{
    class BlueRectangle : Rectangle
    {
        public BlueRectangle(int x, int y, int width, int height)
            : base(x, y, width, height, ConsoleColor.Blue)
        {
        }
    }
}
