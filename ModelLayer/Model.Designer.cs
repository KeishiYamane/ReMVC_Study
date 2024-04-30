namespace ReMVC_Study
{
    partial class Model
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
            ColorPanel = new Panel();
            SuspendLayout();
            // 
            // StartListenerBtn
            // 
            StartListenerBtn.Location = new Point(12, 12);
            StartListenerBtn.Name = "StartListenerBtn";
            StartListenerBtn.Size = new Size(100, 47);
            StartListenerBtn.TabIndex = 0;
            StartListenerBtn.Text = "サーバー起動";
            StartListenerBtn.UseVisualStyleBackColor = true;
            // 
            // LogTxtBox
            // 
            LogTxtBox.Location = new Point(12, 65);
            LogTxtBox.Multiline = true;
            LogTxtBox.Name = "LogTxtBox";
            LogTxtBox.Size = new Size(374, 323);
            LogTxtBox.TabIndex = 1;
            // 
            // ColorPanel
            // 
            ColorPanel.BackColor = Color.Black;
            ColorPanel.Location = new Point(258, 12);
            ColorPanel.Name = "ColorPanel";
            ColorPanel.Size = new Size(128, 47);
            ColorPanel.TabIndex = 2;
            // 
            // Model
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 417);
            Controls.Add(ColorPanel);
            Controls.Add(LogTxtBox);
            Controls.Add(StartListenerBtn);
            Name = "Model";
            Text = "モデル";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartListenerBtn;
        private TextBox LogTxtBox;
        private Panel ColorPanel;
    }
}
