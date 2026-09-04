using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace drone_base_mouvement
{
    public class drone
    {
        private int _posx;
        private int _posy;
        private int _batterie;
        private int _vitesse;
        private int _depense;

        public int Batterie { get => _batterie; }

        public drone(int posx, int posy, int batterie, int vitesse, int depense)
        {
            _posx = posx;
            _posy = posy;
            _batterie = batterie;
            _vitesse = vitesse;
            _depense = depense;
        }
        public void Move()
        {
            if (_batterie <= 0)
            {
                _batterie = 0;
                return;
            }
            _posx += _vitesse;
            _batterie -= _depense;


        }
        public void Draw()
        {
            Console.SetCursorPosition(_posx, _posy);
            if (_batterie > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("x-0-x");
            }
            else
            {
                Console.Write("_____");
            }
            Console.ResetColor();
            Console.SetCursorPosition(_posx + 1, _posy - 1);
            Console.Write(Batterie + "%");
        }
    }
}
