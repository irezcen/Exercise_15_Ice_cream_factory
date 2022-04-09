using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie_5
{
    class WloskiPolewa:Strategia
    {
        public override Lody DajLody()
        {
            return new Wloskie(false, true);
        }
    }
}
