using MODULE2_CHALLENGE_JONATAN_ARCE.Enums;
using MODULE2_CHALLENGE_JONATAN_ARCE.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODULE2_CHALLENGE_JONATAN_ARCE.Repositories
{
     class OndotologoRepository : IOdontologoRepository
    {
        private List<Odontologo> _dentist = new List<Odontologo>();

        public OndotologoRepository()
        {
            _dentist.Add(new Odontologo()
            {
                NombreCompleto = "Mario Porras ",
                Dni = "40063848",
                Sexo = Sexo.Masculino,
                FechaNacimiento = new DateTime(1980, 5, 4),
                Telefono = "45647656",
                Email = "Mariopp@correo",
                numeroCOP = "10333",
                Especialidad = TipoOdontologo.OdontologoGeneral
            });

            _dentist.Add(new Odontologo()
            {
                NombreCompleto = "Luz Pereda ",
                Dni = "45443848",
                Sexo = Sexo.Masculino,
                FechaNacimiento = new DateTime(1985, 11, 11),
                Telefono = "90767564",
                Email = "Luz@correo",
                numeroCOP = "10021",
                Especialidad = TipoOdontologo.Especialista
            });

        }

        public void Add(Odontologo entity)
        {
            _dentist.Add(entity);
        }

        public void Delete(Odontologo entity)
        {
            _dentist.Remove(entity);
        }

        public List<Odontologo> GetAll()
        {
            return _dentist.ToList();
        }

        public Odontologo GetById(int id)
        {
            return _dentist.FirstOrDefault(x => x.Id == id);
        }

        public Odontologo GetByNumeroCop(string numeroCOP)
        {
            return _dentist.FirstOrDefault(x => x.numeroCOP == numeroCOP);
        }

        public Odontologo GetByTypeDentist(TipoOdontologo typeDentist)
        {
            return _dentist.FirstOrDefault(x => x.Especialidad == typeDentist);
        }

        public void Update(Odontologo entity)
        {
            var index = _dentist.FindIndex(x => x.Id == entity.Id);

            if (index != -1)
            {
                _dentist[index] = entity;
            }
        }
    }
}
