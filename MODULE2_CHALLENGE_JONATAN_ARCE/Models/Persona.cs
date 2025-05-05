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
        public string FechaRegistro { get; set; } = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
        public string? FechaModificacion { get; set; }

 

        public virtual void DatoPersona()
        {
            Console.WriteLine($" Datos : {NombreCompleto} con DNI {Dni} con fecha de nacimiento {FechaNacimiento}, genero {Sexo}");
        }





    }
}
                    
