using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tver
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Console.Write("Please enter the First number: ");

             int FirstNumber = Convert.ToInt32(Console.ReadLine());

             /* if (FirstNumber>=10 && FirstNumber < 100)

                 Console.WriteLine( "erknish");
              else if (FirstNumber < 0)
                 Console.WriteLine("bacasakan");
             else if (FirstNumber >= 100)
                 Console.WriteLine("mec 100 ic");*/

            /* Console.WriteLine((FirstNumber<0) ? "bacasakan" :( (FirstNumber>9 && FirstNumber<100) ? "erknish" : "mec 100 "));

             Console.ReadKey(); */

            /* for(int i=0; i<10;i++)
             {
                 string name = Console.ReadLine();
                 Console.WriteLine( name+"   Hi" );
             }*/
            int count = int.Parse(Console.ReadLine());

             for (int i = 0; i<count; i++)
			{
                Console.WriteLine($"i={i}");
                Console.WriteLine($"i*i={i*i}");
			}
    }
}
