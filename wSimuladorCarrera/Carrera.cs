using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wSimuladorCarrera
{
    public class Carrera
    {
        private static Carrera _instancia;
        private List<Auto> Participantes;
        public string Clima { get; private set; }
        public bool EnCurso { get; private set; } = false;
        public bool Terminada { get; private set; } = false;

        private Random random = new Random();

        private Carrera()
        {
            Participantes = new List<Auto>();
        }

        public static Carrera Instancia
        {
            get
            {
                if(_instancia == null)
                {
                    _instancia = new Carrera();
                }
                return _instancia;
            }
        }

        public List<Auto> ObtenerParcipantes()
        {
            try
            {
                return Participantes;
            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.Message); 
            }
        }

        public void establecerClima(string clima)
        {

            try
            {
                if (string.IsNullOrEmpty(clima))
                    throw new ArgumentException("Se debe definir un clima para la carrera");

                this.Clima = clima;
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Error: " + ex.Message);
            }
        }

        public void agregarAuto(Auto auto)
        {
            
            if (Participantes.Any(c => c.Nombre == auto.Nombre))
                throw new ArgumentException("Error: El auto ya existe");

            Participantes.Add(auto);
        }

        public void iniciarCarrera()
        {
            if (Participantes.Count < 3)
                throw new ArgumentException("Se requieren almenos 3 autos registrados para comenzar la carrera");

            EnCurso = true;
        }

        public string siguienteTurno()
        {
            try
            {
                if (!EnCurso || Terminada) return "";
                string resultado = "";

                int indiceParticipante = random.Next(Participantes.Count);
                bool hayObstaculo = random.NextDouble() < 0.30;

                foreach (var auto in Participantes)
                {
                    int avanceBase = random.Next(5, 16);
                    int avanceTotal = auto.Avanzar(Clima, avanceBase);
                    if (hayObstaculo && indiceParticipante == Participantes.IndexOf(auto))
                    {
                        avanceTotal = Math.Max(0, avanceTotal - 5);
                        resultado += $"{auto.Nombre} encontró un obstáculo (-5m) de anvace.\n";
                    }

                    auto.calcularAcance(avanceTotal);
                    resultado += $"{auto.Nombre} avanza {avanceTotal} metros, Total recorrido {Math.Min(150,auto.DistanciaRecorrida)}\n";

                    if(auto.DistanciaRecorrida >= 150)
                    {
                        Terminada = true;
                        resultado += $"¡{auto.Nombre} ha ganado la carrera!\n";
                        return resultado;

                    }
    
                }

                return resultado;


            }
            catch (Exception ex)
            {

                throw new ArgumentException("Error: " + ex.Message);
            }
        }

        public void reiniciarCarrera()
        {
            Participantes.Clear();
            EnCurso = false;
            Terminada = false;
            Clima = null;
        }
    }
}
