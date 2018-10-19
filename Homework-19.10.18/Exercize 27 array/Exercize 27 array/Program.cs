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
            int N = int.Parse(Console.ReadLine());
            PrintRevNumWitZero(N);
            Console.ReadKey();
        }

        static void PrintRevNumWitZero(int n)
        {
            string t = n.ToString();

            while (n>0)

            for (int i = 0 ; i < t.Length; i++)
            {
                    int[] Array = new int[t.Length];
                    Array[i] = n % 10;
                    n /= 10;
                Console.Write(Array[i] + "0");
            }

        }

    }
}
