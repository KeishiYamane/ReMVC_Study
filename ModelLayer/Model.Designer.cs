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
            LogTxtBox_Model = new TextBox();
            ColorPanel_Model = new Panel();
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
            // LogTxtBox_Model
            // 
            LogTxtBox_Model.Location = new Point(12, 65);
            LogTxtBox_Model.Multiline = true;
            LogTxtBox_Model.Name = "LogTxtBox_Model";
            LogTxtBox_Model.Size = new Size(374, 323);
            LogTxtBox_Model.TabIndex = 1;
            // 
            // ColorPanel_Model
            // 
            ColorPanel_Model.BackColor = Color.Black;
            ColorPanel_Model.Location = new Point(258, 12);
            ColorPanel_Model.Name = "ColorPanel_Model";
            ColorPanel_Model.Size = new Size(128, 47);
            ColorPanel_Model.TabIndex = 2;
            // 
            // Model
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 417);
            Controls.Add(ColorPanel_Model);
            Controls.Add(LogTxtBox_Model);
            Controls.Add(StartListenerBtn);
            Name = "Model";
            Text = "モデル";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartListenerBtn;
        private TextBox LogTxtBox_Model;
        private Panel ColorPanel_Model;
    }
}
