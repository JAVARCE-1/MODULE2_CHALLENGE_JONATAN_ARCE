using MODULE2_CHALLENGE_JONATAN_ARCE.Enums;
using MODULE2_CHALLENGE_JONATAN_ARCE.Modelos;
using MODULE2_CHALLENGE_JONATAN_ARCE.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace MODULE2_CHALLENGE_JONATAN_ARCE.Services
{
    public class OdontologoService: IOdontologoService
    {
        private readonly IOdontologoRepository _odontologoRepository;
        //private readonly ICitaRepository _citaRepository;
        /*rivate readonly IPacienteRepository _pacienteRepository;*/

        public OdontologoService(IOdontologoRepository odontologoRepository )
        {
            this._odontologoRepository = odontologoRepository;
            //this._pacienteRepository = pacienteRepository;
            //this._citaRepository = citaRepository;
        }

        public Odontologo GetCreateDentist(Odontologo odontologo)
        {
            var newOdontologo = _odontologoRepository.GetByNumeroCop(odontologo.numeroCOP);
            if (newOdontologo == null)
            {
                newOdontologo = new Odontologo
                {
                    NombreCompleto = odontologo.NombreCompleto,
                    Sexo = odontologo.Sexo,
                    FechaNacimiento = odontologo.FechaNacimiento,
                    Telefono = odontologo.Telefono,
                    Email = odontologo.Email,
                    Especialidad = odontologo.Especialidad,
                    numeroCOP = odontologo.numeroCOP
                };
                _odontologoRepository.Add(newOdontologo);
            }
            return newOdontologo;
        }

        public Odontologo GetDentistById(int id)
        {
            return _odontologoRepository.GetById(id);
        }

        public Odontologo GetDentistByNumberCOP(string numeroCop)
        {
            return _odontologoRepository.GetByNumeroCop(numeroCop);
        }

        public List<Odontologo> GetDentists()
        {
            return _odontologoRepository.GetAll();
        }

        //public List<Cita> GetQuotesForDentist(int odontologoId)
        //{
        //    var lista = _citaRepository.GetByListQuotesForDentistID(odontologoId);
        //    return lista;
        //}
    }
}
