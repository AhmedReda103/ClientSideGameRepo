using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_Project
{
    public partial class CreateRoom : Form
    {
        string roomCategory="";
        string roomId;
        string playerId; 
        string playerName;

        Client client; 

        internal CreateRoom( Client client)
        {
            InitializeComponent();
            this.client = client;
            client.SendResponse += handleResponseEvent;
        }

        private void handleResponseEvent(string message)
        {
            string [] data = message.Split(';');
  
            if(IsHandleCreated) {
                if (Utilities.ROOMCREATEDSUCESSFULLY == data[0])
                {
                    Invoke(() => showWaitingDialog());
                }
            }
            
        }

        private void showWaitingDialog()
        {
            WaitingForm waitingForm = new WaitingForm(client);
            waitingForm.Show();
            this.Close();
        }

        private void saveRoom_Click(object sender, EventArgs e)
        {
            string roomType = getRoomCategory();
            string data = $"{Utilities.CONFIGUREROOM};{roomType},{client.clientId}"; 
            this.client.sendData(data);
            
            
        }



        string getRoomCategory()
        {
            if (radioButton1_rnd.Checked == true)
            {
                roomCategory = radioButton1_rnd.Text;
            }
            else if (radioButton2_cat1.Checked == true)
            {
                roomCategory = radioButton2_cat1.Text;
            }
            else if (radioButton3_cat2.Checked == true)
            {
                roomCategory = radioButton3_cat2.Text;
            }
            else
            {
                roomCategory = radioButton4_cat3.Text;
            }
            return roomCategory;
        }
    }
}
