using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie_5
{
    class Smietankowe:Lody
    {
        private bool wafel;
        private bool czekoladowaPosypka;
        private string polewa;
        public override Dictionary<string, string> PodajInformacje()
        {
            var lista = base.PodajInformacje();
            lista.Add("wafel", wafel.ToString());
            lista.Add("posypka czekoladowa", czekoladowaPosypka.ToString());
            lista.Add("polewa", polewa);
            return lista;
        }
        public Smietankowe(bool _wafel, bool _posypka, string _polewa)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            if (_wafel)
            {
                a = 1;
            }
            if (_posypka)
            {
                b = 1;
            }
            if(_polewa != null)
            {
                c = 1;
            }
            cena = 2 + a + b + c;
            wafel = _wafel;
            czekoladowaPosypka = _posypka;
            smak = "Smietankowe";
        }
    }
}
