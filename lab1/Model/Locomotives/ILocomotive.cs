﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RailwayTransport
{
    public interface ILocomotive
    {
        double Length { get; }
        double Power { get; }
        double Weight { get; }
        bool IsElectric { get; }
        public double CalculateMaxSpeed(double totalWeight);
    }
}