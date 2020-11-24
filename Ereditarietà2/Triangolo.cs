using System;
using System.Collections.Generic;
using System.Text;

namespace Ereditarietà2
{
    class Triangolo : FiguraGeometrica
    {
        public double l1 { get; private set; }
        public double l2 { get; private set; }
        public double l3 { get; private set; }
        public Triangolo(double l1, double l2, double l3, double h, double w,int n_l) : base(n_l,h,w)
        {
            this.l1 = l1;
            this.l2 = l2;
            this.l3 = l3;
            high = h;
            widht = w;
        }
        public double Calcola2P()
        {
            return l1 + l2 + l3;
        }
        public double Area()
        {
            return (high * widht) / 2;
        }
    }
}
