using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biletomat
{
    class Aplikacja
    {
        static public void WykonajDzialanie(string b)
        {
            Console.WriteLine("Z - Zakup biletu \nS - Sprawdzenie biletu\nX - koniec i prowrót do początkowego menu");
            string caseSwitch2 = Console.ReadLine();
            switch (caseSwitch2)
            {
                case "Z":
                    Console.WriteLine("U-bilet ulgowy\nN-bilet normalny");
                    string zm = Console.ReadLine();
                    if (zm == "U")
                    {

                    }
                    if (b == "A")
                    {

                    }
                    break;
                case "S":
                    Console.WriteLine("Case 2");
                    break;
                case "X":
                    Console.WriteLine("X");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }
    }
}
