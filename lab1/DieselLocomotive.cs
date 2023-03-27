using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab1
{
    public class DieselLocomotive : ILocomotive
    {
        public double Length { get; private set; }
        public double Power { get; private set; }
        public double Weight { get; private set; }
        public bool IsElectric { get; private set; }



        public DieselLocomotive(double length, double power, double weight)
        {
            Length = length;
            Power = power;
            Weight = weight;
            IsElectric = false;
        }

        public double CalculateMaxSpeed(double totalWeight)
        {
            return Power / totalWeight * 24d;
        }
    }
}