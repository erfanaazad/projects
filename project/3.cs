using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" enter your cash : ");

            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("  enter persentage : ");

            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" cash that you want : ");

            int c = Convert.ToInt32(Console.ReadLine());

                        if (c > a)
            {
                                if (b < 100 && b > 0)
                {

                    int mounth_profit = ((a * b) / 100) / 12;

                    double full_profit = c - a;

                    double mo = full_profit / mounth_profit;

                    Console.WriteLine("{0} mounth", mo);

                }
                else
                {

                    Console.WriteLine("wrong value");
                }

            }
            else
            {
                                Console.WriteLine("wrong value");
                Console.ReadLine();

            }
        }
    }
}
