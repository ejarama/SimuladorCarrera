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

        public int DistanciaRecorrida { get; protected set; }

        public Auto(string nombre, string tipo )
        {
            this.Nombre = nombre;
            this.Tipo = tipo;
            this.DistanciaRecorrida = 0;
            
        }

        public abstract int Avanzar(string clima);

        public void calcularAcance(int metros)
        {
            DistanciaRecorrida += metros;
        }
    }
}
