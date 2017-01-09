using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biletomat
{
    class Program
    {
        enum RodzajBiletu { N, U };
        static void Main(string[] args)
        {
            int d = 0;

            do
            {

                Console.WriteLine("A - bilet autobusowy \n K- bilet kolejowy");
                string caseSwitch = Console.ReadLine();
                switch (caseSwitch)
                {
                    case "A":

                        Aplikacja.WykonajDzialanie(caseSwitch);
                        break;
                    case "K":

                        Aplikacja.WykonajDzialanie(caseSwitch);
                        break;
                    default:
                        d = 1;
                        break;
                }
            } while (d != 1);
            Console.ReadKey();
        }
    }
}
