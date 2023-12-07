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

            ViewForm form1 = new ViewForm();
            
            //form1.ShowDialog();

            var depoController = new DepoController();

            var serializer = new RailwaySerializer("test1");
            var depo = serializer.DeserializeDepo();

            //var trains = depoController.CreateTrains(5);
            //var depo = depoController.CreateDepo(trains);

            
            //serializer.SerializeDepo(depo);
            
            Log.Information("\n\t---До сортировки:---\n");
            //depoController.SetPrinter(new FilePrinter($"testPrinter.txt"));
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