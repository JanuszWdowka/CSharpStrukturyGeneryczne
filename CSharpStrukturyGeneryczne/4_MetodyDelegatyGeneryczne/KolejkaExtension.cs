﻿using System.Collections.Generic;
using System.ComponentModel;

namespace _4_MetodyDelegatyGeneryczne
{
    public static class KolejkaExtension
    {
        public static IEnumerable<Twyjscie> ElementJako<T, Twyjscie>(this IKolejka<T> kolejka)
        {
            var konwerter = TypeDescriptor.GetConverter(typeof(T));

            foreach (var item in kolejka)
            {
                var wynik = konwerter.ConvertTo(item, typeof(Twyjscie));
                yield return (Twyjscie)wynik;
            }
        }

        public static void Drukuj<T>(this IKolejka<T> kolejka)
        {
            foreach (var item in kolejka)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}