using RailwayTransport.Controller;
using RailwayTransport.View;

namespace RailwayTransport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var train0 = TrainCreator.CreateTrain(wagonsCount: 30);
            var train1 = TrainCreator.CreateTrain(wagonsCount: 11);
            var train2 = TrainCreator.CreateTrain(wagonsCount: 22);
            var train3 = TrainCreator.CreateTrain(wagonsCount: 10);
            var train4 = TrainCreator.CreateTrain(wagonsCount: 8);

            Depo depo = new Depo(5);
            depo.DeserializeTrains("test");

            //depo.AddTrain(train0);
            //depo.AddTrain(train1);
            //depo.AddTrain(train2);
            //depo.AddTrain(train3);
            //depo.AddTrain(train4);
            //depo.SerializeTrains("test");




            Console.WriteLine("\n\t---До сортировки:---\n");
            TrainInfoView.ShowDepoInfo(depo);

            Console.WriteLine("\n\n\t---Сортировка по скорости:---\n");
            TrainInfoView.ShowDepoInfo(depo.SortBySpeed());

            Console.WriteLine("\n\n\t---Сортировка по длине:---\n");
            TrainInfoView.ShowDepoInfo(depo.SortByLength());

            Console.WriteLine("\n\n\t---Сортировка по весу:---\n");
            TrainInfoView.ShowDepoInfo(depo.SortByWeight());

            Console.ReadKey();
        }
    }
}