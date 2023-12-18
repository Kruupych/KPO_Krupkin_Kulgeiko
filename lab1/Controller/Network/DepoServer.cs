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
                    byte[] bytes = new byte[1024];
                    int bytesRead = stream.Read(bytes, 0, bytes.Length);
                    string data = Encoding.ASCII.GetString(bytes, 0, bytesRead);

                    ProcessClientMessage(data, client);
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

        private async Task SendDataToClient(string data, TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            await stream.WriteAsync(buffer, 0, buffer.Length);
        }
    }
}
