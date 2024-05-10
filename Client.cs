using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client_Project
{
    internal class Client
    {
        NetworkStream clientStream;
        BinaryReader clientReader;
        BinaryWriter clientWriter;
        string serverIp = "127.0.0.1";
        int port = 15000;
        public TcpClient client;

        public string clientId { get; set; }

        public delegate void ResponseEventHandler(string message);
        public event ResponseEventHandler SendResponse;

        //public String responseFromServer { get { return responseFromServer; }  }
        public String responseFromServer { get; set;  }

        public string clientName = ""; 
        

        public Client() {

            try
            {
                Debug.WriteLine("connected to server");
                client = new TcpClient(serverIp, port);
                clientStream = client.GetStream();
                clientReader = new BinaryReader(clientStream);
                clientWriter = new BinaryWriter(clientStream);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        internal void sendData( string message )
        {
            try
            {
                if (client.Connected )
                {
                    clientWriter.Write(message);
                }
                else
                {
                    MessageBox.Show("Sending Failed");
                }
            }catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }


        internal void receiveData()
        {
            while (client.Connected)
            {
                try
                {
                    responseFromServer = clientReader.ReadString();
                    SendResponse(responseFromServer); 
                    Debug.WriteLine("iam in received data fun in client = " + responseFromServer);
                }
                catch (IOException ex)
                {
                    Application.ExitThread();
                    Environment.Exit(Environment.ExitCode);
                    MessageBox.Show(" Connection Disconnected");
                }
            }
        }




    }
}
