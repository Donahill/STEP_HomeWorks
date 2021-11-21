using System;

namespace AbstractShapes
{
    class RedRectangle : Rectangle
    {
        public RedRectangle(int x, int y, int width, int height) 
            : base(x, y, width, height, ConsoleColor.Red)
        {
        }
    }
}
