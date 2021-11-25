using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

delegate decimal Test();

namespace DemoDelegates_15112021
{  
    
    delegate void MyDelegate(int a, int b);
    delegate bool CompareDelegate(int x, int y);
    delegate float AriphmeticDelegate(float a, float b);
    class Program { 
        static void MyMethod(int x, int y)
        {
            Console.WriteLine(x + y);
        }

        static float add (float a, float b)
        {
            return a + b;
        }
        static float sub(float a, float b)
        {
            return a - b;
        }
        static float mul(float a, float b)
        {
            return a * b;
        }
        static float div(float a, float b)
        {
            return a / b;
        }

        static void DemoSort(int[] mas, CompareDelegate d)
        {
            int size = mas.Length;
            while(--size > 0)
            {
                for(int i=0; i<size; ++i)
                {
                    if(d(mas[i], mas[i + 1]))
                    {
                        int tmp = mas[i];
                        mas[i] = mas[i + 1];
                        mas[i + 1] = tmp;
                    }
                }
            }
        }
        static bool func(int a, int b)
        {
            return a > b;
        }
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-us");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-us");

            int[] mas = { 3, 1, 5, 3, 8, 9, 4, 5, 6, 7, 1, 2, 0, 5 };

            DemoSort(mas, ( x, y ) => { return x > y; } );

            foreach(var x in mas)
            {
                Console.Write($"{x}; ");
            }
            Console.WriteLine();
            Console.ReadKey();


            AriphmeticDelegate[] ariphmetics = new AriphmeticDelegate[] { add, sub, mul, div };

            float a = 100, b = 200;
            int i = 2;
            
            float res = ariphmetics[i](a, b);


            MyDelegate deleg = MyMethod;
            deleg(10, 25);
        }
    }
}
