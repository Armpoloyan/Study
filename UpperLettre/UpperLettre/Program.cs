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
            String upperLettre;
            Console.WriteLine("please enter lettre   ");
            upperLettre = Console.ReadLine();
            Console.WriteLine(upperLettre.ToUpper());
            Console.ReadKey();
        }
    }
}
