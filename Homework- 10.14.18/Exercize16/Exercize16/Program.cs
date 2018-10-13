using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercize16
//Խնդիր_16:
//Հաշվել տրված բնական թվի թվանշանների գումարը,
// քանակը, 
//արտադրյալը։

{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static int Sum(int number)
        {
            int sum = 0;
            for (int i = 0; (int)(number / Math.Pow(10, i)) != 0; i++)
            {
                sum += (int)(number / Math.Pow(10, i) % 10);
            }
            return sum;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static int Count(int number)
        {
            int count = 0;
            for (int i = 0; (int)(number / Math.Pow(10, i)) != 0; i++)
            {
                count++;
            }
            return count;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static int Product(int number)
        {
            int product = 1;
            for (int i = 0; (int)(number / Math.Pow(10, i)) != 0; i++)
            {
                product *= (int)(number / Math.Pow(10, i) % 10);
            }
            return product;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("please enter number  ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            int sum = Sum(inputNumber);
            int count = Count(inputNumber);
            int product = Product(inputNumber);
            Console.WriteLine($"sum: {sum}\ncount: {count}\nproduct: {product}");
            Console.ReadKey();

        }

    }
}
