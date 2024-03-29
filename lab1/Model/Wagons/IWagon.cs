﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RailwayTransport
{
    public interface IWagon
    {
        public double Length { get; }
        public bool IsPassenger { get; }
        public double EmptyWeight { get; }
        public double Weight { get; }

        public int LoadPercentage { get; }
        public static int TotalCount { get; }
    }
} 