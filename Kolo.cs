using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury_Dziedziczcenie
{
    class Kolo : Figura
    {
        public float R;

        public Kolo(string kolor, string nazwa, float r)
            :base(kolor, nazwa)
        {
            R = r;
        }

        public void WypiszPole()
        {
            Console.WriteLine(3.14 * R * R);
        }
    }
}
