using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wSimuladorCarrera
{
    class AutoHibrido : Auto
    {
        public AutoHibrido(string nombre, string tipo):base(nombre,tipo) { }
        public override int Avanzar(string clima)
        {
            int avance = new Random().Next(5, 16);
            if (clima == "ventoso")
                avance -= 1;

            return avance;
        }
    }
}
