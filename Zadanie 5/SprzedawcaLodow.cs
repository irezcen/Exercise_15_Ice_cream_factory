using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie_5
{
    class SprzedawcaLodow
    {
        private FabrykaLodow fabryka;
        public void ZaproponujSpecjalnoscDnia()
        {
            var info = fabryka.SpecjalnoscDnia().PodajInformacje();
            foreach(KeyValuePair<string, string> kvp in info)
            {
                Console.WriteLine(kvp.Key + ": " + kvp.Value);
            }
        }
        public SprzedawcaLodow(FabrykaLodow _fabryka)
        {
            fabryka = _fabryka;
        }
    }
}
