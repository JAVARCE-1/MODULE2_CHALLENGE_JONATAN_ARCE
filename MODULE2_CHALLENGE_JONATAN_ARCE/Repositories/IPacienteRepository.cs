using MODULE2_CHALLENGE_JONATAN_ARCE.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODULE2_CHALLENGE_JONATAN_ARCE.Repositories
{
    public interface IPacienteRepository : IRepository<Paciente>
    {
        Paciente GetByNumeroExpediente(string NumeroExpediente);
    }
}
