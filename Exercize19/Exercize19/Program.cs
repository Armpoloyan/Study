using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercize19
{
    //Խնդիր_19:
    //Հաշվել տրված թվի 7-ից փոքր զույգ թվանշանների արտադրյալը։
    class Program
    {
        static int ProductDigit(int number)
        {

            int product=1;
            for (int i = 0; (int)(number / Math.Pow(10, i)) != 0; i++)
            {
                int Digit = (int)(number / Math.Pow(10, i) % 10);
                if (Digit % 2 == 0 && Digit < 7)
                {
                    product *= Digit;
                }
            }
            return product;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("please enter number  ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            int prodctDigit = ProductDigit(inputNumber);
            Console.WriteLine($"The product digit  {prodctDigit}.");
            Console.ReadKey();

        }
    }
}