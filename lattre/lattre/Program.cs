using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lattre
{
    class Program
    {
        static int curent_x = 0;
        static int curent_y = 0;
        static void Main(string[] args)
        {
            A();
            Console.ReadKey();
        }

        static void Write(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write('#');
        }

        static void H()
        {
            Write(curent_x + 0, curent_y + 0);
            Write(curent_x + 3, curent_y + 0);
            Write(curent_x + 0, curent_y + 1);
            Write(curent_x + 3, curent_y + 1);
            Write(curent_x + 0, curent_y + 2);
            Write(curent_x + 3, curent_y + 2);
            Write(curent_x + 0, curent_y + 3);
            Write(curent_x + 1, curent_y + 3);
            Write(curent_x + 2, curent_y + 3);
            Write(curent_x + 3, curent_y + 3);
            Write(curent_x + 0, curent_y + 4);
            Write(curent_x + 3, curent_y + 4);
            Write(curent_x + 0, curent_y + 5);
            Write(curent_x + 3, curent_y + 5);
            Write(curent_x + 0, curent_y + 6);
            Write(curent_x + 3, curent_y + 6);

            curent_x += 4;
            curent_y = 0;
            Console.SetCursorPosition(curent_x, curent_y);
        }
        static void I()
        {
            Write(curent_x + 0, curent_y + 0);
            Write(curent_x + 0, curent_y + 1);
            Write(curent_x + 0, curent_y + 2);
            Write(curent_x + 0, curent_y + 3);
            Write(curent_x + 0, curent_y + 4);
            Write(curent_x + 0, curent_y + 5);
            Write(curent_x + 0, curent_y + 6);


            curent_x += 4;
            curent_y = 0;
            Console.SetCursorPosition(curent_x, curent_y);
        }
        static void J()
        {
            Write(curent_x + 3, curent_y + 0);
            Write(curent_x + 3, curent_y + 1);
            Write(curent_x + 3, curent_y + 2);
            Write(curent_x + 3, curent_y + 3);
            Write(curent_x + 0, curent_y + 4);
            Write(curent_x + 3, curent_y + 4);
            Write(curent_x + 0, curent_y + 5);
            Write(curent_x + 3, curent_y + 5);
            Write(curent_x + 1, curent_y + 6);
            Write(curent_x + 2, curent_y + 6);

            curent_x += 4;
            curent_y = 0;
            Console.SetCursorPosition(curent_x, curent_y);


        }
        static void K()
        {
            Write(curent_x + 0, curent_y + 0);
            Write(curent_x + 3, curent_y + 0);
            Write(curent_x + 0, curent_y + 1);
            Write(curent_x + 3, curent_y + 1);
            Write(curent_x + 0, curent_y + 2);
            Write(curent_x + 2, curent_y + 2);
            Write(curent_x + 0, curent_y + 3);
            Write(curent_x + 1, curent_y + 3);
            Write(curent_x + 0, curent_y + 4);
            Write(curent_x + 2, curent_y + 4);
            Write(curent_x + 0, curent_y + 5);
            Write(curent_x + 3, curent_y + 5);
            Write(curent_x + 0, curent_y + 6);
            Write(curent_x + 3, curent_y + 6);

            curent_x += 4;
            curent_y = 0;
            Console.SetCursorPosition(curent_x, curent_y);
        }
        static void L()
        {
            Write(curent_x + 0, curent_y + 0);
            Write(curent_x + 0, curent_y + 1);
            Write(curent_x + 0, curent_y + 2);
            Write(curent_x + 0, curent_y + 3);
            Write(curent_x + 0, curent_y + 4);
            Write(curent_x + 0, curent_y + 5);
            Write(curent_x + 0, curent_y + 6);
            Write(curent_x + 1, curent_y + 6);
            Write(curent_x + 2, curent_y + 6);
            Write(curent_x + 3, curent_y + 6);

            curent_x += 4;
            curent_y = 0;
            Console.SetCursorPosition(curent_x, curent_y);
        }
        static void M()
        {
            Write(curent_x + 0, curent_y + 0);
            Write(curent_x + 6, curent_y + 0);
            Write(curent_x + 0, curent_y + 1);
            Write(curent_x + 6, curent_y + 1);
            Write(curent_x + 0, curent_y + 2);
            Write(curent_x + 1, curent_y + 2);
            Write(curent_x + 5, curent_y + 2);
            Write(curent_x + 6, curent_y + 2);
            Write(curent_x + 0, curent_y + 3);
            Write(curent_x + 2, curent_y + 3);
            Write(curent_x + 4, curent_y + 3);
            Write(curent_x + 6, curent_y + 3);
            Write(curent_x + 0, curent_y + 4);
            Write(curent_x + 3, curent_y + 4);
            Write(curent_x + 6, curent_y + 4);
            Write(curent_x + 0, curent_y + 5);
            Write(curent_x + 6, curent_y + 5);
            Write(curent_x + 0, curent_y + 6);
            Write(curent_x + 6, curent_y + 6);

            curent_x += 4;
            curent_y = 0;
            Console.SetCursorPosition(curent_x, curent_y);
        }
        static void N()
        {
            Write(curent_x + 0, curent_y + 0);
            Write(curent_x + 4, curent_y + 0);
            Write(curent_x + 0, curent_y + 1);
            Write(curent_x + 4, curent_y + 1);
            Write(curent_x + 0, curent_y + 2);
            Write(curent_x + 1, curent_y + 2);
            Write(curent_x + 4, curent_y + 2);
            Write(curent_x + 0, curent_y + 3);
            Write(curent_x + 2, curent_y + 3);
            Write(curent_x + 4, curent_y + 3);
            Write(curent_x + 0, curent_y + 4);
            Write(curent_x + 3, curent_y + 4);
            Write(curent_x + 4, curent_y + 4);
            Write(curent_x + 0, curent_y + 5);
            Write(curent_x + 4, curent_y + 5);
            Write(curent_x + 0, curent_y + 6);
            Write(curent_x + 4, curent_y + 6);

            curent_x += 4;
            curent_y = 0;
            Console.SetCursorPosition(curent_x, curent_y);
        }
        static void Z()
        {
            Write(curent_x + 0, curent_y + 0);
            Write(curent_x + 1, curent_y + 0);
            Write(curent_x + 2, curent_y + 0);
            Write(curent_x + 3, curent_y + 0);
            Write(curent_x + 4, curent_y + 0);
            Write(curent_x + 4, curent_y + 1);
            Write(curent_x + 3, curent_y + 2);
            Write(curent_x + 2, curent_y + 3);
            Write(curent_x + 1, curent_y + 4);
            Write(curent_x + 0, curent_y + 5);
            Write(curent_x + 0, curent_y + 6);
            Write(curent_x + 1, curent_y + 6);
            Write(curent_x + 2, curent_y + 6);
            Write(curent_x + 3, curent_y + 6);
            Write(curent_x + 4, curent_y + 6);
       
            curent_x += 5;
            curent_y = 0;
            Console.SetCursorPosition(curent_x, curent_y);
        }

        static void D()
        {
            Write(curent_x + 0, curent_y + 6);


            curent_x += 1;
            curent_y = 0;
            Console.SetCursorPosition(curent_x, curent_y);
        }
    static void S()
    {
        Write(curent_x + 0, curent_y + 0);
        Write(curent_x + 0, curent_y + 1);
        Write(curent_x + 0, curent_y + 2);
        Write(curent_x + 0, curent_y + 3);
        Write(curent_x + 0, curent_y + 4);
        Write(curent_x + 0, curent_y + 6);


        curent_x += 1;
        curent_y = 0;
        Console.SetCursorPosition(curent_x, curent_y);
    }
    static void A()
    {
        Write(curent_x + 0, curent_y + 0);
        Write(curent_x + 0, curent_y + 1);
        Write(curent_x + 0, curent_y + 2);
        Write(curent_x + 0, curent_y + 3);
        Write(curent_x + 0, curent_y + 4);
        Write(curent_x + 0, curent_y + 6);


        curent_x += 1;
        curent_y = 0;
        Console.SetCursorPosition(curent_x, curent_y);
    }
        static void V()
    {
        Write(curent_x + 1, curent_y + 0);
        Write(curent_x + 2, curent_y + 0);
        Write(curent_x + 3, curent_y + 0);
        Write(curent_x + 3, curent_y + 0);
        Write(curent_x + 0, curent_y + 1);
        Write(curent_x + 4, curent_y + 1);
        Write(curent_x + 4, curent_y + 2);
        Write(curent_x + 3, curent_y + 3);
        Write(curent_x + 2, curent_y + 4);
        Write(curent_x + 2, curent_y + 6);

        curent_x += 1;
        curent_y = 0;
        Console.SetCursorPosition(curent_x, curent_y);
    }

}
}
