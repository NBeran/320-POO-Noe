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
            Console.SetCursorPosition(posx, posy);
            Console.Write("x-0-x");
            Console.SetCursorPosition(posx + 1, posy + 1);
            Console.Write(batt + "%");
            while (batt > 0)
            {
                Thread.Sleep(100);
                posx += 1;
                Console.Clear();
                batt -= 2;
                affichage(posx, posy, batt);
            }
            Console.SetCursorPosition(posx, posy);
            Console.Write("_____");
            Console.ReadLine();
        }
        static void affichage(int posx, int posy, int batt){
                Console.SetCursorPosition(posx, posy);
                Console.Write("x-0-x");
                Console.SetCursorPosition(posx + 1, posy + 1);
                Console.Write(batt + "%");
            }


}

}

