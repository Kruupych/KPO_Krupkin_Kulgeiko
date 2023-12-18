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

        public void SerializeDepoDict(Dictionary<string, Depo> depoes)
        {
            var json = JsonConvert.SerializeObject(depoes, Formatting.Indented, new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.Auto });

            _filePrinter.Print(json);
        }

        public Dictionary<string, Depo> DeserializeDepoDict()
        {
            var json = File.ReadAllText($"json/{_fileName}.json");

            return JsonConvert.DeserializeObject<Dictionary<string, Depo>>(json, new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.Auto });
        }

        public void SerializeTrainDict(Dictionary<string, Train> trains, bool toFile = true)
        {
            var json = JsonConvert.SerializeObject(trains, Formatting.Indented, new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.Auto });

            _filePrinter.Print(json);

        }

        public Dictionary<string, Train> DeserializeTrainDict()
        {
            var json = File.ReadAllText($"json/{_fileName}.json");

            return JsonConvert.DeserializeObject<Dictionary<string, Train>>(json, new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.Auto });
        }

        public static string SerializeTrainsList(List<Train> trains)
        {
            return JsonConvert.SerializeObject(trains, Formatting.Indented, new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.Auto });
        }

        public static List<Train> DeserializeTrainsList(string json)
        {
            return JsonConvert.DeserializeObject<List<Train>>(json, new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.Auto });
        }

        public static string SerializeTrain(Train train)
        {
            return JsonConvert.SerializeObject(train, Formatting.Indented, new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.Auto });
        }

        public static Train DeserializeTrain(string json)
        {
            return JsonConvert.DeserializeObject<Train>(json, new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.Auto });
        }
    }
}
