using Serilog;
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

            Log.Information("Длина поезда: " + train.Length + "м");
            Log.Information("\nСамый длинный вагон:\n" + train.FindLongestWagon().ToString());
            Log.Information("\nСамый короткий вагон:\n" + train.FindShortestWagon().ToString());
            Log.Information("\nВес поезда: " + train.TotalWeight.ToString("f2") + " т");
            Log.Information("\nМаксимальная скорость: " + train.MaxSpeed.ToString("f1") + " км/ч");            
        }

        public static void ShowDepoInfo(Depo depo)
        {
            for (int i = 0; i < depo.Trains.Count; i++)
            {
                Log.Information($"\n\nПоезд №{i + 1}: \n");
                ShowTrainInfo(depo[i]);
            }
        }
    }

}
