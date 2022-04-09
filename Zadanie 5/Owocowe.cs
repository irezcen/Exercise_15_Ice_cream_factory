using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie_5
{
    class Owocowe:Lody
    {
        private bool wafel;
        private string polewa;
        public override Dictionary<string, string> PodajInformacje()
        {
            var lista = base.PodajInformacje();
            lista.Add("wafel", wafel.ToString());
            lista.Add("polewa", polewa);
            return lista;
        }
        public Owocowe(bool _wafel, string _polewa)
        {
            int a = 0;
            int b = 0;
            if (_wafel)
            {
                a = 1;
            }
            if(_polewa != null)
            {
                b = 1;
            }
            cena = 2 + a + b;
            wafel = _wafel;
            polewa = _polewa;
            smak = "owocowe";
        }
    }
}
