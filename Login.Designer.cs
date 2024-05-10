namespace Client_Project
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label2 = new Label();
            useName_textBox = new TextBox();
            loginBtn = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Cooper Black", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(611, 172);
            label2.Name = "label2";
            label2.Size = new Size(147, 29);
            label2.TabIndex = 1;
            label2.Text = "User Name";
            // 
            // useName_textBox
            // 
            useName_textBox.BackColor = SystemColors.HighlightText;
            useName_textBox.BorderStyle = BorderStyle.None;
            useName_textBox.CharacterCasing = CharacterCasing.Upper;
            useName_textBox.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            useName_textBox.ForeColor = SystemColors.InactiveCaptionText;
            useName_textBox.ImeMode = ImeMode.Off;
            useName_textBox.Location = new Point(555, 225);
            useName_textBox.Margin = new Padding(3, 2, 3, 2);
            useName_textBox.Multiline = true;
            useName_textBox.Name = "useName_textBox";
            useName_textBox.PlaceholderText = "Enter Your Name Here";
            useName_textBox.Size = new Size(259, 50);
            useName_textBox.TabIndex = 2;
            useName_textBox.TextAlign = HorizontalAlignment.Center;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.Lime;
            loginBtn.FlatStyle = FlatStyle.Popup;
            loginBtn.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = Color.White;
            loginBtn.Location = new Point(610, 318);
            loginBtn.Margin = new Padding(3, 2, 3, 2);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(144, 52);
            loginBtn.TabIndex = 3;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Showcard Gothic", 36F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Lime;
            label3.Location = new Point(214, 9);
            label3.Name = "label3";
            label3.Size = new Size(382, 60);
            label3.TabIndex = 4;
            label3.Text = "Guess And Win";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(826, 491);
            Controls.Add(label3);
            Controls.Add(loginBtn);
            Controls.Add(useName_textBox);
            Controls.Add(label2);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MaximumSize = new Size(842, 530);
            MinimumSize = new Size(842, 530);
            Name = "Login";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox useName_textBox;
        private Button loginBtn;
        private Label label3;
    }
}
