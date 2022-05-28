
namespace RTIPPO
{
    partial class AuthForm
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
            this.labAuth = new System.Windows.Forms.Label();
            this.b = new System.ComponentModel.BackgroundWorker();
            this.buttonReg = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.textLogin = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.menuStripAuth = new System.Windows.Forms.MenuStrip();
            this.доскаОбъявленийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripAuth.SuspendLayout();
            this.SuspendLayout();
            // 
            // labAuth
            // 
            this.labAuth.AutoSize = true;
            this.labAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labAuth.ForeColor = System.Drawing.Color.Maroon;
            this.labAuth.Location = new System.Drawing.Point(269, 59);
            this.labAuth.Name = "labAuth";
            this.labAuth.Size = new System.Drawing.Size(261, 46);
            this.labAuth.TabIndex = 0;
            this.labAuth.Text = "Авторизация";
            // 
            // buttonReg
            // 
            this.buttonReg.BackColor = System.Drawing.Color.SeaShell;
            this.buttonReg.ForeColor = System.Drawing.Color.Maroon;
            this.buttonReg.Location = new System.Drawing.Point(141, 315);
            this.buttonReg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(194, 51);
            this.buttonReg.TabIndex = 1;
            this.buttonReg.Text = "Зарегистрироваться";
            this.buttonReg.UseVisualStyleBackColor = false;
            this.buttonReg.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.BackColor = System.Drawing.Color.SeaShell;
            this.buttonOpen.ForeColor = System.Drawing.Color.Maroon;
            this.buttonOpen.Location = new System.Drawing.Point(460, 315);
            this.buttonOpen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(155, 51);
            this.buttonOpen.TabIndex = 2;
            this.buttonOpen.Text = "Войти";
            this.buttonOpen.UseVisualStyleBackColor = false;
            this.buttonOpen.Click += new System.EventHandler(this.button2_Click);
            // 
            // textLogin
            // 
            this.textLogin.BackColor = System.Drawing.Color.SeaShell;
            this.textLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textLogin.Location = new System.Drawing.Point(295, 170);
            this.textLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(201, 30);
            this.textLogin.TabIndex = 3;

            // 
            // textPassword
            // 
            this.textPassword.BackColor = System.Drawing.Color.SeaShell;
            this.textPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textPassword.Location = new System.Drawing.Point(295, 240);
            this.textPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(201, 30);
            this.textPassword.TabIndex = 4;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.ForeColor = System.Drawing.Color.Maroon;
            this.labelLogin.Location = new System.Drawing.Point(322, 144);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(55, 20);
            this.labelLogin.TabIndex = 5;
            this.labelLogin.Text = "Логин";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.ForeColor = System.Drawing.Color.Maroon;
            this.labelPassword.Location = new System.Drawing.Point(322, 218);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(67, 20);
            this.labelPassword.TabIndex = 6;
            this.labelPassword.Text = "Пароль";
            // 
            // menuStripAuth
            // 
            this.menuStripAuth.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStripAuth.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripAuth.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.доскаОбъявленийToolStripMenuItem});
            this.menuStripAuth.Location = new System.Drawing.Point(0, 0);
            this.menuStripAuth.Name = "menuStripAuth";
            this.menuStripAuth.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStripAuth.Size = new System.Drawing.Size(800, 33);
            this.menuStripAuth.TabIndex = 7;
            this.menuStripAuth.Text = "menuStrip1";
            // 
            // доскаОбъявленийToolStripMenuItem
            // 
            this.доскаОбъявленийToolStripMenuItem.Name = "доскаОбъявленийToolStripMenuItem";
            this.доскаОбъявленийToolStripMenuItem.Size = new System.Drawing.Size(181, 29);
            this.доскаОбъявленийToolStripMenuItem.Text = "Доска объявлений";
            this.доскаОбъявленийToolStripMenuItem.Click += new System.EventHandler(this.доскаОбъявленийToolStripMenuItem_Click);
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textLogin);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.labAuth);
            this.Controls.Add(this.menuStripAuth);
            this.MainMenuStrip = this.menuStripAuth;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AuthForm";
            this.Text = "Авторизация";
            this.menuStripAuth.ResumeLayout(false);
            this.menuStripAuth.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labAuth;
        private System.ComponentModel.BackgroundWorker b;
        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.TextBox textLogin;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.MenuStrip menuStripAuth;
        private System.Windows.Forms.ToolStripMenuItem доскаОбъявленийToolStripMenuItem;
    }
}