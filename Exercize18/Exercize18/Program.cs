using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercize18
{
    // Խնդիր_18:
     //Հաշվել տրված թվի 4-ից մեծ կենտ թվանշանների գումարը։
    class Program
    {
        static int Sumdigit(int number)
        {
         
            int sum = 0;
            for (int i = 0; (int)(number / Math.Pow(10, i)) != 0; i++)
            {
                int Digit = (int)(number / Math.Pow(10, i) % 10);
                if (Digit % 2 != 0 && Digit > 4)
                {
                    sum += Digit;
                }
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("please enter number  ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            int sumDigit = Sumdigit(inputNumber);
            Console.WriteLine( $"The sum digit  {sumDigit}.");
            Console.ReadKey();
          
        }
    }
}
