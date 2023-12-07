using Locomotive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayTransport.Controller.Factories
{
    public class RandomTrainFactory : Interfaces.ITrainFactory
    {
        private Random _random;

        public RandomTrainFactory(int seed = 0)
        {
            _random = seed == 0 ? new Random() : new Random(seed);
        }


        public Train CreateEmptyTrain()
        {
            return new Train(CreateLocomotive());
        }

        public ILocomotive CreateLocomotive()
        {
            double length = _random.Next(10, 18);
            double power = _random.Next(4500, 11000);
            double weight = _random.Next(70, 145);

            return new DieselLocomotive(length, power, weight);
        }

        public Train CreateTrain(int amount, bool isPassenger, bool isLoaded)
        {
            var wagonsFactory = new RandomWagonFactory();

            var loco = CreateLocomotive();

            var wagons = isPassenger ? wagonsFactory.CreatePassengerWagons(amount, isLoaded) : wagonsFactory.CreateCargoWagons(amount, isLoaded);

            return new Train(loco, wagons);
        }

        public Train CreateTrain()
        {
            var wagonsFactory = new RandomWagonFactory();
            var loco = CreateLocomotive();

            int amount = _random.Next(5, 40);
            bool isPassenger = _random.Next(0, 2) == 0 ? false : true;
            bool isLoaded = _random.Next(0, 2) == 0 ? false : true;

            var wagons = isPassenger ? wagonsFactory.CreatePassengerWagons(amount, isLoaded) : wagonsFactory.CreateCargoWagons(amount, isLoaded);

            return new Train(loco, wagons);
        }
    }
}
