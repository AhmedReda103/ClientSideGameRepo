using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_Project
{
    public partial class WatcherGameForm : Form
    {

        Client client;
        int roomId;

        string wordArray = "";


        internal WatcherGameForm(Client client, int roomId, string wordArray)
        {
            InitializeComponent();
            this.roomId = roomId;
            this.client = client;
            this.wordArray = wordArray;
            wordLabel.Visible = true;
        }

        private void handleResponseFromServer(string message)
        {
            string[] response = message.Split(";");
            if (IsHandleCreated)
            {
                if (response[0] == Utilities.CONTINUEPLAYING)
                {
                    string [] result = response[1].Split(",");
                    string wordArray = result[0];
                    Invoke(() => handleWordLabel(wordArray));
                }
                else if (response[0] == Utilities.SWITCHPLAYING)
                {
                    string[] result = response[1].Split(",");
                    string wordArray = result[0];
                    Invoke(() => handleWordLabel(wordArray));
                }
                else if (response[0] == Utilities.WINNINGMESSAGE)
                {
                    var winnerName = response[1];
                    DialogResult d = MessageBox.Show($"{winnerName} win the game", "Game Result" , MessageBoxButtons.OKCancel);
                    if (d == DialogResult.OK)
                    {
                       Invoke(()=>this.Close());
                    }
                }
            }


        }

        private void handleWordLabel(string wordArray)
        {
            wordLabel.Text = wordArray;
        }

        private void WatcherGameForm_Load(object sender, EventArgs e)
        {
            this.client.SendResponse += handleResponseFromServer;
            wordLabel.Text = wordArray;

        }

        private void WatcherGameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var request = $"{Utilities.STOPWATCHING};{roomId},{client.clientId}";
            client.sendData(request); 
        }
    }
}
