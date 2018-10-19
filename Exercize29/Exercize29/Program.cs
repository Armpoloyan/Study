using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercize_29
{
  //Խնդիր_29:
  //Եռանիշ թվի առաջին թվանշանը ջնջել։ Եթե ստացված թիվը բազմապատկվի 7-ով,
  // կստացվի սկզբնական թիվը։ Գտնել այդպիսի թվերը։


    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i < 1000; i++)
            {
                if (i == i % 100 * 7)
                    Console.WriteLine(i);
            }

            Console.ReadKey();
        
            
            
        }
    }
}

