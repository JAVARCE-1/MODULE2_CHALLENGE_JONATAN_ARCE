using MODULE2_CHALLENGE_JONATAN_ARCE.Enums;
using MODULE2_CHALLENGE_JONATAN_ARCE.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODULE2_CHALLENGE_JONATAN_ARCE.Repositories
{
    public interface ICitaRepository : IRepository<Cita>
    {
        List<Cita> GetByDateQuotes(DateTime fechaCita);

        List<Cita> GetByStatusQuotes(EstadoCita estadoCita);

        Cita GetByQuotesForDentistID(int dentistID);

        List<Cita> GetByListQuotesForPatientID(int patientID);

        List<Cita> GetByListQuotesForDentistID(int dentistID);


    }
}
