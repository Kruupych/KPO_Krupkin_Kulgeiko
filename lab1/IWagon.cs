using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab1
{
    public interface IWagon
    {
        public double Length { get; }
        public bool IsPassenger { get; }
        public double EmptyWeight { get; }
        public double Weight { get; }
    }
} 