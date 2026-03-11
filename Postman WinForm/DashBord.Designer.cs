namespace Postman_WinForm
{
    partial class DashBord
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
            HeadLabel = new Label();
            ResultsText = new TextBox();
            CallApi = new Button();
            statusStrip1 = new StatusStrip();
            SystemStatus = new ToolStripStatusLabel();
            CallLabel = new Label();
            ResultsLabel = new Label();
            UrlText = new TextBox();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // HeadLabel
            // 
            HeadLabel.AutoSize = true;
            HeadLabel.Font = new Font("Segoe UI Black", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HeadLabel.Location = new Point(83, 34);
            HeadLabel.Margin = new Padding(5, 0, 5, 0);
            HeadLabel.Name = "HeadLabel";
            HeadLabel.Size = new Size(384, 70);
            HeadLabel.TabIndex = 0;
            HeadLabel.Text = "Posman clone";
            // 
            // ResultsText
            // 
            ResultsText.Location = new Point(66, 350);
            ResultsText.Margin = new Padding(5);
            ResultsText.Multiline = true;
            ResultsText.Name = "ResultsText";
            ResultsText.ReadOnly = true;
            ResultsText.ScrollBars = ScrollBars.Both;
            ResultsText.Size = new Size(889, 541);
            ResultsText.TabIndex = 3;
            // 
            // CallApi
            // 
            CallApi.Location = new Point(1098, 109);
            CallApi.Margin = new Padding(5);
            CallApi.Name = "CallApi";
            CallApi.Size = new Size(222, 61);
            CallApi.TabIndex = 4;
            CallApi.Text = "Go";
            CallApi.UseVisualStyleBackColor = true;
            CallApi.Click += CallApi_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { SystemStatus });
            statusStrip1.Location = new Point(0, 896);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(2, 0, 25, 0);
            statusStrip1.Size = new Size(1265, 32);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // SystemStatus
            // 
            SystemStatus.Name = "SystemStatus";
            SystemStatus.Size = new Size(60, 25);
            SystemStatus.Text = "Redey";
            // 
            // CallLabel
            // 
            CallLabel.AutoSize = true;
            CallLabel.Location = new Point(12, 104);
            CallLabel.Name = "CallLabel";
            CallLabel.Size = new Size(76, 45);
            CallLabel.TabIndex = 6;
            CallLabel.Text = "URL\r\n";
            // 
            // ResultsLabel
            // 
            ResultsLabel.AutoSize = true;
            ResultsLabel.Location = new Point(66, 312);
            ResultsLabel.Name = "ResultsLabel";
            ResultsLabel.Size = new Size(120, 45);
            ResultsLabel.TabIndex = 7;
            ResultsLabel.Text = "Results\r\n";
            // 
            // UrlText
            // 
            UrlText.Location = new Point(94, 114);
            UrlText.Name = "UrlText";
            UrlText.Size = new Size(996, 50);
            UrlText.TabIndex = 8;
            // 
            // DashBord
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1265, 928);
            Controls.Add(UrlText);
            Controls.Add(ResultsLabel);
            Controls.Add(CallLabel);
            Controls.Add(statusStrip1);
            Controls.Add(CallApi);
            Controls.Add(ResultsText);
            Controls.Add(HeadLabel);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "DashBord";
            Text = "PostMan by avrum indig";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeadLabel;
        private Label label2;
        private TextBox textBox1;
        private TextBox ResultsText;
        private Button CallApi;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel SystemStatus;
        private Label CallLabel;
        private Label ResultsLabel;
        private TextBox UrlText;
    }
}
