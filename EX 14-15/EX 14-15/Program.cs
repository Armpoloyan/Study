using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_14_15
{
    class Program
    {
        static void Main(string[] args)
        {


            //Խնդիր_14:
            // Ներածել n թիվը։ Արտածել yes, եթե այն հավասար է իր 
            //թվանշանների գումարի կրկնապատիկին, no՝ հակառակ դեպքում։

            Console.WriteLine("enter number N");
          
            int N= int.Parse(Console.ReadLine());
            int a = 0;

            for (int i = N; i>=1; i--)
            {
                a = N % 10 ;

            }
        }
    }
}
