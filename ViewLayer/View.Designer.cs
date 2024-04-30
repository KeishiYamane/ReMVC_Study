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
            StartListenerBtn = new Button();
            LogTxtBox = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // StartListenerBtn
            // 
            StartListenerBtn.Location = new Point(12, 12);
            StartListenerBtn.Name = "StartListenerBtn";
            StartListenerBtn.Size = new Size(100, 47);
            StartListenerBtn.TabIndex = 1;
            StartListenerBtn.Text = "サーバー接続開始";
            StartListenerBtn.UseVisualStyleBackColor = true;
            // 
            // LogTxtBox
            // 
            LogTxtBox.Location = new Point(12, 65);
            LogTxtBox.Multiline = true;
            LogTxtBox.Name = "LogTxtBox";
            LogTxtBox.Size = new Size(374, 323);
            LogTxtBox.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(128, 12);
            button1.Name = "button1";
            button1.Size = new Size(100, 47);
            button1.TabIndex = 3;
            button1.Text = "送信";
            button1.UseVisualStyleBackColor = true;
            // 
            // View
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 417);
            Controls.Add(button1);
            Controls.Add(LogTxtBox);
            Controls.Add(StartListenerBtn);
            Name = "View";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartListenerBtn;
        private TextBox LogTxtBox;
        private Button button1;
    }
}
