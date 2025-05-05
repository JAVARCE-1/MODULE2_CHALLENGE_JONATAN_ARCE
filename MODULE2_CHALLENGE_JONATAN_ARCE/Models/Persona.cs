using MODULE2_CHALLENGE_JONATAN_ARCE.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODULE2_CHALLENGE_JONATAN_ARCE.Modelos
{
    public abstract class Persona
    {
 
        public int Id { get;  protected set; }
        public string Dni { get; set; }
        public string NombreCompleto { get; set; }
        public Sexo Sexo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public Estado Estado { get; set; } = Estado.Activo;
        public DateTime FechaRegistro { get; set; } = DateTime.Now;
        public DateTime? FechaModificacion { get; set; }

 

        public virtual void DatoPersona()
        {
            Console.WriteLine($" Data person : {NombreCompleto} DNI: {Dni} date of birth: {FechaNacimiento.ToString("dd/MM/yyyy")},");
            Console.WriteLine($" Genero: {Sexo}  - status: {Estado}");
        }





    }
}
                    
