using Drones.Helpers;
using Drones.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Drones.Model
{
    public class Charger
    {
        private int _posx = Config.AIRSPACE_WIDTH / 2;
        private int _posy = Config.AIRSPACE_HEIGHT / 2;

        public Charger(int posx, int posy)
        {
            _posx = posx;
            _posy = posy;

        }

        public int Posx { get => _posx; private set => _posx = value; }
        public int Posy { get => _posy; private set => _posx = value; }
        public void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.DrawEllipse(Pens.Black, _posx, _posy, 20, 20);
        }
    }

}
