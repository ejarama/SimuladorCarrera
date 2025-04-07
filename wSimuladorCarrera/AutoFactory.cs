using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wSimuladorCarrera
{
    public static class AutoFactory
    {
        public static Auto CrearAuto(string nombre, string tipo)
        {
            switch (tipo)
            {
                case "AutoDeportivo":
                    return new AutoTodoterreno(nombre, tipo);
                case "AutoTodoterreno":
                    return new AutoTodoterreno(nombre, tipo);
                case "AutoHibrido":
                    return new AutoTodoterreno(nombre, tipo);
                default:
                    throw new ApplicationException("El tipo de auto no está definido");
            }
        }

    }
}
