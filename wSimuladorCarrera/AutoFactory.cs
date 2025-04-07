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
                case "Deportivo":
                    return new AutoDeportivo(nombre);
                case "Todoterreno":
                    return new AutoTodoterreno(nombre);
                case "Hibrido":
                    return new AutoHibrido(nombre);
                default:
                    throw new ApplicationException("El tipo de auto no está definido");
            }
        }

    }
}
