using MODULE2_CHALLENGE_JONATAN_ARCE.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODULE2_CHALLENGE_JONATAN_ARCE.Services
{
    public interface IOdontologoService
    {
        Odontologo GetCreateDentist(Odontologo odontologo);
        Odontologo GetDentistById(int id);
        List<Odontologo> GetDentists();
        Odontologo GetDentistByNumberCOP(string numeroCop);
        //List<Cita> GetQuotesForDentist(int odontologoId);
    }
}
