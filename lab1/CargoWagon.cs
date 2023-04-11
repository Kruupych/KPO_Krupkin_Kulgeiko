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
            Nothing, Coal, Wood, AgroCombine, Fuel, Animals
        }

        public double Length { get; private set; }
        public bool IsPassenger { get; private set; }
        public double EmptyWeight { get; private set; }
        public double Weight { get; private set; }
        public double Payload { get; private set; }
        public Resource ResourceType { get; private set; }
        public static int TotalCount { get; private set; }


        public CargoWagon(double length, double emptyWeight, double payload)
        {
            Length = length;
            EmptyWeight = emptyWeight;
            IsPassenger = false;
            Weight = emptyWeight;
            Payload = payload;
            TotalCount++;
        }

        static CargoWagon()
        {
            TotalCount = 0;
        }

        public void Unload()
        {
            ResourceType = Resource.Nothing;
            Weight = EmptyWeight;
        }

        public void Load(Resource resource, int loadPercentage)
        {
            ResourceType = resource;
            loadPercentage = loadPercentage > 100? 100 : loadPercentage < 0 ? 0 : loadPercentage;
            Weight += Payload * loadPercentage / 100d;
        }

        public override string ToString()
        {
            return $"Грузовой вагон, везущий {ResourceType.ToString()}" +
                $"\nДлина: {Length} метров" +
                $"\nВес: {Weight.ToString("f2")} тонн";
        }
    }
}