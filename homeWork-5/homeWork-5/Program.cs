using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            //Խնդիր_2:
            //Տրված են K և N(N > 0) ամբողջ թվերը։ N անգամ արտածել K թիվը։
            Console.Write("number N is  ");

            int N = int.Parse(Console.ReadLine());

            Console.Write("number K is  ");

            int K = int.Parse(Console.ReadLine());

            for (int i = 0; i <N; i++)
            {
                Console.WriteLine(K);
            }
            Console.ReadKey();

            */
            /*


           Console.WriteLine("--------------------------------------");

           //Խնդիր_3:
           //Ներածել n միանիշ թիվը։ Արտածել n-ին չգերազանցող թվանշանները։

           Console.Write("greq mianish tiv  ");

           int N = int.Parse(Console.ReadLine());

           if (N > 0 && N < 10)

             for (int i = 1; i < N; i++)
             {
               Console.WriteLine(i);
             }
           else Console.WriteLine("greq mianish tiv");

           Console.ReadKey();

           */
            /*
             
            Console.WriteLine("--------------------------------------");
            //Խնդիր_4:
            // Ներածել n բնական թիվը։ 
            //Արտածել n–ի 1–ից մինչև 9 աստիճանների արժեքները։

            Console.Write("greq bnakan  tiv  ");

            int N = int.Parse(Console.ReadLine());

            

                for (int i = 1; i <= 9; i++)
                {
                    Console.WriteLine($"{N}^{i} = {Math.Pow(N,i)} ");
                }
           
            Console.ReadKey();

           */
            /*
              Console.WriteLine("--------------------------------------");
              //Խնդիր_5:
              //Հաշվել տրված բնական թվին չգերազանցող զույգ թվերի գումարը՝ 
              //առանց զույգությունը ստուգելու։

              Console.WriteLine("greq bnakan tiv");
              int N = int.Parse(Console.ReadLine());
              int Sum=0;
              for (int i = 2; i < N; i+=2)
              {
                  Sum += i;
              }
              Console.WriteLine($"zuyg bnakan tveri gmar = {Sum}");

              Console.ReadKey(); 
              */
            /*


          Console.WriteLine("--------------------------------------");
          //Խնդիր_6:
          //Տրված են A և B(A < B) ամբողջ թվերը։ 
          //Արտածել աճման կարգով[A, B] հատվածին պատկանող ամբողջ թվերը,
          //ապա նաև նրանց քանակը։

          Console.WriteLine("greq A amboxg tiv");
          int A = int.Parse(Console.ReadLine());
          Console.WriteLine("greq B amboxg tiv");
          int B = int.Parse(Console.ReadLine());

          if( A < B)
              for (int i = A; i <= B; i++)
              {
                  Console.WriteLine($"{i}");
              }

          else Console.WriteLine("B petq e mec lini A-ic ");
          int C = (B - A) + 1;
          Console.WriteLine($"tveri qanak@ klini {C}");
          Console.ReadKey();


         */
            /*


               Console.WriteLine("--------------------------------------");
               //Խնդիր_7:
               //Տրված են A և B(A < B) ամբողջ թվերը։ 
               //Գտնել[A, B] հատվածին պատկանող բոլոր ամբողջ թվերի գումարը։

               Console.WriteLine("greq A amboxg tiv");
               int A = int.Parse(Console.ReadLine());
               Console.WriteLine("greq B amboxg tiv");
               int B = int.Parse(Console.ReadLine());
               int Sum = 0;
               if (A < B)
                   for (int i = A; i <= B; i++)
                   {
                       Sum +=i;
                   }

               else Console.WriteLine("B petq e mec lini A-ic ");
               Console.WriteLine($"tveri gumar@ klini {Sum}");
               Console.ReadKey();


             */


            Console.WriteLine("--------------------------------------");
            //Խնդիր_8:
            //Տրված են A և B(A < B) ամբողջ թվերը։ 
            //Գտնել[A, B] հատվածին պատկանող 3 - ին պատիկ առաջին թիվը։

            Console.WriteLine("greq A amboxg tiv");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("greq B amboxg tiv");
            int B = int.Parse(Console.ReadLine());
            if (A >= B)
            Console.WriteLine("B petq e mec lini A-ic ");

               bool flag = false;
                string Bajanarar = "Chka 3-i bajanvox tiv";
                        
               for (int i = A; i <= B && !flag ; i++)
                { if
                   (i % 3 == 0)
                    {
                       Bajanarar = $"3-i bajanvox tiv@ klini {i}";
                       flag = true;
                    }

                }


            Console.WriteLine($"{Bajanarar}");
            Console.ReadKey();


        }

    }
}
