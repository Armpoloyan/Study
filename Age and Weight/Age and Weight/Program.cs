using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_and_Weight
{
    class Program
    {
        static void Main(string[] args)
        {
            String x; // First Name

            String y; // Last Name

            Double z; // Weight

            ushort a; // Birth year

            String b; // sex 

            String resault1; // fat or thin


            ushort resault; //age


            Console.Write("Please enter Your First Name - ");

            x = (Console.ReadLine());

            Console.Write("Please enter Your Last Name - ");

            y = (Console.ReadLine());

            Console.Write("Please enter Your Weight - ");

            z = Convert.ToSingle(Console.ReadLine());

            Console.Write("Please enter Your Birth Year - ");

            a = Convert.ToUInt16(Console.ReadLine());

            Console.Write("Please enter Man or Woman - ");

            b = (Console.ReadLine());

            resault = Convert.ToUInt16(2018 - a);

            if (z >= 90)

            {

                resault1 = " Fat";

            }

            else { resault1 = "thin"; }

            Console.WriteLine("------------------------------------------------");

            Console.WriteLine($"Dear {x} {y} You are {resault} years old {resault1} {b}");
            Console.ReadKey();
        }
    }
}
