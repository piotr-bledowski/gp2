using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury_Dziedziczcenie
{
    class Trojkat : Figura
    {
        public float A;
        public float H;

        public Trojkat(string kolor, string nazwa, float a, float h)
            :base(kolor, nazwa)
        {
            A = a;
            H = h;
        }

        public void WypiszPole()
        {
            Console.WriteLine(0.5 * A * H);
        }
    }
}
