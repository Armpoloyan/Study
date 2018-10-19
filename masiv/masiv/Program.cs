using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masiv
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] masiv = new int[10];
           
            for ( int i = 0; i < 10;  i++)
            {
                masiv[i] = i * 2;
             Console.WriteLine(masiv[i]);
            }
            Console.ReadKey();
        }
        
    }
}
