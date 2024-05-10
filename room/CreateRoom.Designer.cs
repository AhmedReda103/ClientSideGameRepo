namespace Client_Project
{
    partial class CreateRoom
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
            radioButton1_rnd = new RadioButton();
            radioButton2_cat1 = new RadioButton();
            radioButton3_cat2 = new RadioButton();
            radioButton4_cat3 = new RadioButton();
            saveRoom = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(126, 20);
            label1.Name = "label1";
            label1.Size = new Size(341, 40);
            label1.TabIndex = 0;
            label1.Text = "Custom your Room";
            // 
            // radioButton1_rnd
            // 
            radioButton1_rnd.AutoSize = true;
            radioButton1_rnd.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Italic);
            radioButton1_rnd.ForeColor = Color.White;
            radioButton1_rnd.Location = new Point(147, 99);
            radioButton1_rnd.Margin = new Padding(3, 2, 3, 2);
            radioButton1_rnd.Name = "radioButton1_rnd";
            radioButton1_rnd.Size = new Size(108, 27);
            radioButton1_rnd.TabIndex = 1;
            radioButton1_rnd.TabStop = true;
            radioButton1_rnd.Text = "Random";
            radioButton1_rnd.UseVisualStyleBackColor = true;
            // 
            // radioButton2_cat1
            // 
            radioButton2_cat1.AutoSize = true;
            radioButton2_cat1.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Italic);
            radioButton2_cat1.ForeColor = Color.White;
            radioButton2_cat1.Location = new Point(146, 131);
            radioButton2_cat1.Margin = new Padding(3, 2, 3, 2);
            radioButton2_cat1.Name = "radioButton2_cat1";
            radioButton2_cat1.Size = new Size(101, 27);
            radioButton2_cat1.TabIndex = 2;
            radioButton2_cat1.TabStop = true;
            radioButton2_cat1.Text = "Science";
            radioButton2_cat1.UseVisualStyleBackColor = true;
            // 
            // radioButton3_cat2
            // 
            radioButton3_cat2.AutoSize = true;
            radioButton3_cat2.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Italic);
            radioButton3_cat2.ForeColor = Color.White;
            radioButton3_cat2.Location = new Point(147, 165);
            radioButton3_cat2.Margin = new Padding(3, 2, 3, 2);
            radioButton3_cat2.Name = "radioButton3_cat2";
            radioButton3_cat2.Size = new Size(91, 27);
            radioButton3_cat2.TabIndex = 3;
            radioButton3_cat2.TabStop = true;
            radioButton3_cat2.Text = "Sport";
            radioButton3_cat2.UseVisualStyleBackColor = true;
            // 
            // radioButton4_cat3
            // 
            radioButton4_cat3.AutoSize = true;
            radioButton4_cat3.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Italic);
            radioButton4_cat3.ForeColor = Color.White;
            radioButton4_cat3.Location = new Point(147, 195);
            radioButton4_cat3.Margin = new Padding(3, 2, 3, 2);
            radioButton4_cat3.Name = "radioButton4_cat3";
            radioButton4_cat3.Size = new Size(113, 27);
            radioButton4_cat3.TabIndex = 4;
            radioButton4_cat3.TabStop = true;
            radioButton4_cat3.Text = "History";
            radioButton4_cat3.UseVisualStyleBackColor = true;
            // 
            // saveRoom
            // 
            saveRoom.BackColor = Color.Olive;
            saveRoom.FlatStyle = FlatStyle.Popup;
            saveRoom.Font = new Font("Showcard Gothic", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            saveRoom.ForeColor = Color.White;
            saveRoom.Location = new Point(147, 296);
            saveRoom.Margin = new Padding(3, 2, 3, 2);
            saveRoom.Name = "saveRoom";
            saveRoom.Size = new Size(298, 42);
            saveRoom.TabIndex = 5;
            saveRoom.Text = "Save Room";
            saveRoom.UseVisualStyleBackColor = false;
            saveRoom.Click += saveRoom_Click;
            // 
            // CreateRoom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(615, 383);
            Controls.Add(saveRoom);
            Controls.Add(radioButton4_cat3);
            Controls.Add(radioButton3_cat2);
            Controls.Add(radioButton2_cat1);
            Controls.Add(radioButton1_rnd);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MaximumSize = new Size(631, 422);
            MinimizeBox = false;
            MinimumSize = new Size(631, 422);
            Name = "CreateRoom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateRoom";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton radioButton1_rnd;
        private RadioButton radioButton2_cat1;
        private RadioButton radioButton3_cat2;
        private RadioButton radioButton4_cat3;
        private Button saveRoom;
    }
}