using MODULE2_CHALLENGE_JONATAN_ARCE.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODULE2_CHALLENGE_JONATAN_ARCE.Modelos
{
    public class Cita
    {
        public int IdCita {  get; private set; }
        public string Motivo { get; set; }
        public DateTime FechaCita { get; set; }
        public int IdPaciente { get; set; }
        public int idOdontologo { get; set; }
        public EstadoCita EstadoCita { get; set; } = EstadoCita.Programado;
        public decimal CostoCita { get; set; }
        public string FechaUpdate { get; set; }

        public List<string> Comentarios { get; set; }
        public List<string> Diagnostico { get; set; }
        public List<string> Recomendaciones { get; set; }

        


    }
}
