namespace _4_MetodyDelegatyGeneryczne
{
    public class KolejkaKolowa<T> : DuzaKolejka<T>
    {
        private int _pojemosc;

        public KolejkaKolowa(int pojemnosc = 5)
        {
            _pojemosc = pojemnosc;
        }

        public override void Zapisz(T wartosc)
        {
            base.Zapisz(wartosc);

            if (kolejka.Count > _pojemosc)
            {
                kolejka.Dequeue();
            }
        }

        public override bool JestPelny
        {
            get
            {
                return kolejka.Count == _pojemosc;
            }
        }
    }
}
