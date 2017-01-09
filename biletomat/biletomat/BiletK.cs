using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biletomat
{
    class BiletK:Bilet
    {
        public double dlugoscTrasy;
        public override void ObliczCene(char RodzajBiletu)
        {
            double x;
            if (dlugoscTrasy < 100)
            {
                x = 1.04;
            }
            else
            {
                x = 0.73;
            }
            cena = x * dlugoscTrasy;
            if (RodzajBiletu == 'U')
            {
                cena = cena / 2;
            }
        }
    }
}
