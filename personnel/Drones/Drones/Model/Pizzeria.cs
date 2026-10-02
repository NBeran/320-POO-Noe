using Drones.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Drones.Model
{
    internal class Pizzeria
    {
        private int _x;
        private int _y;
        private string _name;
        public static readonly int mindistance = 50;
        private static int height = 50;
        public string Name { get => _name; private set => _name = value; }
        public int Y { get => _y; private set => _y = value; }
        public int X { get => _x; private set => _x = value; }
        public Pizzeria(int x, int y, string name)
        {
            X = x;
            Y = y;
            Name = name;
        }

        public static void checkrange(List<Pizzeria> pizzerias)
        {
            foreach (Pizzeria p in pizzerias)
            {
                foreach (Pizzeria q in pizzerias)
                {
                    if (p.X - q.X > mindistance)
                    {
                        p.X += mindistance;
                    }
                    if (p.Y - q.Y > mindistance)
                    {
                        p.Y += mindistance;
                    }

                }
                if (p.X + height >= AirSpace.WIDTH)
                {
                    p.X = AirSpace.WIDTH - height;
                }
                if (p.Y + height >= AirSpace.HEIGHT)
                {
                    p.Y = AirSpace.WIDTH - height;
                }

            }
        }
        public void Render(BufferedGraphics drawingSpace)
        {
            Pen pen = new Pen(Color.Gray, 2);
            Brush brush = new SolidBrush(Color.Gray);
            drawingSpace.Graphics.FillRectangle(brush, X, Y, height, height);


        }

    }
}
