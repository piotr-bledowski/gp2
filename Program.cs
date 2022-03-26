using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury_Dziedziczcenie
{
    class Program
    {
        static void Main(string[] args)
        {
            Kwadrat kwadrat1 = new Kwadrat("Czerwony", "Kwadrat 1", 6f);
            Kwadrat kwadrat2 = new Kwadrat("Niebieski", "Kwadrat 2", 5f);
            Trojkat trojkat1 = new Trojkat("Bialy", "Trójkat 1", 2.5f, 4f);
            Trojkat trojkat2 = new Trojkat("Czarny", "Trójkat 2", 6f, 8f);
            Kolo kolo1 = new Kolo("Zielony", "Kólko 1", 3f);
            Kolo kolo2 = new Kolo("Zólty", "Kólko 2", 1f);

            Console.WriteLine("\nPola kwadratów: \n");
            kwadrat1.WypiszPole();
            kwadrat2.WypiszPole();
            Console.WriteLine("\nPola trójkatów: \n");
            trojkat1.WypiszPole();
            trojkat2.WypiszPole();
            Console.WriteLine("\nPola kól: \n");
            kolo1.WypiszPole();
            kolo2.WypiszPole();

            Console.ReadKey();
        }
    }
}
