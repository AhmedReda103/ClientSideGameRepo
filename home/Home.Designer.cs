namespace Client_Project
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            configurateRoom = new Button();
            joinRoomBtn = new Button();
            watchBtn = new Button();
            SuspendLayout();
            // 
            // configurateRoom
            // 
            configurateRoom.BackColor = Color.FromArgb(192, 192, 0);
            configurateRoom.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Italic);
            configurateRoom.ForeColor = Color.White;
            configurateRoom.Location = new Point(235, 62);
            configurateRoom.Margin = new Padding(3, 2, 3, 2);
            configurateRoom.Name = "configurateRoom";
            configurateRoom.Size = new Size(195, 44);
            configurateRoom.TabIndex = 0;
            configurateRoom.Text = "Configuration Room";
            configurateRoom.UseVisualStyleBackColor = false;
            configurateRoom.Click += configurateRoom_Click;
            // 
            // joinRoomBtn
            // 
            joinRoomBtn.BackColor = Color.FromArgb(192, 192, 0);
            joinRoomBtn.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Italic);
            joinRoomBtn.ForeColor = Color.White;
            joinRoomBtn.Location = new Point(235, 172);
            joinRoomBtn.Margin = new Padding(3, 2, 3, 2);
            joinRoomBtn.Name = "joinRoomBtn";
            joinRoomBtn.Size = new Size(195, 44);
            joinRoomBtn.TabIndex = 1;
            joinRoomBtn.Text = "Join Room";
            joinRoomBtn.UseVisualStyleBackColor = false;
            joinRoomBtn.Click += joinRoomBtn_Click;
            // 
            // watchBtn
            // 
            watchBtn.BackColor = Color.FromArgb(192, 192, 0);
            watchBtn.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Italic);
            watchBtn.ForeColor = Color.White;
            watchBtn.Location = new Point(235, 288);
            watchBtn.Margin = new Padding(3, 2, 3, 2);
            watchBtn.Name = "watchBtn";
            watchBtn.Size = new Size(195, 44);
            watchBtn.TabIndex = 2;
            watchBtn.Text = "Watch Room";
            watchBtn.UseVisualStyleBackColor = false;
            watchBtn.Click += watchBtn_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(662, 394);
            Controls.Add(watchBtn);
            Controls.Add(joinRoomBtn);
            Controls.Add(configurateRoom);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MaximumSize = new Size(678, 433);
            MinimumSize = new Size(678, 433);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            ResumeLayout(false);
        }

        #endregion

        private Button configurateRoom;
        private Button joinRoomBtn;
        private Button watchBtn;
    }
}