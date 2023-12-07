using RailwayTransport.Controller.Factories;
using RailwayTransport.Controller.Interfaces;
using RailwayTransport.View;
using RailwayTransport.View.Printers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayTransport.Controller
{
    public class DepoController
    {
        private IDepoFactory _depoFactory;
        private ITrainFactory _trainFactory;
        private IPrinter _printer;

        public DepoController()
        {
            _depoFactory = new RandomDepoFactory();
            _trainFactory = new RandomTrainFactory();
            _printer = new LogPrinter();
        }

        public DepoController(IDepoFactory depoFactory, IPrinter printer)
        {
            _depoFactory = depoFactory;
            _printer = printer;
        }

        public void SetDepoFactory(IDepoFactory depoFactory)
        {
            _depoFactory = depoFactory;
        }

        public void SetTrainFactory(ITrainFactory trainFactory)
        {
            _trainFactory = trainFactory;
        }

        public void SetPrinter(IPrinter printer)
        {
            _printer = printer;
        }

        public Train CreateTrain(int wagonsAmount, bool isPassenger, bool isLoaded)
        {
            return _trainFactory.CreateTrain(wagonsAmount, isPassenger, isLoaded);
        }

        public Train CreateTrain()
        {
            return _trainFactory.CreateTrain();
        }

        public List<Train> CreateTrains(int amount)
        {
            var trains = new List<Train>();

            for (int i = 0; i < amount; i++)
            {
                trains.Add(CreateTrain());
            }

            return trains;
        }

        public Depo CreateDepo(int maxCapacity)
        {
            return _depoFactory.CreateDepo(maxCapacity);
        }

        public Depo CreateDepo(List<Train> trains)
        {
            return _depoFactory.CreateDepo(trains);
        }

        public void AddTrainsToDepo(Depo depo, List<Train> trains)
        {
            foreach (var train in trains)
            {
                depo.AddTrain(train);
            }
        }

        public void PrintDepoInfo(Depo depo)
        {
            _printer.Print(TrainInfoView.GetDepoInfo(depo));
        }
    }
}
