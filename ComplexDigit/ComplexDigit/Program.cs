using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexDigit
{
    class inputI
    {
        public Complex INp()
        {
            Console.Write("Введите действительную часть=>_\b");
            string str = Console.ReadLine();
            double re = Convert.ToDouble(str);
            Console.Write("Введите коэффициент=>_\b");
            string str1 = Console.ReadLine();
            double im = Convert.ToDouble(str1);
            Complex s = new Complex(re, im);
            return s;
        }

        public Complex doo(Complex a, Complex b)
        {
            Console.WriteLine("Выберите действие: +,-,*,/_\b");
            string str = Console.ReadLine();
            Complex s;
            if (str == "+")
            {
                s = a + b;
                return s;
            }

            if (str == "-")
            {
                s = a - b;
                return s;
            }

            if (str == "*")
            {
                s = a * b;
                return s;
            }

            if (str == "/")
            {
                s = a / b;
                return s;
            }
            return null;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex a;
            Complex b;
            Complex c;
            inputI s=new inputI();

            a = s.INp();
            b = s.INp();
            Console.WriteLine(a);
            Console.WriteLine(b);
            c = s.doo(a,b);
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
