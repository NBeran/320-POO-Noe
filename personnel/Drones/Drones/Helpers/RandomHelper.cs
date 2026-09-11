using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones.Helpers
{
    internal class RandomHelper
    {
        private static readonly Random alea = new Random();

        public static int next(int max) => alea.Next(max);
    }
}
