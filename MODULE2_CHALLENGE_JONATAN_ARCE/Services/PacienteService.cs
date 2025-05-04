using MODULE2_CHALLENGE_JONATAN_ARCE.Modelos;
using MODULE2_CHALLENGE_JONATAN_ARCE.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MODULE2_CHALLENGE_JONATAN_ARCE.Services
{
    public class PacienteService : IPacienteService
    {
        private readonly IPacienteRepository _pacienteRepository;
        private readonly ICitaRepository _citaRepository;

        public PacienteService (IPacienteRepository pacienteRepository, ICitaRepository citaRepository)
        {
            this._pacienteRepository = pacienteRepository;
            this._citaRepository = citaRepository;
        }

        public Paciente GetCreatePatients(Paciente paciente)
        {
            var newPaciente = _pacienteRepository.GetByNumeroExpediente(paciente.NumeroExpediente);
            if (newPaciente == null)
            {
                newPaciente = new Paciente
                {
                    NombreCompleto = paciente.NombreCompleto,
                    Sexo = paciente.Sexo,
                    FechaNacimiento = paciente.FechaNacimiento,
                    Telefono = paciente.Telefono,
                    Email = paciente.Email,
                    NumeroExpediente = paciente.NumeroExpediente
                };
                _pacienteRepository.Add(newPaciente);
            }
            return newPaciente;
        }

        public Paciente GetPatientById(int id)
        {
            return _pacienteRepository.GetById(id);
        }

        public Paciente GetPatientByNumberExpedient(string numeroExpediente)
        {
            return _pacienteRepository.GetByNumeroExpediente(numeroExpediente);
        }

        public List<Cita> GetPatientQuotes(int citaId)
        {
            var lista = _citaRepository.GetByListQuotesForPatientID(citaId);
            return lista;
        }

        public List<Paciente> GetPatients()
        {
            return _pacienteRepository.GetAll();
        }
    }
}
