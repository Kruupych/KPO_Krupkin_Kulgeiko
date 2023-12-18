using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace RailwayTransport
{
    public class CargoWagon : IWagon
    {
        public enum Resource
        {
            [Description("Ничего")]
            Nothing = 0,
            [Description("Уголь")]
            Coal,
            [Description("Дерево")]
            Wood,
            [Description("Агрокультуры")]
            AgroCombine,
            [Description("Топливо")]
            Fuel,
            [Description("Животных")]
            Animals
        }

        public double Length { get; private set; }
        public bool IsPassenger { get; private set; }
        public double EmptyWeight { get; private set; }
        public double Weight { get; private set; }
        public double Payload { get; private set; }
        public Resource ResourceType { get; private set; }
        public int LoadPercentage { get; private set; }

        public static int TotalCount { get; private set; }

        public CargoWagon()
        {
            Length = 15d;
            EmptyWeight = 25d;
            Weight = EmptyWeight;
            Payload = 75d;

            ResourceType = Resource.Nothing;
            IsPassenger = false;
            TotalCount++;
        }

        [JsonConstructor]
        public CargoWagon(double length, double emptyWeight, double payload, Resource resourceType = Resource.Nothing, int loadPercentage = 0)
        {
            Length = length;
            EmptyWeight = emptyWeight;
            Weight = emptyWeight;
            Payload = payload;
            Load(resourceType, loadPercentage);
            IsPassenger = false;
            TotalCount++;
        }

        public CargoWagon(CargoWagon wagon)
        {
            Length = wagon.Length;
            EmptyWeight = wagon.EmptyWeight;
            Weight = wagon.Weight;
            Payload = wagon.Payload;
            ResourceType = wagon.ResourceType;

            IsPassenger = false;
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
            LoadPercentage = loadPercentage = loadPercentage > 100? 100 : loadPercentage < 0 ? 0 : loadPercentage;
            Weight = EmptyWeight;
            Weight += Payload * loadPercentage / 100d;
        }

        public override string ToString()
        {
            return $"\r\nГрузовой вагон, везущий {ResourceType.ToString()}" +
                $"\r\nДлина: {Length} метров" +
                $"\r\tВес: {Weight.ToString("f2")} тонн";
        }

        ~CargoWagon()
        {
            TotalCount--;
        }
    }
}