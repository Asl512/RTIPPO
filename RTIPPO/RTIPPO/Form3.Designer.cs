
namespace RTIPPO
{
    partial class Registration
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
            this.labelReg = new System.Windows.Forms.Label();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.labLog = new System.Windows.Forms.Label();
            this.labPas = new System.Windows.Forms.Label();
            this.saveReg = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labLocation = new System.Windows.Forms.Label();
            this.comboBoxLocation = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelReg
            // 
            this.labelReg.AutoSize = true;
            this.labelReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelReg.Location = new System.Drawing.Point(263, 28);
            this.labelReg.Name = "labelReg";
            this.labelReg.Size = new System.Drawing.Size(259, 46);
            this.labelReg.TabIndex = 0;
            this.labelReg.Text = "Регистрация";
            // 
            // loginBox
            // 
            this.loginBox.BackColor = System.Drawing.Color.SeaShell;
            this.loginBox.Location = new System.Drawing.Point(284, 211);
            this.loginBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(216, 26);
            this.loginBox.TabIndex = 1;
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.Color.SeaShell;
            this.passwordBox.Location = new System.Drawing.Point(284, 288);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(216, 26);
            this.passwordBox.TabIndex = 2;
            // 
            // labLog
            // 
            this.labLog.AutoSize = true;
            this.labLog.Location = new System.Drawing.Point(294, 185);
            this.labLog.Name = "labLog";
            this.labLog.Size = new System.Drawing.Size(55, 20);
            this.labLog.TabIndex = 3;
            this.labLog.Text = "Логин";
            // 
            // labPas
            // 
            this.labPas.AutoSize = true;
            this.labPas.Location = new System.Drawing.Point(294, 265);
            this.labPas.Name = "labPas";
            this.labPas.Size = new System.Drawing.Size(67, 20);
            this.labPas.TabIndex = 4;
            this.labPas.Text = "Пароль";
            // 
            // saveReg
            // 
            this.saveReg.Location = new System.Drawing.Point(395, 349);
            this.saveReg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveReg.Name = "saveReg";
            this.saveReg.Size = new System.Drawing.Size(104, 32);
            this.saveReg.TabIndex = 5;
            this.saveReg.Text = "Сохранить";
            this.saveReg.UseVisualStyleBackColor = true;
            this.saveReg.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(14, 15);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(84, 29);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "Назад";
            this.buttonBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labLocation
            // 
            this.labLocation.AutoSize = true;
            this.labLocation.Location = new System.Drawing.Point(294, 102);
            this.labLocation.Name = "labLocation";
            this.labLocation.Size = new System.Drawing.Size(56, 20);
            this.labLocation.TabIndex = 8;
            this.labLocation.Text = "Город";
            // 
            // comboBoxLocation
            // 
            this.comboBoxLocation.FormattingEnabled = true;
            this.comboBoxLocation.Location = new System.Drawing.Point(284, 136);
            this.comboBoxLocation.Name = "comboBoxLocation";
            this.comboBoxLocation.Size = new System.Drawing.Size(215, 28);
            this.comboBoxLocation.TabIndex = 9;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxLocation);
            this.Controls.Add(this.labLocation);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.saveReg);
            this.Controls.Add(this.labPas);
            this.Controls.Add(this.labLog);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.labelReg);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Registration";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelReg;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label labLog;
        private System.Windows.Forms.Label labPas;
        private System.Windows.Forms.Button saveReg;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labLocation;
        private System.Windows.Forms.ComboBox comboBoxLocation;
    }
}