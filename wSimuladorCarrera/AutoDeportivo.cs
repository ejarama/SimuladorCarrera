using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wSimuladorCarrera
{
    public class AutoDeportivo : Auto
    {
        int BonoClimaSoleado = 3;
        public AutoDeportivo(string nombre, string tipo) : base(nombre,tipo)
        {

        }
        public override int Avanzar(string clima)
        {
            int avance = new Random().Next(5, 16);
            if(clima == "soleado")
                avance += 3;
            return avance;

        }
    }
}
