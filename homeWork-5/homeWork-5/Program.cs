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

              
               string Bajanarar = "Chka 3-i bajanvox tiv";

              for (int i = A; i <= B  ; i++)
               { if
                  (i % 3 == 0)
                   {
                      Bajanarar = $"3-i bajanvox tiv@ klini {i}";
                      break;
                   }

               }
               Console.WriteLine($"{Bajanarar}");
               Console.ReadKey();


            
            /*


            //Խնդիր_9:
            // Տրված է N բնական թիվը։ 
            //Հաշվել 1 + 1 / 2 + 1 / 3 + … +1 / N գումարը(այն իրական թիվ է)։

            Console.WriteLine("greq bnakan tiv");
            int N = int.Parse(Console.ReadLine());
            Double Sum =0 ;

            for (int i = 1; i <= N; i++)
            {
                Sum += 1.0/i;
            }

            Console.WriteLine($"patasxan@ klini = {Sum}");
            Console.ReadKey();

            */
            /*

            //Խնդիր_10:
            //Տրված է N բնական թիվը։ 
            //Հաշվել N2 +(N + 1)2 + (N + 2)2 + … +(2·N)2 գումարը։

            Console.WriteLine("greq bnakan tiv");
            int N = int.Parse(Console.ReadLine());
            Double Sum = 0;

            for (int i = 0; i <= N; i++)
            {
                Sum += Math.Pow(N + i, 2);
            }

            Console.WriteLine($"patasxan@ klini = {Sum}");
            Console.ReadKey();


            */
            /*


            //Խնդիր_11:
            //Տրված է N բնական թիվը։ 
            //Հաշվել 1.1 · 1.2 · 1.3 · … արտադրյալը(արտադրիչների քանակը N է)։

            Console.WriteLine("greq bnakan tiv");
            int N = int.Parse(Console.ReadLine());
            Double prod = 1;

            for (Double i = 1.1; i < 1.1+N*0.1; i+=0.1)
            {
                prod *= i;
            }

            Console.WriteLine($"patasxan@ klini = {prod}");
            Console.ReadKey();
            */

            /*

            //Խնդիր_12:
            //Տրված է N բնական թիվը։ 
            //Հաշվել 1.1 – 1.2 + 1.3 – … արտահայտության արժեքը։
            //Նշանափոխ գումարելիների քանակը N է։
            //Պայմանական(if) օպերատոր չօգտագործել։

            Console.WriteLine("greq bnakan tiv");
            int N = int.Parse(Console.ReadLine());
            Double prod = 1;
            int pow = 2;
            for (Double i = 1.1; i < (1.1 + N * 0.1); i += 0.1)
            {
                prod += Math.Pow(-1, pow++) * i;
            }


            Console.WriteLine($"patasxan@ klini = {prod}");
            Console.ReadKey();


            */
            /*
             
              
            // Խնդիր_13:
            // Տրված է N բնական թիվը։ Հաշվել այդ թվի քառակուսին՝ 
            //օգտագործելով հետևյալ բանաձևը.N2 = 1 + 3 + 5 + … +(2 * N – 1).
            // Հերթական գումարելին ավելացնելիս արտածել գումարի ընթացիկ արժեքը 
            //(արդյունքում կարտածվեն 1 - ից մինչև N բոլոր թվերի քառակուսիները)։

            Console.Write ("greq bnakan tiv   ");
            int N = int.Parse(Console.ReadLine());
            Double Sqrt =0;

            for (int i = 1; i <= N; i++)
            {
                Sqrt += 2 * i - 1;
                Console.WriteLine($"{i} -i qarakusin = {Sqrt}");       
            }

                        Console.ReadKey();
                        */
        }

    }
}
