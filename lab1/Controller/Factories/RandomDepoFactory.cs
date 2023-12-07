using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayTransport.Controller.Factories
{
    public class RandomDepoFactory : Interfaces.IDepoFactory
    {
        private Random _random;

        public RandomDepoFactory(int seed = 0)
        {
            _random = seed == 0 ? new Random() : new Random(seed);
        }

        public Depo CreateDepo()
        {
            return new Depo(_random.Next(1, 10));
        }

        public Depo CreateDepo(int maxCapacity, bool isPassenger, bool isFull)
        {
            if (isFull)
            {
                var factory = new RandomTrainFactory();
                var trains = new List<Train>();

                for (int i = 0; i < maxCapacity; i++)
                {
                    int wagons = _random.Next(5, 40);
                    trains.Add(factory.CreateTrain(wagons, isPassenger, true));
                }

                return new Depo(trains, maxCapacity);
            }

            return new Depo(maxCapacity);
        }

        public Depo CreateDepo(IEnumerable<Train> trainList)
        {
            return new Depo(trainList, trainList.Count());
        }

        public Depo CreateDepo(int maxCapacity)
        {
            return new Depo(maxCapacity);
        }
    }
}
