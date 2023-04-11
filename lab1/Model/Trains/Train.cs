using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RailwayTransport
{
    public class Train
    {
        List<IWagon> _wagonList;
        ILocomotive _locomotive;

        public double TotalWeight { get; private set; }
        public double Length { get => GetTotalLength(); }
        public double MaxSpeed { get => _locomotive.CalculateMaxSpeed(TotalWeight); }

        public Train(ILocomotive locomotive)
        {
            _locomotive = locomotive;
            _wagonList = new List<IWagon>();
            RecalculateWeight();
        }

        public Train(ILocomotive locomotive, IEnumerable<IWagon> wagons) : this(locomotive)
        {
            AddWagons(wagons);
        }

        public void AddWagon(IWagon wagon)
        {
            _wagonList.Add(wagon);
            RecalculateWeight();
        }

        public void AddWagons(IEnumerable<IWagon> wagons)
        {
            foreach (var wagon in wagons)
            {
                _wagonList.Add(wagon);
            }

            RecalculateWeight();
        }

        private void RecalculateWeight()
        {
            double weight = _locomotive.Weight;
            foreach (var wagon in _wagonList)
            {
                weight += wagon.Weight;
            }

            TotalWeight = weight;
        }

        public IWagon FindShortestWagon()
        {
            if (_wagonList.Count == 0) return null;

            IWagon shortestWagon = _wagonList[0];

            foreach (var wagon in _wagonList)
            {
                if (wagon.Length < shortestWagon.Length)
                {
                    shortestWagon = wagon;
                }
            }

            return shortestWagon;
        }

        public IWagon FindLongestWagon()
        {
            if (_wagonList.Count == 0) return null;

            IWagon longestWagon = _wagonList[0];

            foreach (var wagon in _wagonList)
            {
                if (wagon.Length > longestWagon.Length)
                {
                    longestWagon = wagon;
                }
            }

            return longestWagon;
        }

        private double GetTotalLength()
        {
            double totalLength = _locomotive.Length;

            foreach (var wagon in _wagonList)
            {
                totalLength += wagon.Length;
            }

            return totalLength;
        }
    }
}