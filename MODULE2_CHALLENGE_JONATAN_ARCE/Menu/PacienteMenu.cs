using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODULE2_CHALLENGE_JONATAN_ARCE.Utilidades
{
    public class PacienteMenu
    {
        private bool _isRunning = true;
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
                        //selecionar opcion;
                        break;
                    case "2":
                        //selecionar opcion;
                        break;
                    case "3":
                        //selecionar opcion;
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
    }
}
