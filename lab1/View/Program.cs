using RailwayTransport.Controller;
using RailwayTransport.View;
using RailwayTransport.View.Printers;
using Serilog;

namespace RailwayTransport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
               .MinimumLevel.Debug()
               .WriteTo.Console()
               .WriteTo.File("logs/myapp.txt", rollingInterval: RollingInterval.Day)
               .CreateLogger();

            string language = "ru-RU";

            while (true)
            {
                ViewForm form = new ViewForm(language);

                form.ShowDialog();

                if (form.LanguageChanged)
                {
                    language = form.CurrentLanguage;
                }
                else
                {
                    break;
                }
            }

            var depoController = new DepoController();

            var serializer = new RailwaySerializer("test1");
            var depo = serializer.DeserializeDepo();
            if (depo == null)
            {
                var trains = depoController.CreateTrains(5);
                depo = depoController.CreateDepo(trains);
                serializer.SerializeDepo(depo);
            }
            //var trains = depoController.CreateTrains(5);
            //var depo = depoController.CreateDepo(trains);
            //serializer.SerializeDepo(depo);

            Log.Information("\n\t---До сортировки:---\n");
            depoController.SetPrinter(new FilePrinter($"testPrinter.txt"));
            depoController.PrintDepoInfo(depo);

            Log.Information("\n\n\t---Сортировка по скорости:---\n");
            depoController.PrintDepoInfo(depo.SortBySpeed());
                    
            Log.Information("\n\n\t---Сортировка по длине:---\n");
            depoController.PrintDepoInfo(depo.SortByLength());

            Log.Information("\n\n\t---Сортировка по весу:---\n");
            depoController.PrintDepoInfo(depo.SortByWeight());

            //Console.ReadKey();
            Console.ReadLine();
            
        }
    }
}