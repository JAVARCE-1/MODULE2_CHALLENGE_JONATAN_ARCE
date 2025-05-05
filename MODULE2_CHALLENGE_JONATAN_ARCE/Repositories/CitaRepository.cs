using MODULE2_CHALLENGE_JONATAN_ARCE.Enums;
using MODULE2_CHALLENGE_JONATAN_ARCE.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODULE2_CHALLENGE_JONATAN_ARCE.Repositories
{
    class CitaRepository : ICitaRepository
    {
        private List<Cita> _quotes = new List<Cita>();

        public CitaRepository()
        {
            _quotes.Add(new Cita()
            {
                Motivo = "Limpiezas dentales",
                FechaCita = new DateTime(2025, 5, 15, 14, 30, 0),  // 15/05/2023 14:30:00
                IdPaciente = 1,
                idOdontologo = 1,
                CostoCita = 80.00m,
                Comentarios= new List<string> { "Es su Primera cita"  }
            });

            _quotes.Add(new Cita()
            {
                Motivo = "Ajuste de brackets ",
                FechaCita = new DateTime(2025, 5, 14, 15, 30, 0),  
                IdPaciente = 2,
                idOdontologo = 2,
                CostoCita = 250.00m,
                Comentarios = new List<string> { "Primer comentario", "Segundo comentario" }
            });


            _quotes.Add(new Cita()
            {
                Motivo = "Ajuste de brackets y limpieza bucal",
                FechaCita = new DateTime(2025, 5, 16, 11, 30, 0),
                IdPaciente = 3,
                idOdontologo = 2,
                CostoCita = 250.00m,
                Comentarios = new List<string> { "Primer comentario", "Segundo comentario" }
            });


            _quotes.Add(new Cita()
            {
                Motivo = "Extracciones dentales",
                FechaCita = new DateTime(2024, 5, 18, 14, 30, 0),
                IdPaciente = 4,
                idOdontologo = 1,
                CostoCita = 110.00m,
                Comentarios = new List<string> { "Primer comentario", "Segundo comentario" },
                EstadoCita =EstadoCita.Terminado,
                Recomendaciones = new List<string> { "1 se recomienda lavarse los dientes diariamente" }

            });
        }

        public void Add(Cita entity)
        {
            _quotes.Add(entity);
        }

        public void Delete(Cita entity)
        {
            _quotes.Remove(entity);
        }

        public List<Cita> GetAll()
        {
            return _quotes.ToList();
        }

        public List<Cita> GetByDateQuotes(DateTime fechaCita)
        {
            return _quotes.Where(x => x.FechaCita >= fechaCita).ToList();
        }

        public Cita GetById(int id)
        {
            return _quotes.FirstOrDefault(x => x.IdCita == id);
        }

        public List<Cita> GetByListQuotesForDentistID(int dentistID)
        {
            return _quotes.Where(x => x.idOdontologo == dentistID).ToList();
        }

        public List<Cita> GetByListQuotesForPatientID(int patientID)
        {
            return _quotes.Where(x => x.IdPaciente == patientID).ToList();
        }

        public Cita GetByQuotesForDentistID(int dentistID)
        {
            return _quotes.FirstOrDefault(x => x.idOdontologo == dentistID);
        }

        public List<Cita> GetByStatusQuotes(EstadoCita estadoCita)
        {
            return _quotes.Where(x => x.EstadoCita == estadoCita).ToList();
        }



        public void Update(Cita entity)
        {
            var index = _quotes.FindIndex(x => x.IdCita == entity.IdCita);
            if(index != -1)
            {
                _quotes[index] = entity;
            }
        }
    }
}
