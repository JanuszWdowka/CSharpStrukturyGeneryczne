using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _2_KolekcjeGeneryczneTests
{
    [TestClass]
    public class KolejakaTests
    {
        [TestMethod]
        public void UzyciePeek()
        {
            var kolejka = new Queue<int>();

            kolejka.Enqueue(1);
            kolejka.Enqueue(2);
            kolejka.Enqueue(3);
            kolejka.Enqueue(4);

            Assert.AreEqual(1, kolejka.Peek());
        }

        [TestMethod]
        public void UzycieContains()
        {
            var kolejka = new Queue<int>();

            kolejka.Enqueue(1);
            kolejka.Enqueue(2);
            kolejka.Enqueue(3);
            kolejka.Enqueue(4);

            Assert.IsTrue(kolejka.Contains(3));
        }

        [TestMethod]
        public void UzycieToArray()
        {
            var kolejka = new Queue<int>();

            kolejka.Enqueue(1);
            kolejka.Enqueue(2);
            kolejka.Enqueue(3);
            kolejka.Enqueue(4);

            var tablica = kolejka.ToArray();
            kolejka.Dequeue();

            Assert.AreEqual(1, tablica[0]);
            Assert.AreEqual(3, kolejka.Count);
        }

        [TestMethod]
        public void UzycieClear()
        {
            var kolejka = new Queue<int>();

            kolejka.Enqueue(1);
            kolejka.Enqueue(2);
            kolejka.Enqueue(3);
            kolejka.Enqueue(4);

            kolejka.Clear();

            Assert.AreEqual(0, kolejka.Count);
        }
    }
}
