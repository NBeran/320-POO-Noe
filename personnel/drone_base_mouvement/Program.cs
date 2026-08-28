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
            int posx2 = 0;
            const int posy = 10;
            const int posy2 = 20;
            int batt = 50;
            affichage(posx, posx2, posy, posy2, batt);
            while (batt > 0)
            {
                Thread.Sleep(100);
                changepos(ref posx, ref posx2, ref batt);
                Console.Clear();
                affichage(posx, posx2, posy, posy2, batt);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(posx, posy);
            Console.Write("_____");
            Console.SetCursorPosition(posx + 1, posy + 1);
            Console.Write(batt + "%");
            Console.SetCursorPosition(posx2, posy2);
            Console.Write("_____");
            Console.SetCursorPosition(posx2 + 1, posy2 + 1);
            Console.Write(batt + "%");
            Console.ReadLine();
        }

        static void affichage(int posx, int posx2, int posy, int posy2, int batt)
        {
            Console.SetCursorPosition(posx, posy);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("x-0-x");
            Console.SetCursorPosition(posx + 1, posy + 1);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(batt + "%");
            Console.SetCursorPosition(posx2, posy2);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("x-0-x");
            Console.SetCursorPosition(posx2 + 1, posy2 + 1);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(batt + "%");
        }

        static void changepos(ref int posx, ref int posx2, ref int batt)
        {
            batt -= 2;
            posx += 1;
            posx2 += 2;
        }

    }

}

