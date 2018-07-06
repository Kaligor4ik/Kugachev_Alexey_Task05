using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Ring : Round
    {
        private  int x;

        public Ring(int x, int y, int internalR, int externalR) : base(x, y, internalR)
        {
                ExternalR = externalR;
        }


        public int ExternalR {
            get { return ExternalR; }
            set
            {
                if (value > R) ExternalR = value;
                else throw new Exception("Внутренний радиус больше наружнего");
            }
        }

        public override double S => Math.Round(Math.PI * ExternalR * 2, 2) + base.L;
        public override double L => Math.Round(Math.PI * ExternalR * ExternalR, 2) - base.S;

        public int X1 { get => x; set => x = value; }
    }
}
