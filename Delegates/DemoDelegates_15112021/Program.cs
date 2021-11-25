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
        static float noll(float a, float b)
        {
            return 0;
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

        static bool func(int a, int b)
        {
            return a > b;
        }
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-us");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-us");

            AriphmeticDelegate[] ariphmetics = new AriphmeticDelegate[] {noll, add, sub, mul, div };

            float a = 100, b = 200;
            int i = 2;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Введите первое число:  ");
                a = (float)Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите второе число:  ");
                b = (float)Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Выберите арифметическое действие между введёнными числами:  ");
                Console.WriteLine("1: +;  ");
                Console.WriteLine("2: -;  ");
                Console.WriteLine("3: *;  ");
                Console.WriteLine("4: /;  ");
                Console.WriteLine("Или 0 для отмены");
                i = Convert.ToInt32(Console.ReadLine());
                float res = ariphmetics[(i)](a, b);
                Console.WriteLine("Результат:");
                Console.WriteLine(res);
                Console.WriteLine("Чтобы продолжить нажмите любую клавишу");
                Console.ReadKey();
                Console.Clear();
            } while (i != 0);
        }
    }
}
