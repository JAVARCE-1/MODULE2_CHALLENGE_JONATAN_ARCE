using MODULE2_CHALLENGE_JONATAN_ARCE.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODULE2_CHALLENGE_JONATAN_ARCE.Modelos
{
    public class Odontologo:Persona
    {
        private static int _nextIdOdontologo = 1;

        public TipoOdontologo Especialidad { get; set; }
        public string numeroCOP { get; set; }
        public List<Paciente> Paciente { get; set; }

        public Odontologo()
        {
            Id = _nextIdOdontologo++;
        }

        public override void DatoPersona()
        {
            base.DatoPersona( ) ;
            Console.WriteLine($" Number COP: {numeroCOP} , Type:{Especialidad}");
        }

    }
}
