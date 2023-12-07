using Locomotive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayTransport.Controller.Interfaces
{
    public interface ITrainFactory
    {
        ILocomotive CreateLocomotive();

        Train CreateTrain(int wagons, bool isPassenger, bool isLoaded);

        Train CreateTrain();
        Train CreateEmptyTrain();
    }
}
