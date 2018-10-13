using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercize20
{
    //Խնդիր_20:
    // Գտնել տրված թվի ամենամեծ և ամենափոքր թվանշանների տարբերության քառակուսին։

    class Program
    {
        static int DifferenceDigit(int number)
        {
            int difference = 0;
            int max = 0, min = 9, t = 0;
            for (; number > 0; number /= 10)
            {
                t = number % 10;
                min = t < min ? t : min;
                max = t > max ? t : max;
                difference = max - min;
            }
            return difference;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("please enter number  ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            int difference = DifferenceDigit(inputNumber);
            Console.WriteLine($"(max - min)^2 = { difference* difference}.");
            Console.ReadKey();
        }
    }
}