using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDictionary_10112021
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMultySet<int> tree = new MyMultySet<int>();
            Random r = new Random();
            for(int i=0; i<100; ++i)
            {
                tree.Add(r.Next(100));
            }

            foreach(int x in tree)
            {
                Console.Write($"{x}; ");
            }

            Console.ReadKey();

            MyMap<string, string> dictionary = new MyMap<string, string>();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            
            for (; ; ) {

                Console.Write("Введите слово => _\b");
                string quastion = Console.ReadLine().Trim().ToLower();
                if (quastion == "quit")
                {
                    break;
                }
                string answer;
                if (dictionary.TryGetValue(quastion, out answer))
                {
                    Console.WriteLine($"Перевод => {answer}");
                }
                else
                {
                    Console.WriteLine($"Слово {quastion} отсетствует в словаре");
                    Console.Write("Введите перевод => _\b");
                    answer = Console.ReadLine().Trim().ToLower();
                    dictionary.Add(quastion, answer);
                }
            }
        }
    }
}
