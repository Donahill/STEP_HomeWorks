using System;

namespace AbstractShapes
{
    class RedTriangle : Triangle
    {
        public RedTriangle(int x, int y, int width, int height) 
            : base(x, y, width, height, ConsoleColor.Red)
        {
        }
    }
}
