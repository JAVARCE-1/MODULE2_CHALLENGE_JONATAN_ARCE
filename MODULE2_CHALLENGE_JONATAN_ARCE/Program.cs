using MODULE2_CHALLENGE_JONATAN_ARCE.Repositories;
using MODULE2_CHALLENGE_JONATAN_ARCE.Services;
using MODULE2_CHALLENGE_JONATAN_ARCE.UI;

using System.Threading.Channels;

namespace MODULE2_CHALLENGE_JONATAN_ARCE
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sart System ...");
            var odontologoService = new OdontologoService(new OndotologoRepository());
            var citaService = new CitaService(new CitaRepository(), new OndotologoRepository());
            var pacienteService = new PacienteService(new PacienteRepository(), new CitaRepository());

            var ui = new ConsoleUI(pacienteService, odontologoService, citaService);

            ui.StartRunning();
        }
    }
}
