using System;

namespace AbstractShapes
{
    class Rectangle : Shape, IShape, IDrawable
    {
        public Rectangle(int x, int y, int width, int height, ConsoleColor color) : base(x, y, width, height, color)
        {
        }
        public override void Draw()
        {
            Console.ForegroundColor = Color;
            Console.WriteLine("I am Rectangle");
        }

    }
}
