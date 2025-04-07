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
            try
            {
                if (string.IsNullOrEmpty(nombre))
                    throw new ArgumentException("El nombre del auto no puede estar vacío");
                this.Nombre = nombre;

                if (string.IsNullOrEmpty(Tipo))
                    throw new ArgumentException("El tipo de auto no puede estar vacío");
                this.Tipo = tipo;

                this.DistanciaRecorrida = 0;
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Error: "+ ex.Message);
            }
            
        }

        public abstract int Avanzar(string clima);

        public void calcularAcance(int metros)
        {
            DistanciaRecorrida += metros;
        }
    }
}
