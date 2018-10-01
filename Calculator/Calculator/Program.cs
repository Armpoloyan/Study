using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.Write("Please enter the First number: ");

            Double FirstNumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter the operation type: ");

            string operationType = Console.ReadLine();

            Console.Write("Please enter the Second number: ");

            double SecondNumber = Convert.ToDouble(Console.ReadLine());

            

            Double result= 0;

            if (operationType == "+")

            {
                result = FirstNumber + SecondNumber;

            }
            else if (operationType == "-")
            {

                result = FirstNumber - SecondNumber;
            }

            else if (operationType == "*")

            {

                result = FirstNumber * SecondNumber;

            }

            else if (operationType == "/")

            {

                result = FirstNumber / SecondNumber;

            }

            else if (operationType == "%")

            {

                result = FirstNumber % SecondNumber;

            }

            else if (operationType == "^")

            {

                result = Math.Pow(FirstNumber, SecondNumber);

            }

                      
            else

            {
                Console.WriteLine("Please enter a valid operation type");
            }
            Console.WriteLine($"Your result is: {Math.Abs(result)}");
            Console.ReadKey();

        }
    }
}

                                                  
