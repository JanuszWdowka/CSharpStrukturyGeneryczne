using System;
using System.Collections.Generic;

namespace _2_KolekcjeGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Pracownik> pracownicy = new List<Pracownik>
            //{
            //    new Pracownik{ Imie = "Marcin", Nazwisko ="Nowak" },
            //    new Pracownik{ Imie = "Jan", Nazwisko ="Nowak" },
            //    new Pracownik{ Imie = "Tomasz", Nazwisko ="Nowak" },
            //};
            //pracownicy.Add(new Pracownik { Imie = "Ania", Nazwisko = "Kos" });
            //foreach (var pracownik in pracownicy)
            //{
            //    Console.WriteLine(pracownik.Imie + " " + pracownik.Nazwisko);
            //}
            //for(int i = 0; i < pracownicy.Count; ++i)
            //{
            //    Console.WriteLine(pracownicy[i].Imie + " " + pracownicy[i].Nazwisko);

            //}
            var liczby = new List<int>();
            var pojemnosc = -1;
            while (true)
            {
                if(liczby.Capacity != pojemnosc)
                {
                    pojemnosc = liczby.Capacity;
                    Console.WriteLine(pojemnosc);
                }
                liczby.Add(1);
            }
        }
    }
}
