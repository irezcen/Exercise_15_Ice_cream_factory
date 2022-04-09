using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie_5
{
    class FabrykaLodow
    {
        private Strategia strategia;
        public Lody SpecjalnoscDnia()
        {
            return strategia.DajLody();
        }
        public void UstawTrybProdukcji(int i)
        {
            switch (i)
            {
                case 1:
                    strategia = new SmietPolewa();
                    break;
                case 2:
                    strategia = new SmietWafelPosyp();
                    break;
                case 3:
                    strategia = new WloskiPolewa();
                    break;
                case 4:
                    strategia = new WloskiWafel();
                    break;
                case 5:
                    strategia = new OwocPolewa();
                    break;
                case 6:
                    strategia = new OwocWafelPolewa();
                    break;
                case 7:
                    strategia = new ZwyklySorbet();
                    break;
            }
        }
        public FabrykaLodow()
        {
            var rand = new Random();
            UstawTrybProdukcji(rand.Next(1, 7));
        }
    }
}
