using RailwayTransport;
using RailwayTransport.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Diagnostics.Contracts;

namespace Client
{
    
    internal class Network
    {
        public TcpClient Client;
        public Stream currentStream;
        
        //задать соединение с сервером депо
        //добавить методы для конвертирования в байты и обратно
        //Большая проблема с ине=терфейсом вагона. Нельзя преобразовать
        public Network()
        {
            IPEndPoint endpoint = IPEndPoint.Parse("127.0.0.1:8080");
            Client = new TcpClient(endpoint);
            
        }
        public bool connect(string targetIPe)
        {
            
            try
            {
                Client.Connect(IPEndPoint.Parse(targetIPe));
                currentStream = Client.GetStream();
            }
            catch
            {
                return false;
            }
            return true;
            //Client.Connect(IPEndPoint.Parse(targetIPe));
            //currentStream = Client.GetStream();
        }
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
