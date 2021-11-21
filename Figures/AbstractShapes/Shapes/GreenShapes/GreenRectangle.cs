using System;

namespace AbstractShapes
{
    class GreenRectangle : Rectangle
    {
        public GreenRectangle(int x, int y, int width, int height)
            : base(x, y, width, height, ConsoleColor.Green)
        {
        }
    }
}
