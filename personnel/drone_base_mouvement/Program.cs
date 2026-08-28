using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drone_base_mouvement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int posx = 0;
            int posy = 10;
            int batt = 50;
            Console.SetCursorPosition(posx, posy);
            Console.Write("x-0-x");
            while (batt > 0)
            {
                System.Threading.Thread.Sleep(200);
                posx += 1;
                Console.Clear();
                batt -= 2;
                Console.SetCursorPosition(posx, posy);
                Console.Write("x-0-x");
            }
            Console.SetCursorPosition(posx, posy);
            Console.Write("_____");

        }

    }

}

