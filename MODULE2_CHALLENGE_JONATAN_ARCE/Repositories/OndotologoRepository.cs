using MODULE2_CHALLENGE_JONATAN_ARCE.Enums;
using MODULE2_CHALLENGE_JONATAN_ARCE.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODULE2_CHALLENGE_JONATAN_ARCE.Repositories
{
    public class OndotologoRepository : IOdontologoRepository
    {
        private List<Odontologo> _dentist = new List<Odontologo>();

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
