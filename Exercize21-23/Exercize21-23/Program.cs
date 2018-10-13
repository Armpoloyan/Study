using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercize21_23
    
{
    // Խնդիր_21:
    //Արտածել տրված թվի բոլոր բաժանարարները։
    //Խնդիր_22:
    //Հաշվել տրված թվի բոլոր բաժանարարների գումարը։
    //Խնդիր_23:
    //Հաշվել տրված թվի բոլոր բաժանարարների գումարի և դրանց քանակի քանորդը։


    class Program
    {
        static int Divisor(int number)
        {

            int sum = 0;


            for (int i = 1; i <= number; i++)
            {

                if (number % i == 0)
                {
                    Console.WriteLine(i);
                    sum += i;
                    
                }
            }
            return sum  ;
           
        }

        static int Count(int number)
        {

            
            int count = 0;
            for (int i = 1; i <= number; i++)
            {

                if (number % i == 0)
                {
                 count++;
                   
                }
            }
            return count;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("please enter number  ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            int sum = Divisor(inputNumber);
            int count= Count(inputNumber);

            Console.WriteLine($"The sum of divisors is  {sum}.");
            Console.WriteLine($"The sum / count is  {sum / count}.");
            Console.ReadKey();

        }
    }
}
