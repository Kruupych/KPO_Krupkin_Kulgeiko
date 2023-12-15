using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RailwayTransport
{
    public class PassengerWagon : IWagon
    {
        public double Length { get; private set; }
        public bool IsPassenger { get; private set; }
        public double EmptyWeight { get; private set; }
        public double Weight { get; private set; }
        public int Payload { get; private set; }
        public static int TotalCount { get; private set; }

        public int PassengersCount => (int)((Weight - EmptyWeight) / 0.07d);

        public int LoadPercentage { get; private set; }

        [JsonConstructor]
        public PassengerWagon(double length, double emptyWeight, int maxPassengers, int loadPercentage = 0)
        {
            Length = length;
            EmptyWeight = emptyWeight;
            IsPassenger = true;
            Weight = emptyWeight;
            Payload = maxPassengers;
            TotalCount++;

            Load(loadPercentage);
        }

        public PassengerWagon()
        {
            Length = 25.0;
            EmptyWeight = 56.0;
            IsPassenger = true;
            Weight = EmptyWeight;
            Payload = 64;
            TotalCount++;
        }

        public PassengerWagon(PassengerWagon wagon)
        {
            Length = wagon.Length ;
            EmptyWeight = wagon.EmptyWeight;
            IsPassenger = wagon.IsPassenger;
            Weight = wagon.Weight;
            Payload = wagon.Payload;
            TotalCount++;
        }

        static PassengerWagon()
        {
            TotalCount = 0;
        }

        public void Unload()
        {            
            Weight = EmptyWeight;
        }

        public void Load(int loadPercentage)
        {
            LoadPercentage = loadPercentage;
            Weight += loadPercentage * Payload * 0.07d;
        }

        public override string ToString()
        {
            return $"Пассажирский вагон, везущий {PassengersCount} пассажиров" +
                $"\nДлина: {Length} метров" +
                $"\nВес: {Weight.ToString("f2")} тонн";
        }

        ~PassengerWagon()
        {
            TotalCount--;
        }
    }
}