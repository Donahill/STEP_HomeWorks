using System;

namespace AbstractShapes
{
    interface IDrawable
    {
        ConsoleColor Color { set; }

        void Draw();
    }
}
