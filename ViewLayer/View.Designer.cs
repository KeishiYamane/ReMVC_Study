namespace View
{
    partial class View
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
            ConnectBtn = new Button();
            LogTxtBox_View = new TextBox();
            SendBtn = new Button();
            SuspendLayout();
            // 
            // ConnectBtn
            // 
            ConnectBtn.Location = new Point(12, 12);
            ConnectBtn.Name = "ConnectBtn";
            ConnectBtn.Size = new Size(100, 47);
            ConnectBtn.TabIndex = 1;
            ConnectBtn.Text = "サーバー接続開始";
            ConnectBtn.UseVisualStyleBackColor = true;
            // 
            // LogTxtBox_View
            // 
            LogTxtBox_View.Location = new Point(12, 65);
            LogTxtBox_View.Multiline = true;
            LogTxtBox_View.Name = "LogTxtBox_View";
            LogTxtBox_View.Size = new Size(374, 323);
            LogTxtBox_View.TabIndex = 2;
            // 
            // SendBtn
            // 
            SendBtn.Location = new Point(128, 12);
            SendBtn.Name = "SendBtn";
            SendBtn.Size = new Size(100, 47);
            SendBtn.TabIndex = 3;
            SendBtn.Text = "送信";
            SendBtn.UseVisualStyleBackColor = true;
            // 
            // View
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 417);
            Controls.Add(SendBtn);
            Controls.Add(LogTxtBox_View);
            Controls.Add(ConnectBtn);
            Name = "View";
            Text = "ビュー";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ConnectBtn;
        private TextBox LogTxtBox_View;
        private Button SendBtn;
    }
}
