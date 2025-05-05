using MODULE2_CHALLENGE_JONATAN_ARCE.Enums;
using MODULE2_CHALLENGE_JONATAN_ARCE.Modelos;
using MODULE2_CHALLENGE_JONATAN_ARCE.Services;
using MODULE2_CHALLENGE_JONATAN_ARCE.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace MODULE2_CHALLENGE_JONATAN_ARCE.UI
{
    public class ConsoleUI
    {
        private bool _isRunning = true;
        private readonly IPacienteService _pacienteService;
        private readonly IOdontologoService _odontologoService;
        private readonly ICitaService _itaService;

        public ConsoleUI(IPacienteService pacienteService, 
            IOdontologoService odontologoService, 
            ICitaService itaService)
        {
            _pacienteService = pacienteService;
            _odontologoService = odontologoService;
            _itaService = itaService;
        }


        private void Title()
        {
            Console.WriteLine("=====================================================");
            Console.WriteLine("|               Sistema de Citas Dentales           |");
            Console.WriteLine("=====================================================");
        }
        private void DisplayMenu()
        {
            Console.WriteLine("\n=========== Main Menu ==============================");

            Console.WriteLine("\t1. Managemet Patient");
            Console.WriteLine("\t2. Managemet Dentist");
            Console.WriteLine("\t3. Managemet Citas");
            Console.WriteLine("\t4. View Reports");
            Console.WriteLine("\t0. Exit");
            Console.WriteLine("=====================================================");
            Console.Write("-> Enter option: ");
        }

        public void StartRunning()
        {
            Title();
            Console.WriteLine("\tWelcome to our Dental System ....");

            while (_isRunning)
            {
                DisplayMenu();

                var option = Console.ReadLine();
                Console.WriteLine("");
                switch (option)
                {
                    case "1":
                        MenuManagePatients();
                        break;
                    case "2":
                        MenuManageDentists();
                        break;
                    case "3":
                        MenuDentalAppointment();
                        break;
                    case "0":
                        _isRunning = false;
                        Console.WriteLine("Thank you for using the Dental System!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

                //Console.WriteLine("\nPress any key to continue...");
                //Console.ReadKey();
                Console.Clear();
                Title();
            }
        }
        //---------------------------------------------------------------------------------

        private void MenuManagePatients()
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

            Console.Write("-> Cite date (dd/mm/yyyy): ");
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
            var pacientes = _pacienteService.GetPatients();
            Console.WriteLine("Id\tDni\t\tNombre\t\t\tFechaNacimiento");  
            foreach (var paciente in pacientes)
            {
                Console.WriteLine($"{paciente.Id}\t{paciente.Dni}\t{paciente.NombreCompleto}\t{paciente.FechaNacimiento.ToString("dd/MM/yyyy")}");
            }
        }
        //-------------------------------------------------------------------------
        public void MenuManageDentists()
        {
            while (_isRunning)
            {
                Console.Clear();
                Console.WriteLine("===== Manage Dentists =====");
                Console.WriteLine("  1. Create Dentist");
                Console.WriteLine("  2. Modify Dentist");
                Console.WriteLine("  3. terminate the dentist");
                Console.WriteLine("  4. View Dentist");
                Console.WriteLine("  5. Return");
                Console.WriteLine("----------------------------");
                Console.Write("Enter option: ");

                var option = Console.ReadLine();
                Console.WriteLine("");
                switch (option)
                {
                    case "1":
                        //selecionar opcion;
                        break;
                    case "2":
                        //selecionar opcion;
                        break;
                    case "3":
                        //selecionar opcion;
                        break;
                    case "5":
                        _isRunning = false;
                        Console.WriteLine("Closed Manage Dentists...!");
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();

            }
        }

        //-------------------------------------------------------------------------

        public void MenuDentalAppointment()
        {
            while (_isRunning)
            {
                Console.Clear();
                Console.WriteLine("==== Manage Dental appointment ====");
                Console.WriteLine("  1. Create Dental appointment");
                Console.WriteLine("  2. Modify Dental appointment");
                Console.WriteLine("  3. Replace dentist,");
                Console.WriteLine("  4. End Appointment,"); //terminar
                Console.WriteLine("  5. Postpone Appointment,");  //postergar
                Console.WriteLine("  6. Cancel Appointment,"); //anular
                Console.WriteLine("  7. View Dentist");
                Console.WriteLine("  8. Return");
                Console.WriteLine("------------------------------------");
                Console.Write("Enter option: ");

                var option = Console.ReadLine();
                Console.WriteLine("");
                switch (option)
                {
                    case "1":
                        //selecionar opcion;
                        break;
                    case "2":
                        //selecionar opcion;;
                        break;
                    case "3":
                        //selecionar opcion;
                        break;
                    case "4":
                        //selecionar opcion;
                        break;
                    case "5":
                        //selecionar opcion;
                        break;
                    case "6":
                        //selecionar opcion;
                        break;
                    case "7":
                        //selecionar opcion;
                        break;
                    case "8":
                        _isRunning = false;
                        Console.WriteLine("Closed Dental appointment...!");
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }

    }
}
