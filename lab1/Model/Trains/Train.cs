﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Locomotive;
using Newtonsoft.Json;

namespace RailwayTransport
{
    public class Train
    {
        List<IWagon> _wagonList;
        ILocomotive _locomotive;

        public double TotalWeight { get; private set; }
        public double Length { get => GetTotalLength(); }
        public double MaxSpeed { get => _locomotive.CalculateMaxSpeed(TotalWeight); }
        public List<IWagon> Wagons { get => _wagonList; }
        public string Name { get; private set; }

        public ILocomotive Locomotive { get => _locomotive; }

        public Train(ILocomotive locomotive)
        {
            _locomotive = locomotive;
            _wagonList = new List<IWagon>();
            RecalculateWeight();
        }

        [JsonConstructor]
        public Train(ILocomotive locomotive, IEnumerable<IWagon> wagons, string name = "") : this(locomotive)
        {
            Name = name;
            AddWagons(wagons);
        }
        public IWagon GetWagonByIndex(int index)
        {
            return _wagonList[index];
        }
        public void AddWagon(IWagon wagon)
        {
            if (wagon == null)
            {
                throw new ArgumentNullException();
            }

            _wagonList.Add(wagon);
            RecalculateWeight();
        }
        public void DelWagon(IWagon wagon)
        {
            if (wagon == null)
            {
                throw new ArgumentNullException();
            }

            _wagonList.Remove(wagon);
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