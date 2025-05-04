using MODULE2_CHALLENGE_JONATAN_ARCE.Enums;
using MODULE2_CHALLENGE_JONATAN_ARCE.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODULE2_CHALLENGE_JONATAN_ARCE.Repositories
{
    public interface IOdontologoRepository : IRepository<Odontologo>
    {
        Odontologo GetByNumeroExpediente(string numeroCOP);

        Odontologo GetByTypeDentist(TipoOdontologo typeDentist);

    }

 
}
