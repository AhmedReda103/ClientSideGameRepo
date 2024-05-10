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
    public partial class WatchForm : Form
    {

        Client client;
        string rooms;

        string roomId;
        string roomCategory;
        string player1Id;
        string player2Id;
        string player1Name;
        string player2Name;

        internal WatchForm(string rooms, Client client)
        {
            InitializeComponent();
            Debug.WriteLine("iam in constructor of room view to know it called twice or not ");
            this.rooms = rooms;
            this.client = client;
        
        }


        private void handleResponseFromServer(string message)
        {
            string[] response = message.Split(";");
            if (IsHandleCreated)
            {
                if (response[0] == Utilities.WATCHROOMRESPOSE)
                {
                    Debug.WriteLine($"Iam in Watch FORM RESPOSE  AND MY ID IS {client.clientId}");
                    string [] res = response[1].Split(",");
                    int roomId = int.Parse(res[0]);
                    string word = res[1];
                    //Invoke(() => this.Hide());
                    Invoke(() => showWatcherGameForm(roomId,word));
                }
                else if (response[0]==Utilities.UPDATEWATCHERROOMSVIEW)
                {
                    if (response[1] != "")
                    {
                        Invoke(() => updateUI(response[1]));
                    }
                    else
                    {
                        Invoke(() => this.watchFlowLayoutPanel.Controls.Clear());
                    }
                }
            }

        }

        private void updateUI(string response)
        {
            string[] allRooms = response.Split(":");
            this.watchFlowLayoutPanel.Controls.Clear();
            createRoomItem(allRooms);
        }


        private void showWatcherGameForm(int roomId , string wordArray)
        {
            WatcherGameForm game = new WatcherGameForm(client, roomId , wordArray );
            game.Show();
        }



        void createRoomItem(string[] rooms)
            {
                for (int i = 0; i < rooms.Length-1 ; i++)
                {
                    string[] room = rooms[i].Split(",");

                  
                        roomId = room[0];
                        roomCategory = room[1];
                        player1Name = room[2];
                        player1Id = room[3];
                        player2Name = room[4];
                        player2Id = room[5];

                        Debug.WriteLine("room id  = " + roomId + " room category = " + roomCategory);

                        GroupBox roomGroupBox = new GroupBox();
                        roomGroupBox.Text = "Reviewing";
                        roomGroupBox.Font = new System.Drawing.Font("Ravie", 12);
                        roomGroupBox.ForeColor = Color.White;   
                        roomGroupBox.Size = new System.Drawing.Size(270, 180);
                        roomGroupBox.Location = new System.Drawing.Point(50, 20);


                        Label roomNameLabel = new Label();
                        roomNameLabel.Text = "room ID :" +roomId;
                        roomNameLabel.Font = new System.Drawing.Font("Ravie", 10);
                        roomNameLabel.ForeColor = Color.White;  
                        roomNameLabel.Location = new System.Drawing.Point(25, 35);
                        roomNameLabel.AutoSize = true;

                        Label roomCategoryLabel = new Label();
                        roomCategoryLabel.Text = "Type: " + roomCategory;
                        roomCategoryLabel.Font = new System.Drawing.Font("Ravie", 10);
                        roomCategoryLabel.ForeColor = Color.White;
                        roomCategoryLabel.Location = new System.Drawing.Point(25, 50);
                        roomCategoryLabel.AutoSize = true;

                        Label playerOneLabel = new Label();
                        playerOneLabel.Text = "player one : "+ player1Name;
                        playerOneLabel.Font = new System.Drawing.Font("Ravie", 10);
                        playerOneLabel.ForeColor = Color.White;
                        playerOneLabel.Location = new System.Drawing.Point(25, 65);
                        playerOneLabel.AutoSize = true;

                        Label playerTwoLabel = new Label();
                        playerTwoLabel.Text = "player two : "+ player2Name;
                        playerTwoLabel.Font = new System.Drawing.Font("Ravie", 10);
                        playerTwoLabel.ForeColor = Color.White;
                        playerTwoLabel.Location = new System.Drawing.Point(25, 80);
                        playerTwoLabel.AutoSize = true;
                    
                        Label roomState = new Label();
                        roomState.Text = "Status: RUNNING";
                        roomState.ForeColor = System.Drawing.Color.LightGreen;
                        roomState.Font = new System.Drawing.Font("Ravie", 10);
                        roomState.Location = new System.Drawing.Point(25, 100);
                        roomState.AutoSize = true;


                        CustomButton watchButton = new CustomButton();
                        watchButton.Text = "Watch";
                        watchButton.Font = new System.Drawing.Font("Arial", 12);
                        watchButton.Location = new System.Drawing.Point(70, 135);
                        watchButton.Height = 40;
                        watchButton.Width = 100;
                        watchButton.BackColor = Color.Olive;
                        watchButton.ForeColor = Color.White;
                        watchButton.Click += clickWatchToPlay;
                        watchButton.roomId = roomId;


                        roomGroupBox.Controls.Add(roomNameLabel);
                        roomGroupBox.Controls.Add(roomCategoryLabel);
                        roomGroupBox.Controls.Add(playerOneLabel);
                        roomGroupBox.Controls.Add(playerTwoLabel);
                        roomGroupBox.Controls.Add(roomState);
                        roomGroupBox.Controls.Add(watchButton);

                        this.watchFlowLayoutPanel.AutoScroll = true;
                        this.watchFlowLayoutPanel.Controls.Add(roomGroupBox);
                }
        }

        private void clickWatchToPlay(object? sender, EventArgs e)
        {
            string request = $"{Utilities.WATCHROOMREQUEST};{(((CustomButton)sender).roomId)},{client.clientId}";
            Debug.WriteLine("iam request to watch method = " + request);
            client.sendData(request);
        }

        void WatchForm_Load(object sender, EventArgs e)
        {
            string[] runningRooms = rooms.Split(":");
            createRoomItem(runningRooms);
            this.client.SendResponse += handleResponseFromServer;
        }
        
    }
}
