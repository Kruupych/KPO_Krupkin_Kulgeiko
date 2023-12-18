﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace RailwayTransport.Controller.Network
{
    public class AvailableTrainsUpdateEventArgs : EventArgs
    {
        List<Train> Trains { get; set; }

        public AvailableTrainsUpdateEventArgs(List<Train> trains)
        {
            Trains = trains;
        }
    }

    public class StationClient
    {
        private TcpClient tcpClient;
        private NetworkStream stream;
        private string stationName;
        private string serverIp;

        private bool authAnswerRecieved;
        private bool authAnswer;

        public delegate void AvailableTrainsUpdateEventHandler(object sender, AvailableTrainsUpdateEventArgs e);
        public event AvailableTrainsUpdateEventHandler OnAvailableTrainsUpdated;

        public StationClient(string serverIp)
        {
            this.serverIp = serverIp;

            tcpClient = new TcpClient();
        }

        public async Task Connect()
        {
            await tcpClient.ConnectAsync(serverIp, 33331);
            stream = tcpClient.GetStream();

            Thread receiveThread = new Thread(ReceiveData);
            receiveThread.Start();

            Console.WriteLine($"{stationName} connected to the depot.");
        }

        private void ReceiveData()
        {
            try
            {
                while (true)
                {
                    byte[] bytes = new byte[1024];
                    int bytesRead = stream.Read(bytes, 0, bytes.Length);
                    string receivedData = Encoding.ASCII.GetString(bytes, 0, bytesRead);
                    ProcessReceivedData(receivedData);
                }
            }
            catch
            {
                tcpClient.Close();
            }
        }

        private void ProcessReceivedData(string data)
        {
            if (data.StartsWith(Commands.AVAILABLE_TRAINS))
            {
                string trainsJson = data.Substring(Commands.AVAILABLE_TRAINS.Length);
                var trains = View.RailwaySerializer.DeserializeTrainsList(trainsJson);
                OnAvailableTrainsUpdated?.Invoke(this, new AvailableTrainsUpdateEventArgs(trains));
            }
            else if (data.StartsWith(Commands.AUTH_RESPONSE))
            {
                authAnswer = bool.Parse(data.Substring(Commands.AUTH_RESPONSE.Length));

                authAnswerRecieved = true;
            }
        }
        
        //Обязательная авторизация
        public async Task<bool> TryAuth(string station, string password)
        {
            string msg = $"{Commands.AUTH_REQUEST}{station};{password}";
            SendData(msg);

            while (authAnswerRecieved) await Task.Delay(100);

            authAnswerRecieved = false;
            if (authAnswer)
            {
                stationName = station;
            }

            return authAnswer;
        }

        public void RequestAvailableTrains()
        {
            SendData(Commands.GET_AVAILABLE_TRAINS);
        }

        public void TrainArrived(Train train)
        {
            string msg = $"{Commands.TRAIN_IN}{stationName};{train.Name}";
            SendData(msg);
        }

        public void TrainDeparted(Train train)
        {
            string trainJson = View.RailwaySerializer.SerializeTrain(train);

            string msg = $"{Commands.TRAIN_OUT}{stationName};{trainJson}";
            SendData(msg);
        }

        public void SendData(string data)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(data);
            stream.Write(bytes, 0, bytes.Length);
        }
    }
}
