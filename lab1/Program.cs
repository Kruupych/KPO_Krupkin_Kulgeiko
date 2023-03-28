namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Инициализируем локомотив
            DieselLocomotive dieselLocomotive = new DieselLocomotive(length: 15, power: 9100, weight: 100);

            //Рандомно генерируем 20 вагонов
            int wagonsCount = 20;
            List<CargoWagon> cargoWagons = new();
            Random random = new Random();

            for (int i = 0; i < wagonsCount; i++)
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

            //Инициализируем поезд
            Train train = new Train(dieselLocomotive, cargoWagons);

            Console.WriteLine("Длина поезда: " + train.Length + "м");
            Console.WriteLine("\nСамый длинный вагон:\n" + train.FindLongestWagon().ToString());
            Console.WriteLine("\nСамый короткий вагон:\n" + train.FindShortestWagon().ToString());
            Console.WriteLine("\nВес поезда: " + train.TotalWeight.ToString("f2") + " т");
            Console.WriteLine("\nМаксимальная скорость: " + train.MaxSpeed.ToString("f1") + " км/ч");
        }
    }
}