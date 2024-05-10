namespace Client_Project
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            useName_textBox = new TextBox();
            loginBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(249, 60);
            label1.Name = "label1";
            label1.Size = new Size(241, 37);
            label1.TabIndex = 0;
            label1.Text = "Guss The Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Script MT Bold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(65, 181);
            label2.Name = "label2";
            label2.Size = new Size(117, 28);
            label2.TabIndex = 1;
            label2.Text = "User Name";
            // 
            // useName_textBox
            // 
            useName_textBox.Location = new Point(249, 184);
            useName_textBox.Name = "useName_textBox";
            useName_textBox.Size = new Size(274, 27);
            useName_textBox.TabIndex = 2;
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(301, 287);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(135, 38);
            loginBtn.TabIndex = 3;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(loginBtn);
            Controls.Add(useName_textBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox useName_textBox;
        private Button loginBtn;
    }
}
