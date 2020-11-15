using System;
using System.Collections.Generic;
using System.Text;

namespace Ereditarietà2
{
    class Rombo:Quadrilatero
    {
        public double Dmag { get; private set; }
        public double Dmin { get; private set; }

        public Rombo(double Dmin,double Dmag, double l1, double l2, double l3, double l4,double h,double w, int n_l):base(l1,l2,l3,l4,h,w,n_l)
        {
            this.l1 = l1;
            this.l1 = l1;
            this.l1 = l1;
            this.l1 = l1;
            this.Dmag = Dmag;
            this.Dmin = Dmin;
        }

    }
}
