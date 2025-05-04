using MODULE2_CHALLENGE_JONATAN_ARCE.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODULE2_CHALLENGE_JONATAN_ARCE.Repositories
{
    class PacienteRepository : IPacienteRepository

    {
        List<Paciente> _patient = new List<Paciente>();
        public void Add(Paciente entity)
        {
            _patient.Add(entity);
        }

        public void Delete(Paciente entity)
        {
            _patient.Remove(entity);
        }

        public List<Paciente> GetAll()
        {
            return _patient.ToList();
        }

        public Paciente GetById(int id)
        {
            return _patient.FirstOrDefault(x => x.Id == id);
        }

        public Paciente GetByNumeroExpediente(string NumeroExpediente)
        {
            return _patient.FirstOrDefault(x => x.NumeroExpediente == NumeroExpediente);
        }

        public void Update(Paciente entity)
        {
            var index = _patient.FindIndex(x => x.Id == entity.Id);
            if (index !=-1)
            {
                _patient[index] = entity;
            }

        }
    }
}
