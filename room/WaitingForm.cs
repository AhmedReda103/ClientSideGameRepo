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
    public partial class WaitingForm : Form
    {
        Client client;
        internal WaitingForm(Client client)
        {
            InitializeComponent();
            this.client = client;

        }

        private void handleResponseFromServer(string message)
        {
            string[] response = message.Split(";");
            Debug.WriteLine($"   PLAYER2REQUESTTOJOIN  ------- {response[0]}");

            Debug.WriteLine("responseFromServer come from server in Waiting Form =" + response[0]);


            if (response[0] == Utilities.ROOMDELETEDSUCESSFULLY)
            {
                MessageBox.Show("Room Deleted Successfully");
            }
            else if (response[0] == Utilities.PLAYER2REQUESTTOJOIN)
            {
                Debug.WriteLine("i am in PLAYER2REQUESTTOJOIN ");
                string[] player2Name_idRoom = response[1].Split(",");
                string player2Name = player2Name_idRoom[0];
                string roomId = player2Name_idRoom[1];
                int player2Id = int.Parse(player2Name_idRoom[2]);

                Debug.WriteLine("player two id that join to room = " + player2Id);

                showDialogForStratingRoom(player2Name, roomId, player2Id);
            }
            else if (response[0] == Utilities.PLAYGAME)
            {
                Debug.WriteLine($"Iam in WAITING FORM RESPOSE TO REQUEST PLAY FORM AND MY ID IS {client.clientId} ");

                if (IsHandleCreated)
                {
                    if (InvokeRequired)
                        Invoke(() => this.Close());
                }
               
            }
        }


        private void showDialogForStratingRoom(string player2Name, string roomId, int player2Id)
        {
            DialogResult result = MessageBox.Show($"{player2Name} Want To Join Your Room{roomId}", "Join Request", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            // Check the result
            if (result == DialogResult.OK)
            {

                client.sendData($"{Utilities.STARTGAME};{player2Name},{roomId},{client.clientId},{player2Id}");

                Debug.WriteLine($"Operation continued.{client.clientId}");

            }
            else if (result == DialogResult.Cancel)
            {
                Debug.WriteLine("Operation canceled.");
            }
        }



        private void playGame(int roomId, string wordArray)
        {
            GameForm gameForm = new GameForm(client, roomId,wordArray);
            gameForm.Show();
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            string deleteRequest = $"{Utilities.DELETEROOM};{client.clientId}";
            Debug.WriteLine($"i am the client i want to  detele{client.clientId}");

            client.sendData(deleteRequest);
            this.Close();

        }

        private void WaitingForm_Load(object sender, EventArgs e)
        {
            this.client.SendResponse += handleResponseFromServer;
        }
    }
}
