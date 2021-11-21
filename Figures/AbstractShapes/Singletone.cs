using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractShapes
{
    enum Shapes { Rectangle, Triangle, Ellipse}

    enum Colors { Red, Green, Blue}
    class Singletone
    {
        public static Singletone Instance { get; } = new Singletone();

        private IShapeFactory[] _factories;
        private Singletone()
        {
            _factories = new IShapeFactory[]{
                new RedShapeFactory(),
                new GreenShapeFactory(),
                new BlueShapeFactory()
            };
        }

        public IShapeFactory this[Colors color]
        {
            get
            {
                return _factories[(int)color];
            }
        }

        public IShapeFactory this[int colorIndex]
        {
            get
            {
                return _factories[colorIndex];
            }
        }


    }
}
