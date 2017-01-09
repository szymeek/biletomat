using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biletomat
{
    abstract class Bilet
    {
        protected double cena;
        abstract public void ObliczCene(char RodajBiletu);
    }
}
