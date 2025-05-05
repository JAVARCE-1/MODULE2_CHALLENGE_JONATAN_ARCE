using MODULE2_CHALLENGE_JONATAN_ARCE.Repositories;
using MODULE2_CHALLENGE_JONATAN_ARCE.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace MODULE2_CHALLENGE_JONATAN_ARCE.Menu
{
    public class MenuUI
    {
        private bool _isRunning = true;


        //OdontologoMenu menuDentist = new OdontologoMenu();
        //CitasMenu menuAppointment = new CitasMenu();
        //PacienteMenu menuPatient = new PacienteMenu();

 

        //private void Title()
        //{
        //    Console.WriteLine("=====================================================");
        //    Console.WriteLine("|               Sistema de Citas Dentales           |");
        //    Console.WriteLine("=====================================================");
        //}
        //private void DisplayMenu()
        //{
        //    Console.WriteLine("\n=========== Main Menu ==============================");

        //    Console.WriteLine("\t1. Managemet Patient");
        //    Console.WriteLine("\t2. Managemet Dentist");
        //    Console.WriteLine("\t3. Managemet Citas");
        //    Console.WriteLine("\t4. View Reports");
        //    Console.WriteLine("\t0. Exit");
        //    Console.WriteLine("=====================================================");
        //    Console.Write("-> Enter option: ");
        //}

        //public void Run()
        //{
        //    Title();
        //    Console.WriteLine("\tWelcome to our Dental System ....");

        //    while (_isRunning)
        //    {
        //        DisplayMenu();

        //        var option = Console.ReadLine();
        //        Console.WriteLine("");
        //        switch (option)
        //        {
        //            case "1":
        //                MenuManagePatients();  
        //                break;
        //            case "2":
        //                menuDentist.ManageDentists();
        //                break;
        //            case "3":
        //                menuAppointment.DentalAppointment();
        //                break;
        //            case "0":
        //                _isRunning = false;
        //                Console.WriteLine("Thank you for using the Dental System!");
        //                break;
        //            default:
        //                Console.WriteLine("Invalid option. Please try again.");
        //                break;
        //        }

        //        //Console.WriteLine("\nPress any key to continue...");
        //        //Console.ReadKey();
        //        Console.Clear();
        //        Title();
        //    }
        //}
    }
}
