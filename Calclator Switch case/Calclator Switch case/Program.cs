using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calclator_Switch_case
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Please enter the First number: ");

            Double FirstNumber = Convert.ToDouble(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Please enter the operation type: ");

            string operationType = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Please enter the Second number: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            double SecondNumber = double.Parse(Console.ReadLine());

            Double result = 0;

            Boolean flag = true;
                       
            switch (operationType )
            {
                case "+"://if operation =="+"
                    result = FirstNumber + SecondNumber;
                    break;
                case "-"://if operation =="-"
                    result = FirstNumber - SecondNumber; 
                    break;
                case "*"://if operation =="*"
                    result = FirstNumber * SecondNumber;
                    break;
                case "/"://if operation =="/"
                    result = FirstNumber / SecondNumber;
                    break;
                default:
                   flag=false;
                    break;
                  
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(flag ? $"{FirstNumber}{operationType}{result}" : "Wrong operation" );
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.ReadKey();
        }
    }
}
