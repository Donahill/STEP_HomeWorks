using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Money_class

{
    sealed class Money
    {
        private int hrivnaUAH;
        private int kopiyok;
        

        public Money(int hrivna, int kopiyok)
        {
            HrivnaUAH = hrivna;
            Kopiyok = kopiyok;
        }

        public int HrivnaUAH { get => hrivnaUAH; set => hrivnaUAH = value; }
        public int Kopiyok
        {
            get => kopiyok;
            set
            {
                if (kopiyok < 0 || kopiyok > 99) throw new IndexOutOfRangeException(nameof(Kopiyok));
                kopiyok = value;
            }
        }

        public override string ToString()
            => $"{HrivnaUAH},{Kopiyok:00}";

        public static Money operator +(Money m1, Money m2)
        {
            int k = (m1.HrivnaUAH < 0 ? -100 - m1.Kopiyok : m1.Kopiyok)
                + (m2.HrivnaUAH < 0 ? -100 - m2.Kopiyok : m2.Kopiyok);

            int delta = k / 100;
            k %= 100;
            int r = (m1.HrivnaUAH < 0 ? 1 : 0) + m1.HrivnaUAH + (m2.HrivnaUAH < 0 ? 1 : 0) + m2.HrivnaUAH + delta;
            return new Money(r, Math.Abs(k));
        }

        public static Money operator -(Money m1, Money m2)
        {
            int k = (m1.HrivnaUAH < 0 ? -100 - m1.Kopiyok : m1.Kopiyok)
                - (m2.HrivnaUAH < 0 ? -100 - m2.Kopiyok : m2.Kopiyok);

            int delta = k / 100;
            k %= 100;
            int r = (m1.HrivnaUAH < 0 ? 1 : 0) + m1.HrivnaUAH - ((m2.HrivnaUAH < 0 ? 1 : 0) + m2.HrivnaUAH) + delta;
            return new Money(r, Math.Abs(k));
        }


        public override bool Equals(object obj)
            => Equals(obj as Money);
        public bool Equals(Money money)
            => money != null &&
                   HrivnaUAH == money.HrivnaUAH &&
                   Kopiyok == money.Kopiyok;

        public override int GetHashCode()
        => HrivnaUAH ^ Kopiyok;

        public static bool operator ==(Money m1, Money m2)
            => object.Equals(m1, m2);
        public static bool operator !=(Money m1, Money m2)
            => !object.Equals(m1, m2);
    }
    class Program
    {
        static void Main(string[] args)
        {
            var first_number = new Money(100, 25);
            var second_number = new Money(90, 99);
            Money summa = first_number + second_number;
            Money first_raznost = first_number - second_number;
            Money second_raznost = second_number - first_number;
            Console.WriteLine($"{first_number} {second_number} Сумма: {summa} Первая разность: {first_raznost} Вторая разность: {second_raznost}");

            var third_number = new Money(250, 99);
            var fourth_number = new Money(100, 99);
            Money summa_of_third_and_fourth = third_number + fourth_number;
            Money first_raznost_of_third_and_fourth = third_number - fourth_number;
            Money second_raznost_of_third_and_fourth = fourth_number - third_number;
            Console.WriteLine($"{third_number} {fourth_number} Сумма: {summa_of_third_and_fourth} Первая разность: {first_raznost_of_third_and_fourth} Вторая разность: {second_raznost_of_third_and_fourth}");

            Console.WriteLine((Money)null == null);

            Console.ReadKey();
        }
    }
}