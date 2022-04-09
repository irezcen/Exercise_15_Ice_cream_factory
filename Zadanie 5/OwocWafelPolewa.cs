using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie_5
{
    class OwocWafelPolewa:Strategia
    {
        public override Lody DajLody()
        {
            return new Owocowe(true, "malinowa");
        }
    }
}
