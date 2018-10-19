using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercize30
{
    //Խնդիր_30:
    //Գտնել բոլոր այն քառանիշ թվերը, որոնցում կրկնվող թվանշան չկա և 
    //որոնցում առաջին և վերջին երկու թվանշաններից կազմված թվերի 
    //տարբերությունը հավասար է այդ թվի թվանշանների գումարին։
    class Program
    {
        static void Main(string[] args)
        {

            int[] Array = new int[4];
            for (int n = 1000; n < 10000; n++)
            {
                for (int i = 3; i >= 0; i--)
                {
                    
                    Array[i] = n % 10;
                    n /= 10;
                    Console.WriteLine(Array[i]);
                   
                }
                if (Array[0] != Array[1] || Array[1] != Array[2] ||Array[2]!=Array[3]) 
                   int RightPart = Array[0] * 10 + Array[1];
                   int LeftPart = Array[2] * 10 + Array[3];
                if(RightPart-LeftPart)
                
            }

                                    
        }
    }
}
