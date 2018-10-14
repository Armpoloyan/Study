using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercize26
{
    //Խնդիր_26:
    //Գտնել տրված բնական թվից մեծ և 2-ի աստիճան հանդիսացող ամենափոքր թիվը։


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any number ");
            long num = Convert.ToInt64(Console.ReadLine());

            int degree = 1;
            int n = 0;
            while (degree <= num )
            {
                degree = degree * 2;
                n++;
            }

            Console.WriteLine($"2^{n}={degree} > {num}");


            Console.ReadKey();
        }
    }
}
