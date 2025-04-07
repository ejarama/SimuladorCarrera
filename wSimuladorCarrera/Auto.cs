using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wSimuladorCarrera
{
    public abstract class Auto
    {
        public string Nombre { get; set; }

        public string Tipo { get; set; }

        private int DistanciaRecorrida { get; set; }

        public Auto(string nombre, string tipo, int distanciaRecorrida)
        {
            this.Nombre = nombre;
            this.Tipo = tipo;
            this.DistanciaRecorrida = distanciaRecorrida;
        }

        public abstract void Avanzar();
    }
}
