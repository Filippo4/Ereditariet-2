using System;
using System.Collections.Generic;
using System.Text;

namespace Ereditarietà2
{
    class Rettangolo:Quadrilatero
    {
       public Rettangolo(double l1, double l2, double l3, double l4,double h,double w,int n_l):base(l1,l2,l3,l4,h,w,n_l)
        {
            this.l1 = l1;
            this.l2 = l2;
            this.l3 = l3;
            this.l4 = l4;
            high = h;
            widht = w;
        }
    }
}
