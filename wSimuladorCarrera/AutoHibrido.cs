﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wSimuladorCarrera
{
    class AutoHibrido : Auto
    {
        public AutoHibrido(string nombre, string tipo, int distanciaRecorrida):base(nombre,tipo, distanciaRecorrida) { }
        public override void Avanzar()
        {
            throw new NotImplementedException();    
        }
    }
}
