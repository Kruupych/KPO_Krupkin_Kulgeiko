using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayTransport
{
    public class Depo
    {
        List<Train> _trainList;        
        public int MaxCapacity { get; private set; }       

        public Depo(int cap)
        {
            MaxCapacity = cap;
            _trainList = new List<Train>();
        }

        public void AddTrain(Train train)
        {
            if (_trainList.Count < MaxCapacity)
            {
                _trainList.Add(train);                
            }
        }

        public void RemoveTrain(Train train)
        {
            if (_trainList.Contains(train))
            {
                _trainList.Remove(train);
            }
        }
        public void ShowTime()
        {
           foreach(Train tr in _trainList)
            {
                Console.WriteLine(tr.Length + " " + tr.TotalWeight + " " + tr.MaxSpeed);
            }
        }
        public Depo SortByWeight()
        {
            
            _trainList.Sort((x, y) => x.TotalWeight.CompareTo(y.TotalWeight));
            return this;
        }
        public Depo SortBySpeed()
        {
            
            _trainList.Sort((x, y) => x.MaxSpeed.CompareTo(y.MaxSpeed));
            return this;
        }
        public Depo SortByLength()
        {
            
            _trainList.Sort((x, y) => x.Length.CompareTo(y.Length));
            return this;
        }
        public Train FindTrainBySpeed(bool IsSmallest)
        {
            if(_trainList== null)
            {
                throw new Exception("_trainList is null");
            }
            if (IsSmallest)
            {
                var minm = _trainList.Min(p => p.MaxSpeed);
                return _trainList.Find(p => p.MaxSpeed == minm);
            }
            else
            {
                var maxm = _trainList.Max(p => p.MaxSpeed);
                return _trainList.Find(p => p.MaxSpeed == maxm);
            }
        }
        public Train FindTrainByWeight(bool IsSmallest)
        {
            if (_trainList == null)
            {
                throw new Exception("_trainList is null");
            }
            if (IsSmallest)
            {
                var minm = _trainList.Min(p => p.TotalWeight);
                return _trainList.Find(p => p.TotalWeight == minm);
            }
            else
            {
                var maxm = _trainList.Max(p => p.TotalWeight);
                return _trainList.Find(p => p.TotalWeight == maxm);
            }
        }
        public Train FindTrainByLength(bool IsSmallest)
        {
            if (_trainList == null)
            {
                throw new Exception("_trainList is null");
            }
            if (IsSmallest)
            {
                var minm = _trainList.Min(p => p.Length);
                return _trainList.Find(p => p.Length == minm);
            }
            else
            {
                var maxm = _trainList.Max(p => p.Length);
                return _trainList.Find(p => p.Length == maxm);
            }            
        }
        public List<Train> FindTrainBySpeed(bool IsBiggerThan,int value)
        {
            if (_trainList == null)
            {
                throw new Exception("_trainList is null");
            }
            if (IsBiggerThan)
            {                
                return _trainList.FindAll(p => p.MaxSpeed >= value);
            }
            else
            {
                return _trainList.FindAll(p => p.MaxSpeed < value);
            }
        }
        public List<Train> FindTrainByWeight(bool IsBiggerThan, double value)
        {
            if (_trainList == null)
            {
                throw new Exception("_trainList is null");
            }
            if (IsBiggerThan)
            {
                return _trainList.FindAll(p => p.TotalWeight >= value);
            }
            else
            {
                return _trainList.FindAll(p => p.TotalWeight < value);
            }
        }
        public List<Train> FindTrainByLength(bool IsBiggerThan, double value)
        {
            if (_trainList == null)
            {
                throw new Exception("_trainList is null");
            }
            if (IsBiggerThan)
            {
                return _trainList.FindAll(p => p.Length >= value);
            }
            else
            {
                return _trainList.FindAll(p => p.Length < value);
            }
        }
    }
}
