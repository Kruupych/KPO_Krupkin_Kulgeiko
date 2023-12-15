using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayTransport.Controller.Factories
{
    public class RandomWagonFactory : Interfaces.IWagonFactory
    {
        private Random _random;

        public RandomWagonFactory(int seed = 0)
        {
            _random = seed == 0 ? new Random() : new Random(seed); 
        }

        public IWagon CreateCargoWagon(bool isLoaded = false)
        {
            double length = _random.Next(11, 17);
            double emptyWeight = _random.Next(18, 31);
            double payLoad = _random.Next(45, 96);

            //Инициализируем вагон
            CargoWagon wagon = new CargoWagon(length, emptyWeight, payLoad);

            if (isLoaded)
            {
                CargoWagon.Resource resource = (CargoWagon.Resource)_random.Next(1, 6);
                int loadPercentage = _random.Next(1, 101);

                //Загружаем вагон
                wagon.Load(resource, loadPercentage);
            }


            return wagon;
        }

        public IWagon CreateCargoWagon(int loadPercentage, CargoWagon.Resource resource)
        {
            double length = _random.Next(11, 17);
            double emptyWeight = _random.Next(18, 31);
            double payLoad = _random.Next(45, 96);

            return new CargoWagon(length, emptyWeight, payLoad, resource, loadPercentage);
        }

        public IEnumerable<IWagon> CreateCargoWagons(int amount, bool isLoaded)
        {
            List<IWagon> cargoWagons = new();

            for (int i = 0; i < amount; i++)
            {
                cargoWagons.Add(CreateCargoWagon(isLoaded));
            }

            return cargoWagons;
        }

        public IEnumerable<IWagon> CreateCargoWagons(int amount, int loadPercentage, CargoWagon.Resource resource)
        {
            List<IWagon> cargoWagons = new();

            for (int i = 0; i < amount; i++)
            {
                cargoWagons.Add(CreateCargoWagon(loadPercentage, resource));
            }

            return cargoWagons;
        }

        public IWagon CreatePassengerWagon(bool isLoaded = false)
        {
            double length = _random.Next(20, 30);
            double emptyWeight = _random.Next(minValue: 40, 70);
            int maxPassengers = _random.Next(40, 80);

            var wagon = new PassengerWagon(length, emptyWeight, maxPassengers);

            if (isLoaded)
            {
                wagon.Load(_random.Next(40, wagon.Payload));
            }

            return wagon;
        }

        public IWagon CreatePassengerWagon(int loadPercentage)
        {
            double length = _random.Next(20, 30);
            double emptyWeight = _random.Next(minValue: 40, 70);
            int maxPassengers = _random.Next(40, 80);

            return new PassengerWagon(length, emptyWeight, maxPassengers, loadPercentage);
        }

        public IEnumerable<IWagon> CreatePassengerWagons(int amount, bool isLoaded)
        {
            List<IWagon> passWagons = new();

            for (int i = 0; i < amount; i++)
            {
                passWagons.Add(CreatePassengerWagon(isLoaded));
            }

            return passWagons;
        }

        public IEnumerable<IWagon> CreatePassengerWagons(int amount, int loadPercentage)
        {
            List<IWagon> passWagons = new();

            for (int i = 0; i < amount; i++)
            {
                passWagons.Add(CreatePassengerWagon(loadPercentage));
            }

            return passWagons;
        }
    }
}
