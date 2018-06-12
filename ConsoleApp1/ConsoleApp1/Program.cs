using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static double Func (double perem)
        {
            perem = Math.Pow(perem, 4) + (0.8 * Math.Pow(perem, 3)) - (0.4 * Math.Pow(perem, 2)) - 1.4 * perem - 1.2;
            return perem;
        }


        static void Main(string[] args)
        {
            bool succ = false;
            double e;
            double a = -1.2;
            double b = -0.5;
            double x;
            do
            {
                Console.WriteLine("Введите число e");
                succ = double.TryParse(Console.ReadLine(), out e);
                if (!succ) Console.WriteLine("Введите число");
            } while (!succ);

            do
            {
                x = (a + b) / 2;
                if (Func(a) * Func(x) < 0)
                    b = x;
                else
                    a = x;
            } while (Math.Abs(a - b) > 2 * e);

            Console.WriteLine("X = " + x);
            Console.ReadLine();

        }
    }
}
