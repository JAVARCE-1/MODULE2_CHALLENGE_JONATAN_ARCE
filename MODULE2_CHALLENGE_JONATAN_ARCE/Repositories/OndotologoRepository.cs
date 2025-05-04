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
            return _dentist;
        }

        public Odontologo GetById(int id)
        {
            return _dentist.FirstOrDefault(x => x.Id == id);
        }

        public Odontologo GetByNumeroExpediente(string numeroCOP)
        {
            return _dentist.FirstOrDefault(x => x.numeroCOP == numeroCOP);
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
