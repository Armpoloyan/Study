using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercize24
{
    //Խնդիր_24:
    //Պարզել, հանդիսանում է, արդյոք, տրված թիվը 3-ի աստիճան։
    class Program
    {
    /// <summary>
    /// 
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
        static int PowerOf3(int number)
        {
            int power = 0;
            int n = 0;
            int N = number;
            for (; number > 0 && number % 3 == 0;)
            {
                number /= 3;
                n++;
            }
            if (number == 1)
            {
                power = n;
            }

            else
            {
                Console.WriteLine("not power 3");
            }

            return power;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("please enter number  ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            int power = PowerOf3(inputNumber);
            Console.WriteLine($"{inputNumber} = 3 ^ {power}.");
            Console.ReadKey();
        }
    }
}
