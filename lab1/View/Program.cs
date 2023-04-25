using RailwayTransport.Controller;
using RailwayTransport.View;

namespace RailwayTransport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var train = TrainCreator.CreateTrain(wagonsCount: 30);
            var train1 = TrainCreator.CreateTrain(wagonsCount:11);
            var train2 = TrainCreator.CreateTrain(wagonsCount: 22);
            var train3 = TrainCreator.CreateTrain(wagonsCount: 10);
            var train4 = TrainCreator.CreateTrain(wagonsCount: 8);
            TrainInfoView.ShowTrainInfo(train);
           
        }
    }
}