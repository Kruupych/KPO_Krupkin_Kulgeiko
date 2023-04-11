using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayTransport.Controller
{
    public static class TrainCreator
    {
        public static List<CargoWagon> CreateWagons(int count)
        {
            count = count < 1 ? 1 : count;

            List<CargoWagon> cargoWagons = new();
            Random random = new Random();

            for (int i = 0; i < count; i++)
            {
                //Генерируем параметры
                double length = random.Next(11, 17);
                double emptyWeight = random.Next(18, 31);
                double payLoad = random.Next(45, 96);
                CargoWagon.Resource resource = (CargoWagon.Resource)random.Next(1, 6);
                int loadPercentage = random.Next(1, 101);

                //Инициализируем вагон
                CargoWagon wagon = new CargoWagon(length, emptyWeight, payLoad);

                //Загружаем вагон
                wagon.Load(resource, loadPercentage);

                //Добавляем в список
                cargoWagons.Add(wagon);
            }

            return cargoWagons;
        }

        public static DieselLocomotive CreateDieselLocomotive()
        {
            return new DieselLocomotive();
        }

        public static Train CreateEmptyTrain()
        {
            return new Train(CreateDieselLocomotive());
        }

        public static Train CreateTrain(int wagonsCount)
        {
            wagonsCount = wagonsCount > 100? 100 : wagonsCount;

            var locomotive = CreateDieselLocomotive();
            var wagons = CreateWagons(wagonsCount);

            return new Train(locomotive, wagons);
        }

        public static Train CreateTrain(DieselLocomotive locomotive, IEnumerable<IWagon> wagons)
        {
            return CreateTrain(locomotive, wagons);
        }
    }
}
