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
            drone drone1 = new drone(0, 3, 70, 3, 2);
            drone drone2 = new drone(0, 6, 25, 8, 2);
            drone drone3 = new drone(90, 9, 1, 1, 1);
            drone drone4 = new drone(0, 12, 100, 1, 1);
            while (drone1.Batterie > 0 || drone2.Batterie > 0 || drone3.Batterie > 0 || drone4.Batterie > 0)
            {
                Thread.Sleep(100);
                Console.Clear();
                drone1.Move();
                drone1.Draw();
                drone2.Move();
                drone2.Draw();
                drone3.Move();
                drone3.Draw();
                drone4.Move();
                drone4.Draw();
            }

            Console.ReadLine();




        }
    }

}

