using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x ;

            int y ;

            int resault;


            Console.Write("x = ");

            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("y = ");

            y = Convert.ToInt32(Console.ReadLine());

            resault = x + y;

            Console.WriteLine("x + y = " + resault);

            resault = x - y;

            Console.WriteLine("x - y = " + resault);

            resault = x * y;

            Console.WriteLine("x * y = " + resault);

            if (y != 0)

            {
                Double resault1;
                resault1 = 1.0*x / y;

                Console.WriteLine("x / y = " + resault1);


            }

            else { Console.WriteLine("chi kareli bajanel"); }



            Console.ReadKey();
        }
    }
}
