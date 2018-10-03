using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpperLettre
{
    class Program
    {
        static void Main(string[] args)
        {
            String upperLetrre;
            Console.WriteLine("please enter lattre   ");

            upperLetrre = Console.ReadLine();
            Console.WriteLine(upperLetrre.ToUpper());
            Console.ReadKey();
        }
    }
}
