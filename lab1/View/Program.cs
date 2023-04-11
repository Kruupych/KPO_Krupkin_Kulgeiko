using RailwayTransport.Controller;
using RailwayTransport.View;

namespace RailwayTransport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var train = TrainCreator.CreateTrain(wagonsCount: 30);
            TrainInfoView.ShowTrainInfo(train);
        }
    }
}