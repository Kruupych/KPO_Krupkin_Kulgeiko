using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayTransport.Controller.Interfaces
{
    public interface IWagonFactory
    {
        IWagon CreatePassengerWagon(bool isLoaded);
        IWagon CreatePassengerWagon(int loadPercentage);
        IWagon CreateCargoWagon(bool isLoaded);
        IWagon CreateCargoWagon(int loadPercentage, CargoWagon.Resource resource);

        IEnumerable<IWagon> CreateCargoWagons(int amount, bool isLoaded);
        IEnumerable<IWagon> CreatePassengerWagons(int amount, bool isLoaded);
        IEnumerable<IWagon> CreateCargoWagons(int amount, int loadPercentage, CargoWagon.Resource resource);
        IEnumerable<IWagon> CreatePassengerWagons(int amount, int loadPercentage);
    }
}
