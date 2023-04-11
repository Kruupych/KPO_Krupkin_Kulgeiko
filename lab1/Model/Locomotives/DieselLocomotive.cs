using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RailwayTransport
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

        public DieselLocomotive()
        {
            Length = 13.5;
            Power = 7500;
            Weight = 100;
            IsElectric = false;
        }

        public DieselLocomotive(DieselLocomotive locomotive)
        {
            Length = locomotive.Length;
            Power = locomotive.Power;
            Weight = locomotive.Weight;
            IsElectric = locomotive.IsElectric;
        }

        public double CalculateMaxSpeed(double totalWeight)
        {
            return Power / totalWeight * 24d;
        }

        public static double CalculateMaxSpeed(double totalWeight, double power)
        {
            return power / totalWeight * 24d;
        }
    }
}