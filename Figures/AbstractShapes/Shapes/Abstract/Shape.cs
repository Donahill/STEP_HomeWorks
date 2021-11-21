using System;

namespace AbstractShapes
{
    abstract class Shape : IShape, IDrawable
    {
        public ConsoleColor Color { protected get; set; }

        public int X { get; set; }

        public int Y { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public abstract void Draw();

        public Shape(int x, int y, int width, int height, ConsoleColor color)
        {
            Color = color;
            X = x;
            Y = y;
            Width = width;
            Height = height;


        }
    }
}
