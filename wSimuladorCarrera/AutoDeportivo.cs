using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wSimuladorCarrera
{
    public class AutoDeportivo : Auto
    {
        public AutoDeportivo(string nombre) : base(nombre, "Deportivo"){}
        public override int Avanzar(string clima, int avance)
        {

            try
            {
                if (clima == "soleado")
                    avance += 3;
                return avance;

            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.Message);
            }

        }
    }
}
