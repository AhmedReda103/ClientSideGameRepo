

using System.Diagnostics;


namespace Client_Project
{
    public partial class RequestToPlayAgainForm : Form
    {

        Client client;
        int roomId; 

        internal RequestToPlayAgainForm(string message, Client client , int roomId)
        {
            InitializeComponent();
            this.client = client;
            this.roomId = roomId;
            this.label2.Text = message;
            client.SendResponse += handleResponseEvent;
        }

        private void handleResponseEvent(string message)
        {
            string response = message;
            
        }


        private void yesBtn_Click(object sender, EventArgs e)
        {
            string request = $"{Utilities.ACCEPTREQUESTTOPLAYAGAIN};{roomId},{client.clientId}";
            client.sendData(request); 
            this.Close();
        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            string request = $"{Utilities.REFUSEREQUESTTOPLAYAGAIN};{roomId},{client.clientId}";

            Debug.WriteLine("request to send room id " + request);
            client.sendData(request);
            this.Close();
        }


    }
}
