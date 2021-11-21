using System;

namespace AbstractShapes
{
    class RedEllipse : Ellipse
    {
        public RedEllipse(int x, int y, int width, int height) 
            : base(x, y, width, height, ConsoleColor.Red)
        {
        }
    }
}
