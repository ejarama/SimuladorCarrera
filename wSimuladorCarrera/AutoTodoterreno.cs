using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wSimuladorCarrera
{
    class AutoTodoterreno : Auto
    {
        public AutoTodoterreno(string nombre):base(nombre, "Todoterreno") { }
        public override int Avanzar(string clima, int avance)
        {
            
            if (clima == "lluvia")
                avance += 2;

            return avance;
        }
    }
}
