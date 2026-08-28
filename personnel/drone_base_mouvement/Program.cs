using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace drone_base_mouvement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int posx = 0;
            const int posy = 10;
            int batt = 50;
            affichage(posx, posy, batt);
            while (batt > 0)
            {
                Thread.Sleep(100);
                changepos(ref posx, ref batt);
                Console.Clear();
                affichage(posx, posy, batt);
            }
            Console.SetCursorPosition(posx, posy);
            Console.Write("_____");
            Console.ReadLine();
        }

        static void affichage(int posx, int posy, int batt)
        {
            Console.SetCursorPosition(posx, posy);
            Console.Write("x-0-x");
            Console.SetCursorPosition(posx + 1, posy + 1);
            Console.Write(batt + "%");
        }

        static int changepos(ref int posx, ref int batt)
        {
            batt -= 2;
            posx += 1;
            return batt;
        }

    }

}

