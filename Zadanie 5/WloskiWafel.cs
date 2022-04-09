using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie_5
{
    class WloskiWafel:Strategia
    {
        public override Lody DajLody()
        {
            return new Wloskie(true, false);
        }
    }
}
