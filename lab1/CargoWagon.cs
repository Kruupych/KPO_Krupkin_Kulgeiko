using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab1
{
    public class CargoWagon : IWagon
    {
        public enum Resource
        {
            Empty, Coal, Wood, AgroCombine, Fuel, Animals
        }

        public double Length { get; private set; }
        public bool IsPassenger { get; private set; }
        public double EmptyWeight { get; private set; }
        public double Weight { get; private set; }
        public double Payload { get; private set; }
        public Resource ResourceType { get; private set; }

        public CargoWagon(double length, double emptyWeight, double payload)
        {
            Length = length;
            EmptyWeight = emptyWeight;
            IsPassenger = false;
            Weight = emptyWeight;
            Payload = payload;
        } 

        public void Unload()
        {
            ResourceType = Resource.Empty;
            Weight = EmptyWeight;
        }

        public void Load(Resource resource, int loadPercentage)
        {
            ResourceType = resource;
            loadPercentage = loadPercentage > 100? 100 : loadPercentage < 0 ? 0 : loadPercentage;
            Weight += Payload * loadPercentage / 100d;
            
        }
    }
}