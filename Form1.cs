using System.Net.Sockets;
using System.Net;
using System.Diagnostics;
using System.Text;
using System.Net.Http;
using System.ComponentModel;
using Microsoft.VisualBasic.Logging;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Client_Project
{
  

    public partial class Form1 : Form
    {

        Client client;

        string response = ""; 

        public Form1()
        {
            InitializeComponent();            
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            client = new Client();
            client.SendResponse += handleResponseFromServer; 
            string userName = useName_textBox.Text.Trim(); 
            if (userName != null)
            {
                string info = $"{Utilities.LOGINREQUEST};{userName}";
                client.clientName = userName ;
                var task2 = Task.Run(() => client.receiveData());
                var task1 = Task.Run(() => client.sendData(info));
            }

            Debug.WriteLine("iam lising to response value from login" );
           // response = client.responseFromServer;

        }

        private void handleResponseFromServer(string response)
        {
            Debug.WriteLine("responseFromServer come from server in form1 =" + response);
            string[] data = response.Split(';');    
            if (data[0] == Utilities.LOGINSUCESS)
            {
                client.clientId = data[1];
                Debug.WriteLine("i am the client and my id = " + client.clientId);
                Invoke(() => createHome());
            }
        }

  

        void createHome()
        {
            Debug.WriteLine("iam the client and my id in Home Dialog is =  " + client.clientId);
            Home create = new Home(client);
            create.Show();
            //this.Hide();
        }



        public static void CloseConnection()
        { 
        }



    }
}
