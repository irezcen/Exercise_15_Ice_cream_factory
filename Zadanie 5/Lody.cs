using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie_5
{
    abstract class Lody
    {
        protected int cena;
        protected string smak;
        public virtual Dictionary<string, string> PodajInformacje()
        {
            var lista = new Dictionary<string, string>();
            lista.Add("cena", cena.ToString());
            lista.Add("smak", smak.ToString());
            return lista;
        }
    }
}
