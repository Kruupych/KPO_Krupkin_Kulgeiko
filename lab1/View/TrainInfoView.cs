using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayTransport.View
{
    internal class TrainInfoView
    {
        public static void ShowTrainInfo(Train train)
        {
            Console.WriteLine("Длина поезда: " + train.Length + "м");
            Console.WriteLine("\nСамый длинный вагон:\n" + train.FindLongestWagon().ToString());
            Console.WriteLine("\nСамый короткий вагон:\n" + train.FindShortestWagon().ToString());
            Console.WriteLine("\nВес поезда: " + train.TotalWeight.ToString("f2") + " т");
            Console.WriteLine("\nМаксимальная скорость: " + train.MaxSpeed.ToString("f1") + " км/ч");
        }

        public static void ShowDepoInfo(Depo depo)
        {
            for (int i = 0; i < depo.Trains.Count; i++)
            {
                Console.WriteLine($"\n\nПоезд №{i + 1}: \n");
                ShowTrainInfo(depo[i]);
            }
        }
    }
}
