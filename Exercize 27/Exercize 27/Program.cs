using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercize_27
{ //Խնդիր_27:
  // Ներածել n բնական թիվը և տպել այդ թիվը՝ 
  // շրջելով և նրա ամեն մի թվանշանից հետո ավելացնելով 0 (օրինակ՝ 125 - 502010):
    class Program
    {
 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number ");
          
            PrintRevNumWitZero(45623);
            Console.ReadKey();
        }
                              
        static void PrintRevNumWitZero(int n)
        {
            string t = n.ToString();
                  

            for (int i = t.Length-1; i >=0 ; i--)
            {
                Console.Write(t[i] + "0");
            }
            
        }
        
    }
}
