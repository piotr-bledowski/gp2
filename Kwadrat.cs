using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury_Dziedziczcenie
{
    class Kwadrat : Figura
    {
        public float A;

        public Kwadrat(string kolor, string nazwa, float a)
            :base(kolor, nazwa)
        {
            A = a;
        }
        public void WypiszPole()
        {
            Console.WriteLine($"Pole kwadratu: {A * A}");
        }
    }
}
