using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayTransport.View
{
    public class TrainInfoView
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

        public static string GetDepoInfo(Depo depo)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < depo.Trains.Count; i++)
            {
                sb.AppendLine($"\n\nПоезд №{i + 1}:");
                sb.AppendLine(GetTrainInfo(depo[i]));
                sb.AppendLine("--------------------------------------------------------------------------");
            }

            return sb.ToString();
        }

        public static string GetTrainInfo(Train train)
        {
            var sb = new StringBuilder();
            sb.AppendLine("Название поезда: " + train.Name);
            sb.AppendLine("Кол-во вагонов: " + train.Wagons.Count);
            sb.AppendLine("Длина поезда: " + train.Length + "м");
            sb.AppendLine("\r\nСамый длинный вагон: " + train.FindLongestWagon().ToString());
            sb.AppendLine("\r\nСамый короткий вагон: " + train.FindShortestWagon().ToString());
            sb.AppendLine("\r\nВес поезда: " + train.TotalWeight.ToString("f2") + " т");
            sb.AppendLine("Максимальная скорость: " + train.MaxSpeed.ToString("f1") + " км/ч");

            return sb.ToString();
        }

        public static void ShowTrainInfoWF(Train train, RichTextBox tb)
        {

            tb.AppendText("\nДлина поезда: " + train.Length + "м");
            tb.AppendText("\nСамый длинный вагон:\n" + train.FindLongestWagon().ToString());
            tb.AppendText("\nСамый короткий вагон:\n" + train.FindShortestWagon().ToString());
            tb.AppendText("\nВес поезда: " + train.TotalWeight.ToString("f2") + " т");
            tb.AppendText("\nМаксимальная скорость: " + train.MaxSpeed.ToString("f1") + " км/ч");
        }

        public static void ShowDepoInfoWF(Depo depo, RichTextBox tb)
        {
            for (int i = 0; i < depo.Trains.Count; i++)
            {
                tb.AppendText($"\n\nПоезд №{i + 1}: \n");
                ShowTrainInfoWF(depo[i],tb);
                tb.AppendText("--------------------------------------------------------------------------");
            }
        }
    }

}
