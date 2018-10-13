using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exesize_17
{
   
       
            //Խնդիր_17:
     //Գտնել տրված թվի կենտ թվանշաններից ամենափոքրը։

           
    class Program
        {
           /// <summary>
           /// 
           /// </summary>
           /// <param name="number"></param>
           /// <returns></returns>
            static int Smalldigit (int number)
            {
                int minDigit = 9;
                int count = 0;
                for (int i = 0; (int)(number / Math.Pow(10, i)) != 0; i++)
                {
                    int Digit = (int)(number / Math.Pow(10, i) % 10);
                if (Digit % 2 != 0 && Digit < minDigit)
                   {
                    minDigit = Digit;
                    count++;
                   }
                }
            return (count == 0) ? 0 : minDigit;
            }
               
            static void Main(string[] args)
            {
                Console.WriteLine("please enter number  ");
                int inputNumber = Convert.ToInt32(Console.ReadLine());
                int smallDigit = Smalldigit(inputNumber);
            Console.WriteLine(smallDigit == 0 ? $"No  digit " : $"The small digit  {smallDigit}.");
            Console.ReadKey();
            }
    }
}
