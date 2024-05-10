namespace Client_Project
{
    partial class WatchForm
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
            watchFlowLayoutPanel = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // watchFlowLayoutPanel
            // 
            watchFlowLayoutPanel.AllowDrop = true;
            watchFlowLayoutPanel.AutoScroll = true;
            watchFlowLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            watchFlowLayoutPanel.Location = new Point(43, 59);
            watchFlowLayoutPanel.Margin = new Padding(3, 2, 3, 2);
            watchFlowLayoutPanel.Name = "watchFlowLayoutPanel";
            watchFlowLayoutPanel.Size = new Size(819, 444);
            watchFlowLayoutPanel.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(444, 20);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Ravie", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(257, 9);
            label2.Name = "label2";
            label2.Size = new Size(375, 43);
            label2.TabIndex = 3;
            label2.Text = "Running Rooms ";
            // 
            // WatchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(901, 527);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(watchFlowLayoutPanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "WatchForm";
            Text = "WatchForm";
            Load += WatchForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel watchFlowLayoutPanel;
        private Label label1;
        private Label label2;
    }
}