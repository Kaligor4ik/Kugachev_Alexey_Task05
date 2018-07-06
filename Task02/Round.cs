using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Round
    {
        private readonly int x;
        private readonly int y;
        private readonly int r;

        public Round(int x, int y, int r)
        {
            this.x = x;
            this.y = y;
            this.r = Math.Abs(r);
        }

        public int X => x;
        public int Y => y;
        public int R => r;
        public virtual double L => Math.Round(Math.PI * r * 2, 2);
        public virtual double S => Math.Round(Math.PI * r * r, 2);
    }
}