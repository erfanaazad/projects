using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)

        {

            Console.Write("power2 & power3 of:");

            int a = Convert.ToInt32(Console.ReadLine());

            int pow2 = power2(a);

            int pow3 = power3(a);

            Console.WriteLine("power 2{0} and 3{1}",pow2,pow3);

            Console.ReadKey();
        }

        private static int power2(int a)

        {

            int b = a * a;

            return b;

        }

        private static int power3(int a)

        {

            int b = a * a * a;

            return b;

   
        }
    }

}
