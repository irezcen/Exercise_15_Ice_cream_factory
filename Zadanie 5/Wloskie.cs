using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie_5
{
    class Wloskie:Lody
    {
        private bool wafel;
        private bool czekoladowaPosypka;
        public override Dictionary<string, string> PodajInformacje()
        {
            var lista = base.PodajInformacje();
            lista.Add("wafel", wafel.ToString());
            lista.Add("posypka czekoladowa", czekoladowaPosypka.ToString());
            return lista;
        }
        public Wloskie(bool _wafel, bool _posypka)
        {
            int a = 0;
            int b = 0;
            if (_wafel)
            {
                a = 1;
            }
            if (_posypka)
            {
                b = 1;
            }
            cena = 2 + a + b;
            wafel = _wafel;
            czekoladowaPosypka = _posypka;
            smak = "wloskie";
        }
    }
}
