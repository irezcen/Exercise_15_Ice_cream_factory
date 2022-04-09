using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie_5
{
    class ZwyklySorbet:Strategia
    {
        public override Lody DajLody()
        {
            return new Sorbet();
        }
    }
}
