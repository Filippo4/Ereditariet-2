using System;
using System.Collections.Generic;
using System.Text;

namespace Ereditarietà2
{
    class Quadrilatero : FiguraGeometrica
    {
        public double l1 { get; set; }
        public double l2 { get; set; }
        public double l3 { get; set; }
        public double l4 { get; set; }
        public Quadrilatero(double l1, double l2, double l3, double l4, double h, double w, int n_l) : base(n_l, h, w)
        {
            this.l1 = l1;
            this.l2 = l2;
            this.l3 = l3;
            this.l4 = l4;
            high = h;
            widht = w;
        }
        public double Calcola2P()
        {
            return l1 + l2 + l3+ l4;
        }
    }
}
