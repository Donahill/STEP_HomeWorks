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
            Console.Write("Введите числитель=>_\b");
            string str = Console.ReadLine();
            int ch1 = Convert.ToInt32(str);
            Console.Write("Введите знаменатель=>_\b");
            string str1 = Console.ReadLine();
            int zn1 = Convert.ToInt32(str);
            Complex s = new Complex(ch1, zn1);
            return s;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
