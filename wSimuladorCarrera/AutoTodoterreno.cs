using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wSimuladorCarrera
{
    class AutoTodoterreno : Auto
    {
        public AutoTodoterreno(string nombre, string tipo):base(nombre, tipo) { }
        public override int Avanzar(string clima)
        {
            int avance = new Random().Next(5, 16);
            if (clima == "lluvia")
                avance += 2;

            return avance;
        }
    }
}
