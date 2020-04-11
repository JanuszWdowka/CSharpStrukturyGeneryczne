using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_TypyGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            KolejkaKolowa kolej = new KolejkaKolowa(3);
            kolej.Zapisz(1);
            kolej.Zapisz(2);
            kolej.Zapisz(3);
            kolej.Zapisz(4);
            Console.WriteLine(kolej.Czytaj());
            Console.WriteLine(kolej.Czytaj());
            Console.WriteLine(kolej.Czytaj());
        }
    }
}
