using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6_10._10._18
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("greq shexankyan koxmi erkerutyun@  ");
           int a =int.Parse(Console.ReadLine());
                           
           int b = 2*a;
           int x = 0;               
           for (int y = 0; y <= b/2; y++)
            {
                for (  ; x <= a; )
                {
                    Console.SetCursorPosition(5+a - x, 5+y);
                    Console.Write('*');
                    Console.SetCursorPosition(5+a + x, 5+y);
                    Console.Write('*');
                    x++;
                    break;
                }

            }
            int X = a;
            for (int y = b/2; y <= b ; y++)
            {
                for ( ; X >= 0; )
                {
                    Console.SetCursorPosition(5+a- X, 5+y);
                    Console.Write('*');
                    Console.SetCursorPosition(5+a + X,5+ y);
                    Console.Write('*');
                    X--;
                    break;
                }

            }
                                
            Console.ReadKey();
            
         }
    }
}
