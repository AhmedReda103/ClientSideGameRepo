
using System.Diagnostics;


namespace Client_Project
{
    public partial class RoomsView : Form
    {
        string rooms;

        string roomId;
        string roomCategory;
        string playerId;
        string playerName;
        Client client;

        internal RoomsView(string rooms, Client client)
        {
            InitializeComponent();
            Debug.WriteLine("iam in constructor of room view to know it called twice or not "); 
            this.rooms = rooms;
            this.client = client;
            Debug.WriteLine("all rooms *****" + rooms);
            this.client.SendResponse += handleResponseFromServer;
            createRoomItem(rooms);
        }

        private void handleResponseFromServer(string message)
        {
            string[] response = message.Split(";");
            if (IsHandleCreated)
            {
                if (response[0] == Utilities.PLAYGAMEINROOMVIEWSHOW)
                {
                    Debug.WriteLine($"Iam in WAITING FORM RESPOSE TO REQUEST PLAY FORM AND MY ID IS {client.clientId} ");
                    string[] secondPart = response[1].Split(","); 
                    int roomId = int.Parse(secondPart[0]);
                    string wordArray = secondPart[1];
                    Invoke(() => playGame(roomId , wordArray));
                }
                else if (response[0] == Utilities.UPDATEROOMSVIEW)
                {
                    if (response[1] != "")
                    {
                        Invoke(()=>updateUI(response[1]));
                    }
                    else
                    {
                        Invoke(()=>this.flowLayoutPanel1.Controls.Clear());
                    }
                }
                else if (response[0] == Utilities.ROOMCOMPLETED)
                {
                    int roomId = int.Parse(response[1]);
                    Invoke(()=>updateJoinBtn(roomId));
                }
                else if (response[0] == Utilities.UPDATEALLROOMSCOMPLETED)
                {
                    string[] roomCompeltedIDS = response[1].Split(':');
                    
                    foreach(string roomCompeltedID in roomCompeltedIDS)
                    {
                        if (roomCompeltedID != "" && roomCompeltedID !=null)
                        {
                            Invoke(()=>updateJoinBtn(int.Parse(roomCompeltedID)));
                        }
                    }
                }
            }
        }

        private void updateJoinBtn(int changedRoom)
        {
          string roomCompeted = "room ID : " + changedRoom;

            foreach (Control control in this.flowLayoutPanel1.Controls)
            {
                if (control is GroupBox )
                {
                    Label roomId = control.Controls[0] as Label;
                    if (roomId.Text.ToString() == roomCompeted.ToString())
                    {
                        (control.Controls[4] as Label).Text = "RUNNING"; 
                        (control.Controls[4] as Label).ForeColor = Color.Green; 

                        (control.Controls[3] as Button ).Enabled = false ;
                    }
                }
            }
        }


        private void updateUI(string response)
        {
            this.flowLayoutPanel1.Controls.Clear();
            createRoomItem(response);
        }

        private void playGame(int roomId, string wordArray)
        {
            GameForm gameForm = new GameForm(client, roomId, wordArray);
            gameForm.Show();
        }

     

        public void createRoomItem(string  rooms)
        {
            string[] createdRooms = rooms.Split(":");

            for (int i = 0; i < createdRooms.Length-1 ; i++)
            {
                string[] room = createdRooms[i].Split(",");

                roomId = room[0];
                roomCategory = room[1];
                playerId = room[2];
                playerName = room[3];

                Debug.WriteLine("room id  = " + roomId + " room category = " + roomCategory);

                GroupBox roomGroupBox = new GroupBox();
                roomGroupBox.Text = "Play Area";
                roomGroupBox.ForeColor = Color.White;
                roomGroupBox.Font = new System.Drawing.Font("Ravie", 14);
                roomGroupBox.Size = new System.Drawing.Size(270, 180);
                roomGroupBox.Location = new System.Drawing.Point(25, 20);


                Label roomNameLabel = new Label();
                roomNameLabel.Text = "room ID: " + roomId;
                roomNameLabel.ForeColor = Color.White;
                roomNameLabel.Font = new System.Drawing.Font("Ravie", 10);
                roomNameLabel.Location = new System.Drawing.Point(25, 35);
                roomNameLabel.AutoSize = true;

                Label roomCategoryLabel = new Label();
                roomCategoryLabel.Text = "Type: " +roomCategory;
                roomCategoryLabel.Font = new System.Drawing.Font("Ravie", 10);
                roomCategoryLabel.Location = new System.Drawing.Point(25, 55);
                roomCategoryLabel.AutoSize = true;

                Label playerOneLabel = new Label();
                playerOneLabel.Text = "Owner: " +  playerName;
                playerOneLabel.Font = new System.Drawing.Font("Ravie", 10);
                playerOneLabel.Location = new System.Drawing.Point(25, 75);
                playerOneLabel.AutoSize = true;


                Label roomLabelState = new Label();
                roomLabelState.Text = "Status: Waiting";
                roomLabelState.ForeColor = Color.Yellow;
                roomLabelState.Font = new System.Drawing.Font("Ravie", 10);
                roomLabelState.Location = new System.Drawing.Point(25, 95);
                roomLabelState.AutoSize = true;


                CustomButton joinBtn = new CustomButton();
                joinBtn.Text = "Join";
                joinBtn.Font = new System.Drawing.Font("Ravie", 12);
                joinBtn.Height = 40;
                joinBtn.Width = 100;
                joinBtn.BackColor = Color.Olive;
                joinBtn.ForeColor = Color.White;
                joinBtn.Location = new System.Drawing.Point(100, 135);
                joinBtn.Click += clickJoinToPlay;
                joinBtn.roomId = roomId;



                roomGroupBox.Controls.Add(roomNameLabel);
                roomGroupBox.Controls.Add(roomCategoryLabel);
                roomGroupBox.Controls.Add(playerOneLabel);
                roomGroupBox.Controls.Add(joinBtn);
                roomGroupBox.Controls.Add(roomLabelState);


                this.flowLayoutPanel1.AutoScroll = true;

                this.flowLayoutPanel1.Controls.Add(roomGroupBox);

            }

        }

        private void clickJoinToPlay(object? sender, EventArgs e)
        {
            string request = $"{Utilities.REQUESTTOJOINROOM};{(((CustomButton)sender).roomId)},{client.clientId}";
            Debug.WriteLine("iam request to join method = " + request);
            client.sendData(request);
        }

        private void RoomsView_Load(object sender, EventArgs e)
        {
           
        }
    }
}
