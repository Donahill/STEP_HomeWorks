using System;

namespace AbstractShapes
{
    class Ellipse : Shape, IShape, IDrawable
    {

        public Ellipse(int x, int y, int width, int height, ConsoleColor color) : base(x, y, width, height, color)
        {
        }

        public override void Draw()
        {
            Console.ForegroundColor = Color;
            Console.WriteLine("I am Ellipse");
        }

    }
}
