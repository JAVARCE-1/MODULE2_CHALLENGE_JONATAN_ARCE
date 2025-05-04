using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODULE2_CHALLENGE_JONATAN_ARCE.Utilidades
{
    public class OdontologoMenu
    {
        private bool _isRunning = true;
        public void ManageDentists()
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
    }
}
