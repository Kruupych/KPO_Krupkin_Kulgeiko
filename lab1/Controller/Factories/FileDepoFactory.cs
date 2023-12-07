using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayTransport.Controller.Factories
{
    public class FileDepoFactory : Interfaces.IDepoFactory
    {
        private string _fileName;
        public FileDepoFactory(string filePath)
        {
            _fileName = filePath;
        }

        public Depo CreateDepo()
        {
            var json = File.ReadAllText($"json/{_fileName}.json");

            var trainList = JsonConvert.DeserializeObject<List<Train>>(json, new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.Auto });

            return new Depo(trainList, trainList.Count);
        }

        public Depo CreateDepo(int maxCapacity, bool isPassenger, bool isFull)
        {
            var json = File.ReadAllText($"json/{_fileName}.json");

            var trainList = JsonConvert.DeserializeObject<List<Train>>(json, new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.Auto });

            return new Depo(trainList, maxCapacity);
        }

        public Depo CreateDepo(IEnumerable<Train> trainList)
        {
            throw new NotImplementedException();
        }

        public Depo CreateDepo(int maxCapacity)
        {
            throw new NotImplementedException();
        }
    }
}
