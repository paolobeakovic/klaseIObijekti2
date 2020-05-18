using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beakovicPaoloObjektiZadatak2
{
    class Satelit : NebeskoTijelo
    {
        public Satelit(double brzinaOkoSunca, double brzinaOkoOsi)
        {
            BrzinaOkoSunca = brzinaOkoSunca;
            BrzinaOkoOsi = brzinaOkoOsi;
        }
    }
}