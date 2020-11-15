using System;

namespace Ereditarietà2
{
    public class FiguraGeometrica
    {
        public int n_lati { get;  set; }
        public double high { get; set; }
        public double widht { get; set; }
        public FiguraGeometrica(int n_l, double h, double w)
        {
            n_lati = n_l;
            high = h;
            widht = w;
        }
    }
}
