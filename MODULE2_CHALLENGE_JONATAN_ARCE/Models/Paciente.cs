using MODULE2_CHALLENGE_JONATAN_ARCE.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MODULE2_CHALLENGE_JONATAN_ARCE.Modelos
{
    public class Paciente:Persona
    {
        private static int _nextIdPaciente = 1;

        public string NumeroExpediente { get; set; }
        public List<Cita>? CitaHistorial {  get; set; }
        public bool IsRecurrente { get; set; } = false;

        public Paciente()
        {
            Id = _nextIdPaciente++;
        }

    }
}
