using Newtonsoft.Json;
using RailwayTransport.View.Printers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayTransport.View
{
    public class RailwaySerializer
    {
        private string _fileName;
        private FilePrinter _filePrinter;

        public RailwaySerializer(string fileName)
        {
            _fileName = fileName;
            _filePrinter = new FilePrinter($"json/{_fileName}.json");

            if (!Directory.Exists("json"))
            {
                Directory.CreateDirectory("json");
            }

        }

        public void ChangeFileName(string fileName)
        {
            _fileName = fileName;
            _filePrinter = new FilePrinter($"json/{_fileName}.json");
        }

        public void SerializeTrains(List<Train> trains)
        {
            if (trains == null || trains.Count == 0)
            {
                return;
            }

            var json = JsonConvert.SerializeObject(trains, Formatting.Indented, new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.Auto });

            _filePrinter.Print(json);
        }

        public List<Train> DeserializeTrains()
        {
            var json = File.ReadAllText($"json/{_fileName}.json");

            return JsonConvert.DeserializeObject<List<Train>>(json, new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.Auto });
        }

        public void SerializeDepo(Depo depo)
        {
            var json = JsonConvert.SerializeObject(depo, Formatting.Indented, new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.Auto });

            _filePrinter.Print(json);
        }

        public Depo DeserializeDepo()
        {
            var json = File.ReadAllText($"json/{_fileName}.json");

            return JsonConvert.DeserializeObject<Depo>(json, new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.Auto });
        }
    }
}
