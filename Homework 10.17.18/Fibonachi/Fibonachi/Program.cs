using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonachi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please enter Fibonachi nmber = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}-Fibonacci number is {1}", n,Fibonachi(n)); ;
            Console.ReadKey();

        }
        static int Fibonachi( int n)
        {
            if (n <= 1)
                return 1;
            else return (Fibonachi(n - 1) + Fibonachi(n - 2));
        }
    }
}
