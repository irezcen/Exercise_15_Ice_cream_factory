using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie_5
{
    class SmietPolewa:Strategia
    {
        public override Lody DajLody()
        {
            return new Smietankowe(false, false, "pomaranczowa");
        }
    }
}
