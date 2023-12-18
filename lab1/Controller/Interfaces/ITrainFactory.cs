using Locomotive;

namespace RailwayTransport.Controller.Interfaces
{
    public interface ITrainFactory
    {
        ILocomotive CreateLocomotive();

        ILocomotive CreateLocomotive(double power);

        Train CreateTrain(int wagonsAmount, bool isPassenger, bool isLoaded);

        Train CreateTrain(string name, int wagonsAmount, double power, int loadPercentage, CargoWagon.Resource resource);

        Train CreateTrain(string name, int wagonsAmount, double power, int pessengersFillness);

        Train CreateTrain(int loadPercentage);
        Train CreateTrain();
        Train CreateEmptyTrain();
    }
}
