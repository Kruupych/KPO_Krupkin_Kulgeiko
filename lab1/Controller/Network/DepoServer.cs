using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace RailwayTransport.Controller.Network
{
    public class DepoMessageEventArgs : EventArgs
    {
        public string Message { get; set; }
        public TcpClient Client { get; set; }

        public DepoMessageEventArgs(string message, TcpClient client)
        {
            Message = message;
            Client = client;
        }
    }

    public class DepoServer
    {
        private TcpListener tcpListener;
        private List<TcpClient> clients = new List<TcpClient>();

        public delegate void DepoMessageEventHandler(object sender, DepoMessageEventArgs e);
        public event DepoMessageEventHandler OnMessageRecieved;

        public DepoServer()
        {
            tcpListener = new TcpListener(IPAddress.Any, 33331);
            tcpListener.Server.ReceiveBufferSize = 1024000;
        }

        public async Task Start()
        {
            tcpListener.Start();
            Debug.WriteLine("Depo server started...");

            while (true)
            {
                TcpClient client = await tcpListener.AcceptTcpClientAsync();
                clients.Add(client);

                Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClient));
                clientThread.Start(client);
            }

        }

        private void HandleClient(object obj)
        {
            TcpClient client = (TcpClient)obj;
            NetworkStream stream = client.GetStream();

            try
            {
                while (true)
                {
                    byte[] sizeBuffer = new byte[4];
                    int bytesRead = stream.Read(sizeBuffer, 0, sizeBuffer.Length);
                    int messageSize = BitConverter.ToInt32(sizeBuffer, 0);

                    byte[] bytes = new byte[messageSize];
                    int totalBytesRead = 0;

                    while (totalBytesRead < messageSize)
                    {
                        bytesRead = stream.Read(bytes, totalBytesRead, bytes.Length - totalBytesRead);
                        totalBytesRead += bytesRead;
                    }

                    string receivedData = Encoding.UTF8.GetString(bytes, 0, totalBytesRead);

                    ProcessClientMessage(receivedData, client);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                clients.Remove(client);
                client.Close();
            }
        }

        private void ProcessClientMessage(string message, TcpClient client)
        {
            OnMessageRecieved?.Invoke(this, new DepoMessageEventArgs(message, client));
        }

        public async Task BroadcastTrains(List<Train> trains)
        {
            string serializedTrains = View.RailwaySerializer.SerializeTrainsList(trains);

            foreach (var client in clients)
            {
                SendDataToClient(Commands.AVAILABLE_TRAINS + serializedTrains, client);
            }
        }

        public void SendTrains(List<Train> trains, TcpClient client)
        {
            string serializedTrains = View.RailwaySerializer.SerializeTrainsList(trains);

            SendDataToClient(Commands.AVAILABLE_TRAINS + serializedTrains, client);
        }
        
        public void SendAuthAnswer(bool success, TcpClient client)
        {
            SendDataToClient(Commands.AUTH_RESPONSE + success, client);
        }

        private void SendDataToClient(string data, TcpClient client)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(data);
            byte[] bufferSize = BitConverter.GetBytes(buffer.Length);

            NetworkStream stream = client.GetStream();
            stream.Write(bufferSize, 0, bufferSize.Length); // Сначала отправляем размер
            stream.Write(buffer, 0, buffer.Length); // Затем отправляем данные
        }
    }
}
