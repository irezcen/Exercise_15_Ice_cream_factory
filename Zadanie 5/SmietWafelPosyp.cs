using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie_5
{
    class SmietWafelPosyp:Strategia
    {
        public override Lody DajLody()
        {
            return new Smietankowe(true, true, null);
        }
    }
}
