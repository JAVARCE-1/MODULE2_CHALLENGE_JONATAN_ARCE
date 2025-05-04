using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODULE2_CHALLENGE_JONATAN_ARCE.Utilidades
{
    public class CitasMenu
    {
        private bool _isRunning = true;
        public void DentalAppointment()
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
