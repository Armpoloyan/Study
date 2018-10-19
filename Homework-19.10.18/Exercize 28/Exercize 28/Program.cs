using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercize_28
{ 
    //Խնդիր_28:
    //Ներածել n թիվը։ Արտածել yes,
    // եթե այն հավասար է իր թվանշանների գումարի կրկնապատիկին, 
    //no՝ հակառակ դեպքում։


    class Program
    {
        public static int N { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number ");
            int Num = int.Parse(Console.ReadLine());
            if (Num == 2 * PrintNum(Num)) Console.WriteLine("YES");
            else Console.WriteLine("NO");
            Console.ReadKey();
        }
        static int PrintNum(int n)
        {
            string t = n.ToString();
            int Sum = 0;
            while (n > 0)
                for (int i = 0; i < t.Length; i++)
                {
                    int[] Array = new int[t.Length];
                    Array[i] = n % 10;
                    n /= 10;
                    Sum += Array[i];
                }
            return Sum;
        }
    }
}
