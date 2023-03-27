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
        public int count_of_passengers { get; private set; }


        public PassengerWagon(double length, double emptyWeight, double payload)
        {
            Length = length;
            EmptyWeight = emptyWeight;
            IsPassenger = false;
            Weight = emptyWeight;
            Payload = payload;
        }

        public void Unload()
        {            
            Weight = EmptyWeight;
        }

        public void Load(Resource resource, int count)
        {
            count = count > Payload ? Payload : count < 0 ? 0 : count;
            //loadPercentage = loadPercentage > 100 ? 100 : loadPercentage < 0 ? 0 : loadPercentage;
            Weight += count*0.07d;
        }
    }
}