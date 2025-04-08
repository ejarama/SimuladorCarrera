using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wSimuladorCarrera
{
    class AutoHibrido : Auto
    {
        public AutoHibrido(string nombre):base(nombre,"Hibrido") { }
        public override int Avanzar(string clima, int avance)
        {

            try
            {
                if (clima == "ventoso")
                    avance -= 1;

                return avance;

            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.Message);
            }
        }
    }
}
