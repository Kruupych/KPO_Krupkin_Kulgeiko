using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using static RailwayTransport.CargoWagon;

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
        public PassengerWagon(double length, double emptyWeight, int payLoad, int loadPercentage = 0)
        {
            Length = length;
            EmptyWeight = emptyWeight;
            IsPassenger = true;
            Weight = emptyWeight;
            Payload = payLoad;
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
            int passengersCount = Payload * loadPercentage / 100;
            Weight += passengersCount * 0.07d;
        }

        public void LoadPerc(int loadPercentage)
        {           
            int passengersCount;
            loadPercentage = loadPercentage > 100 ? 100 : loadPercentage < 0 ? 0 : loadPercentage;
            passengersCount = Payload * loadPercentage/100;
            Weight += passengersCount * 0.07d;
        }

        public override string ToString()
        {
            return $"\r\nПассажирский вагон, везущий {PassengersCount} пассажиров" +
                $"\r\nДлина: {Length} метров" +
                $"\r\tВес: {Weight.ToString("f2")} тонн";
        }

        ~PassengerWagon()
        {
            TotalCount--;
        }
    }
}