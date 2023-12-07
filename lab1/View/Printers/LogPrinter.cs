using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayTransport.View.Printers
{
    public class LogPrinter : IPrinter
    {
        public void Print(string data)
        {
            Log.Information(data);
        }
    }
}
