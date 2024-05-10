namespace Client_Project
{
    partial class WaitingForm
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
            cancelBtn = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(108, 19);
            label1.Name = "label1";
            label1.Size = new Size(386, 23);
            label1.TabIndex = 0;
            label1.Text = "Waiting For Another Player To join ";
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.FromArgb(192, 192, 0);
            cancelBtn.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            cancelBtn.ForeColor = Color.White;
            cancelBtn.Location = new Point(239, 146);
            cancelBtn.Margin = new Padding(3, 2, 3, 2);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(116, 44);
            cancelBtn.TabIndex = 1;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(282, 54);
            label2.Name = "label2";
            label2.Size = new Size(45, 27);
            label2.TabIndex = 2;
            label2.Text = " OR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(123, 91);
            label3.Name = "label3";
            label3.Size = new Size(361, 23);
            label3.TabIndex = 3;
            label3.Text = "cancel and choose room To Join ... ";
            // 
            // WaitingForm
            // 
            AcceptButton = cancelBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(606, 215);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cancelBtn);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MaximumSize = new Size(622, 254);
            MinimizeBox = false;
            MinimumSize = new Size(622, 254);
            Name = "WaitingForm";
            Text = "WaitingForm";
            Load += WaitingForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button cancelBtn;
        private Label label2;
        private Label label3;
    }
}