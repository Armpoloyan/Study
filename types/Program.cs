using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace types
{
    class Program
    {
        static void Main(string[] args)
        {
            int x ;

            int y ;

            int resault;

           
            Console.WriteLine("x = " + x);

            Console.WriteLine("y = " + y);

            Console.WriteLine();

            resault = x + y;

            Console.WriteLine("x + y = " + resault);

            resault = x - y;

            Console.WriteLine("x - y = " + resault);

            resault = x * y;

            Console.WriteLine("x * y = " + resault);

            if (y != 0)

            {

                resault = x / y;

                Console.WriteLine("x / y = " + resault);
            }

            else { Console.WriteLine("chi kareli bajanel"); }

 
            Console.ReadKey();
        }
    }
}
