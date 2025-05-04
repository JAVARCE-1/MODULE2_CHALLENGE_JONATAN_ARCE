using MODULE2_CHALLENGE_JONATAN_ARCE.Enums;
using MODULE2_CHALLENGE_JONATAN_ARCE.Modelos;
using MODULE2_CHALLENGE_JONATAN_ARCE.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODULE2_CHALLENGE_JONATAN_ARCE.Services
{
    public class CitaService : ICitaService
    {
        private readonly ICitaRepository _citaRepository;

        public CitaService(ICitaRepository citaRepository)
        {
            this._citaRepository = citaRepository;
        }

        public bool CreateQuote(Cita cita)
        {
            try
            {
                _citaRepository.Add(cita);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public List<Cita> GetQuotes(EstadoCita estadoCita)
        {
            return _citaRepository.GetByStatusQuotes(estadoCita).ToList();
        }

        public Cita GetQuotesById(int citaID)
        {
            return _citaRepository.GetById(citaID);
        }

        public List<Cita> GetQuotesForDate(DateTime fechaCita)
        {
            return _citaRepository.GetByDateQuotes(fechaCita).ToList();
        }

        public bool UpdateQuote(Cita cita)
        {
            try
            {
                _citaRepository.Update(cita);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool UpdateStatusQuote(Cita cita, EstadoCita newEstado)
        {
             
            try
            {
                var exiteCita = _citaRepository.GetById(cita.IdCita);
                if(exiteCita == null )
                {
                    return false;
                }
                exiteCita.EstadoCita = newEstado;
                exiteCita.FechaUpdate = DateTime.Today;
                _citaRepository.Update(exiteCita);

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }    
        }
    }
}
