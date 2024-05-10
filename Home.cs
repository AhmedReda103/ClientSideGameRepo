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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Client_Project
{
    public partial class Home : Form
    {

        Client client;

        internal Home(Client client)
        {
            InitializeComponent();
            this.client = client;
            client.SendResponse += handleResponseEvent;
        }


        private void configurateRoom_Click(object sender, EventArgs e)
        {
            Invoke(() => openConfigurationRoom());
        }

        private void openConfigurationRoom()
        {
            CreateRoom cr = new CreateRoom(client);
            cr.Show();

        }

        private void joinRoomBtn_Click(object sender, EventArgs e)
        {
            client.sendData(Utilities.JOINROOM);
        }

        private void handleResponseEvent(string response)
        {

            string[] data = response.Split(';');
            Debug.WriteLine("responseFromServer come from server in Home Form =" + data[0]);

            if (data[0] == Utilities.ROOMJOINEDSUCESSFULLY)
            {
                /*string speratedRooms = ""; 
                string[] rooms = data[1].Split(":");
                for(int i = 1; i < rooms.Length; i++)
                {
                    speratedRooms+= rooms[i].Trim();
                }
*/
                Invoke(() => openRoomView(data[1]));
            }
            else if (data[0] == Utilities.STARTWAITINGFROMHOME)
            {
                // Invoke(()=> showWatingForm());
            }
            else if (data[0] == Utilities.PLAYGAME)
            {
                string[] res = data[1].Split(",");
                int roomId = int.Parse(res[0]);
                string wordArray = res[1];
                Invoke(() => showGame(roomId , wordArray));
            }
            else if (data[0]==Utilities.WATCHRUNNINGROOMSRESPONSE)
            {
                string runningRooms =  data[1] ;
                Invoke(() => showRunningRooms(client, runningRooms));
            }

        }


        private void showRunningRooms(Client client, string runningRooms)
        {
            if(runningRooms!="" && runningRooms.Length > 0)
            { 
                WatchForm watchForm = new WatchForm(runningRooms, client);
                watchForm.Show();
            }
            else
            {
                MessageBox.Show("NO Room To Watch");
            }
           
        }


        private void openRoomView(string rooms)
        {
            if (rooms != "" && rooms.Length > 0)
            {
                 RoomsView roomView = new RoomsView(rooms, client);
                 roomView.Show();
            }
            else
            {
                MessageBox.Show("no rooms created");
            }
        }

        private void showGame(int roomId , string wordArray)
        {
            GameForm game = new GameForm(client, roomId , wordArray );
            game.Show();
        }



     

        private void watchBtn_Click(object sender, EventArgs e)
        {
            client.sendData(Utilities.WATCHRUNNINGROOMSREQUEST);
        }
    }
}
