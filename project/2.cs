using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your age :");

            double a = Convert.ToDouble(Console.ReadLine());

            double year = 0;

            double mounth = 0;

            double week = 0;

            double day = 0;

            year = a / 365;

            mounth = (a % 365) / 30;

            week = ((a % 365) % 30) / 7;

            day = ((a % 365) % 30) % 7;

            Console.WriteLine("year {0} mounth {1} week {2} day {3}", year, mounth, week, day);


            Console.ReadKey();
        }
    }
}
