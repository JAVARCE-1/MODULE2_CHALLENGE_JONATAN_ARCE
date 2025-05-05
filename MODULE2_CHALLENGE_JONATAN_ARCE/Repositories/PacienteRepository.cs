using MODULE2_CHALLENGE_JONATAN_ARCE.Enums;
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

        private List<Paciente> _patient = new List<Paciente>();

        public PacienteRepository()
        {

            _patient.Add(new Paciente()
            {
                NombreCompleto = "Pedro Cesar Flores ",
                Dni = "45963848",
                Sexo = Sexo.Masculino,
                FechaNacimiento = new DateTime(1988, 1, 1),
                Telefono = "9995433",
                Email = "pedro@correo",
                NumeroExpediente = "001"
            });

            _patient.Add(new Paciente()
            {
                NombreCompleto = "Maria Campos ",
                Dni = "45566430",
                Sexo = Sexo.Masculino,
                FechaNacimiento = new DateTime(2002, 2, 2),
                Telefono = "90949303",
                Email = "maria@correo",
                NumeroExpediente = "002",
                IsRecurrente=true
            });

            _patient.Add(new Paciente()
            {
                NombreCompleto = "Jose Ramos ",
                Dni = "43556664",
                Sexo = Sexo.Masculino,
                FechaNacimiento = new DateTime(1988, 6, 11),
                Telefono = "6565645",
                Email = "jose@correo",
                NumeroExpediente = "003"
            });
        }



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
