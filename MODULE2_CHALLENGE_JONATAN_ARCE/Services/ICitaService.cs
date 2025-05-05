using MODULE2_CHALLENGE_JONATAN_ARCE.Enums;
using MODULE2_CHALLENGE_JONATAN_ARCE.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODULE2_CHALLENGE_JONATAN_ARCE.Services
{
    public interface ICitaService
    {
        bool CreateQuote(Cita cita);
        bool UpdateQuote(Cita cita);

        bool UpdateStatusQuote(Cita cita, EstadoCita newEstado);

        Cita GetQuotesById(int citaID);

        List<Cita> GetQuotes();

        List<Cita> GetQuotesStatus(EstadoCita estadoCita);

        List<Cita> GetQuotesForDate(DateTime fechaCita);

        List<Cita> GetQuotesForDentist(int dentistId);


    }
}
