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

            char symbol_1 = '0';
            char symbol_2 = '0';

            do
            {
                Console.WriteLine();
                Console.WriteLine("Выберите одну или несколько фигур для вывода:  ");
                Console.WriteLine("Выберите цвет:  ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("r - красный");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("b - голубой");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("g - зеленый");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Или нажмите ноль для выхода:  ");
                symbol_1 = Convert.ToChar(Console.ReadLine());
                
                Console.WriteLine();
                Console.WriteLine("Выберите тип фигуры:  ");
                Console.WriteLine("a - Rectangle");
                Console.WriteLine("t - Triangle");
                Console.WriteLine("e - Ellipce");
                Console.WriteLine();
                Console.WriteLine("Или нажмите ноль для выхода:  ");
                symbol_2 = Convert.ToChar(Console.ReadLine());

                switch (symbol_1)
                {
                    case 'r':
                        switch (symbol_2)
                        {
                            case 'a':
                                shapes.Add(rf.GetRectangle(10, 10, 100, 100));
                                break;
                            case 't':
                                shapes.Add(rf.GetTriangle(10, 10, 100, 100));
                                break;
                            case 'e':
                                shapes.Add(rf.GetEllipse(10, 10, 100, 100));
                                break;
                        }
                        break;
                    case 'b':
                        switch (symbol_2)
                        {
                            case 'a':
                                shapes.Add(bf.GetRectangle(10, 10, 100, 100));
                                break;
                            case 't':
                                shapes.Add(bf.GetTriangle(10, 10, 100, 100));
                                break;
                            case 'e':
                                shapes.Add(bf.GetEllipse(10, 10, 100, 100));
                                break;
                        }
                        break;
                    case 'g':
                        switch (symbol_2)
                        {
                            case 'a':
                                shapes.Add(gf.GetRectangle(10, 10, 100, 100));
                                break;
                            case 't':
                                shapes.Add(gf.GetTriangle(10, 10, 100, 100));
                                break;
                            case 'e':
                                shapes.Add(gf.GetEllipse(10, 10, 100, 100));
                                break;
                        }
                        break;
                }

            } while ((symbol_1 !=  '0')&&(symbol_2 != '0'));

            foreach (Shape item in shapes)
            {
                item.Draw();
            }
            Console.ForegroundColor = ConsoleColor.White;

            Console.ReadKey();
        }
    }
}
