using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab1
{
    public class PassengerWagon : IWagon
    {
        public double Length { get; private set; }
        public bool IsPassenger { get; private set; }
        public double EmptyWeight { get; private set; }
        public double Weight { get; private set; }
        public int Payload { get; private set; }

        public PassengerWagon(double length, double emptyWeight, int maxPassengers)
        {
            Length = length;
            EmptyWeight = emptyWeight;
            IsPassenger = false;
            Weight = emptyWeight;
            Payload = maxPassengers;
        }

        public void Unload()
        {            
            Weight = EmptyWeight;
        }

        public void Load(int passengersCount)
        {
            passengersCount = passengersCount > Payload ? Payload : passengersCount < 0 ? 0 : passengersCount;
            Weight += passengersCount * 0.07d;
        }
    }
}