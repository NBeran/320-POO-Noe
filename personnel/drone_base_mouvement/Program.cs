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
            Drone drone1 = new Drone(0, 5, 70, 3, 2);
            Drone drone2 = new Drone(0, 10, 25, 8, 2);
            Drone drone3 = new Drone(90, 15, 10, 1, 1);
            Drone drone4 = new Drone(0, 20, 100, 1, 1);
            List<Drone> drones = new List<Drone> {drone1, drone2, drone3, drone4};

            while (OneIsAlive)
            {
                Thread.Sleep(100);
                Console.Clear();
                foreach (Drone drone in drones) 
                {
                    drone.Move();
                    drone.Draw();
                }
            }

            Console.ReadLine();

        }
        static bool OneIsAlive()
        {
            foreach
        }
    }

}

