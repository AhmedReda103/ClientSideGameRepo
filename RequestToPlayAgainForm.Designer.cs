namespace Client_Project
{
    partial class RequestToPlayAgainForm
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
            label1 = new Label();
            yesBtn = new Button();
            noBtn = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(127, 81);
            label1.Name = "label1";
            label1.Size = new Size(368, 28);
            label1.TabIndex = 0;
            label1.Text = "Do you Want To Play Again ?";
            // 
            // yesBtn
            // 
            yesBtn.BackColor = Color.FromArgb(192, 192, 0);
            yesBtn.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Italic);
            yesBtn.ForeColor = Color.White;
            yesBtn.Location = new Point(127, 154);
            yesBtn.Margin = new Padding(3, 2, 3, 2);
            yesBtn.Name = "yesBtn";
            yesBtn.Size = new Size(105, 41);
            yesBtn.TabIndex = 1;
            yesBtn.Text = "Yes";
            yesBtn.UseVisualStyleBackColor = false;
            yesBtn.Click += yesBtn_Click;
            // 
            // noBtn
            // 
            noBtn.BackColor = Color.FromArgb(192, 192, 0);
            noBtn.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Italic);
            noBtn.ForeColor = Color.White;
            noBtn.Location = new Point(390, 154);
            noBtn.Margin = new Padding(3, 2, 3, 2);
            noBtn.Name = "noBtn";
            noBtn.Size = new Size(105, 41);
            noBtn.TabIndex = 2;
            noBtn.Text = "No";
            noBtn.UseVisualStyleBackColor = false;
            noBtn.Click += noBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(203, 34);
            label2.Name = "label2";
            label2.Size = new Size(75, 23);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // RequestToPlayAgainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(629, 223);
            Controls.Add(label2);
            Controls.Add(noBtn);
            Controls.Add(yesBtn);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MaximumSize = new Size(645, 262);
            MinimizeBox = false;
            MinimumSize = new Size(645, 262);
            Name = "RequestToPlayAgainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RequestToPlayAgainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button yesBtn;
        private Button noBtn;
        private Label label2;
    }
}