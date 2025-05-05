using MODULE2_CHALLENGE_JONATAN_ARCE.Enums;
using MODULE2_CHALLENGE_JONATAN_ARCE.Modelos;
using MODULE2_CHALLENGE_JONATAN_ARCE.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MODULE2_CHALLENGE_JONATAN_ARCE.Utilidades
{
    public class PacienteMenu
    {
        private bool _isRunning = true;
        private readonly IPacienteService _pacienteService;

        public PacienteMenu(IPacienteService pacienteService)
        {
            _pacienteService = pacienteService;
        }

        public void ManagePatients()
        {
          

            while (_isRunning)
            {
                Console.Clear();
                Console.WriteLine("===== Manage Patients =====");
                Console.WriteLine("  1. Create Patient");
                Console.WriteLine("  2. Modify Patient");
                Console.WriteLine("  3. View Patients");
                Console.WriteLine("  4. Return");
                Console.WriteLine("----------------------------");
                Console.Write("Enter option: ");

                var option = Console.ReadLine();
                Console.WriteLine("");
                switch (option)
                {
                    case "1":
                        CreatePatient();
                        break;
                    case "2":
                        
                        break;
                    case "3":
                        ViewPatients();
                        break;
                    case "4":
                        _isRunning = false;
                        Console.WriteLine("Closed Manage Patients...!");
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }



        private void CreatePatient()
        {
            Console.WriteLine("=== Create Patient ===");

            //
            Console.Write("-> Number Expedient: ");
            var numExpediente = Console.ReadLine();

            Console.Write("-> Patient full name: ");
            var fullName = Console.ReadLine();

            Console.Write("-> DNI: ");
            var dni = Console.ReadLine();

            Console.Write("-> Cite date (MM/DD/YYYY HH:MM): ");
            if (!DateTime.TryParse(Console.ReadLine(), out DateTime fechaNacimiento))
            {
                Console.WriteLine("Invalid date format.");
                return;
            }

            Console.Write("-> Sexo (0-Femenino , 1-Masculino): ");
            Sexo sexo = (Sexo)Convert.ToInt32(Console.ReadLine()); ;
            //if (!Enum.TryParse(Console.ReadLine(), out Sexo sexo))


            Console.Write("-> Phone number: ");
            var phone = Console.ReadLine();

            Console.Write("-> Email: ");
            var email = Console.ReadLine();

            Paciente paciente = new Paciente()
            {
                NombreCompleto = fullName,
                Dni = dni,
                Sexo = sexo,
                FechaNacimiento = fechaNacimiento,
                Telefono = phone,
                Email = email,
                NumeroExpediente = numExpediente
            };

            var registrarPaciente = _pacienteService.GetCreatePatients(paciente);
            Console.WriteLine($"Patient created with ID: {paciente.Id}");
        }

        private void ViewPatients()
        {
            var pacientes =_pacienteService.GetPatients();
            foreach (var paciente in pacientes)
            {
                Console.WriteLine(paciente);
            }
        }

    }
}
