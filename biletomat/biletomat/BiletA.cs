using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biletomat
{
    class BiletA:Bilet
    {
        public override void ObliczCene(char RodzajBiletu)
        {
            if (RodzajBiletu == 'N')
            {
                cena = 2.90;
            }
            else
            {
                cena = 1.45;
            }
        }
    }
}
