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
            CallApi = new Button();
            statusStrip1 = new StatusStrip();
            SystemStatus = new ToolStripStatusLabel();
            CallLabel = new Label();
            UrlText = new TextBox();
            MethodNav = new ComboBox();
            CallData = new TabControl();
            tabBody = new TabPage();
            BodyText = new TextBox();
            tabResults = new TabPage();
            ResultsText = new TextBox();
            statusStrip1.SuspendLayout();
            CallData.SuspendLayout();
            tabBody.SuspendLayout();
            tabResults.SuspendLayout();
            SuspendLayout();
            // 
            // HeadLabel
            // 
            HeadLabel.AutoSize = true;
            HeadLabel.Font = new Font("Segoe UI Black", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HeadLabel.Location = new Point(83, 34);
            HeadLabel.Margin = new Padding(5, 0, 5, 0);
            HeadLabel.Name = "HeadLabel";
            HeadLabel.Size = new Size(990, 140);
            HeadLabel.TabIndex = 0;
            HeadLabel.Text = "Potman clone a light way to test a api\r\n\r\n";
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
            // UrlText
            // 
            UrlText.Location = new Point(211, 120);
            UrlText.Name = "UrlText";
            UrlText.Size = new Size(879, 50);
            UrlText.TabIndex = 8;
            // 
            // MethodNav
            // 
            MethodNav.DropDownStyle = ComboBoxStyle.DropDownList;
            MethodNav.FormattingEnabled = true;
            MethodNav.Items.AddRange(new object[] { "GET", "POST", "PUT", "PATCH", "DELETE" });
            MethodNav.Location = new Point(92, 117);
            MethodNav.Name = "MethodNav";
            MethodNav.Size = new Size(124, 53);
            MethodNav.TabIndex = 9;
            MethodNav.UseWaitCursor = true;
            MethodNav.SelectedIndexChanged += MethodNav_SelectedIndexChanged;
            // 
            // CallData
            // 
            CallData.Controls.Add(tabBody);
            CallData.Controls.Add(tabResults);
            CallData.Location = new Point(67, 218);
            CallData.Name = "CallData";
            CallData.SelectedIndex = 0;
            CallData.Size = new Size(875, 605);
            CallData.TabIndex = 10;
            // 
            // tabBody
            // 
            tabBody.Controls.Add(BodyText);
            tabBody.Location = new Point(4, 54);
            tabBody.Name = "tabBody";
            tabBody.Padding = new Padding(3);
            tabBody.Size = new Size(867, 547);
            tabBody.TabIndex = 0;
            tabBody.Text = "Body";
            tabBody.UseVisualStyleBackColor = true;
            // 
            // BodyText
            // 
            BodyText.Dock = DockStyle.Fill;
            BodyText.Location = new Point(3, 3);
            BodyText.Margin = new Padding(5);
            BodyText.Multiline = true;
            BodyText.Name = "BodyText";
            BodyText.ScrollBars = ScrollBars.Both;
            BodyText.Size = new Size(861, 541);
            BodyText.TabIndex = 4;
            // 
            // tabResults
            // 
            tabResults.Controls.Add(ResultsText);
            tabResults.Location = new Point(4, 34);
            tabResults.Name = "tabResults";
            tabResults.Padding = new Padding(3);
            tabResults.Size = new Size(867, 567);
            tabResults.TabIndex = 1;
            tabResults.Text = "Results";
            tabResults.UseVisualStyleBackColor = true;
            // 
            // ResultsText
            // 
            ResultsText.Dock = DockStyle.Fill;
            ResultsText.Location = new Point(3, 3);
            ResultsText.Margin = new Padding(5);
            ResultsText.Multiline = true;
            ResultsText.Name = "ResultsText";
            ResultsText.ReadOnly = true;
            ResultsText.ScrollBars = ScrollBars.Both;
            ResultsText.Size = new Size(861, 561);
            ResultsText.TabIndex = 4;
            // 
            // DashBord
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1265, 928);
            Controls.Add(CallData);
            Controls.Add(MethodNav);
            Controls.Add(UrlText);
            Controls.Add(CallLabel);
            Controls.Add(statusStrip1);
            Controls.Add(CallApi);
            Controls.Add(HeadLabel);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "DashBord";
            Text = "PostMan by avrum indig";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            CallData.ResumeLayout(false);
            tabBody.ResumeLayout(false);
            tabBody.PerformLayout();
            tabResults.ResumeLayout(false);
            tabResults.PerformLayout();
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
        private TextBox UrlText;
        private ComboBox MethodNav;
        private TabControl CallData
            ;
        private TabPage tabBody
   ;
        private TabPage tabResults;
        private TextBox BodyText;
    }
}
