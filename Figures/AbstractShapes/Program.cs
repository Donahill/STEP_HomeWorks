using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractShapes
{


    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<IShape> shapes = new List<IShape>();

            //Random rnd = new Random();

            RedShapeFactory rf = new RedShapeFactory();
            BlueShapeFactory bf = new BlueShapeFactory();
            GreenShapeFactory gf = new GreenShapeFactory();

            Console.ReadKey();

        }
    }
}
