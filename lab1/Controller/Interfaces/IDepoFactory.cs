using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayTransport.Controller.Interfaces
{
    public interface IDepoFactory
    {
        public Depo CreateDepo();

        public Depo CreateDepo(int maxCapacity);

        public Depo CreateDepo(int maxCapacity, bool isPassenger, bool isFull);

        public Depo CreateDepo(IEnumerable<Train> trainList);
    }
}
