using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab1
{
    public interface ILocomotive
    {
        double Length { get; }
        double Power { get; }
        double Weight { get; }
        bool IsElectric { get; }
    }
}