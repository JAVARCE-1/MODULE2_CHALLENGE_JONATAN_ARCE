using MODULE2_CHALLENGE_JONATAN_ARCE.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODULE2_CHALLENGE_JONATAN_ARCE.Services
{
    public interface IPacienteService
    {
        Paciente GetCreatePatients(Paciente paciente);
        Paciente GetPatientById(int id);
        List<Paciente> GetPatients();
        Paciente GetPatientByNumberExpedient(string numeroExpediente);
        List<Cita> GetPatientQuotes(int citaId);
    }
}
