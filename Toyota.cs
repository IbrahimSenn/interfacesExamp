using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacesExamp
{
    public class Toyota : IOtomobil
    {
        public Marka HangiMarka()
        {
            return Marka.Toyota;
        }

        public int KacTekerlek()
        {
            return 4;
        }

        public Renk StandartRengi()
        {
            return Renk.Beyaz;
        }
    }
}
