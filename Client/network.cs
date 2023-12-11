using RailwayTransport;
using RailwayTransport.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    internal class network
    {
        //задать соединение с сервером депо
        //сделать статическим??
        public List<Train> getTrainsList()
        {
            var depoController = new DepoController();
            var trains = depoController.CreateTrains(5);
            return trains;
        }
        //public string[] getWagonsList()
        //{

        //}
    }
}
