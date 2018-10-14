using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercize25
{
    //Խնդիր_25:
    //Տրված n>0 ամբողջ թվի համար հաշվել 2-ի ամենամեծ աստիճանը,
    //որը չի գերազանցում n-ը։
    class Program
    {
      
        static void Main(string[] args)
        {
            Console.WriteLine("enter any number ");
            long num = Convert.ToInt64(Console.ReadLine());

            int degree = 1;
            int n = 0;
            while (degree<num/2)
            {
                degree = degree*2;
                n++;
            }

           Console.WriteLine($"2^{n}={degree} < {num}");
            

            Console.ReadKey();
        
        }
    }
}
