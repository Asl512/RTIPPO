
namespace RTIPPO
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.categoryText = new System.Windows.Forms.Label();
            this.genderText = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.Label();
            this.locationText = new System.Windows.Forms.Label();
            this.dateText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(195, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Карточка животного";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(491, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пол:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(491, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Категория:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(491, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Населенный пункт:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(491, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Кличка:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(494, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "Дата размещения:";
            // 
            // categoryText
            // 
            this.categoryText.AutoSize = true;
            this.categoryText.ForeColor = System.Drawing.Color.Navy;
            this.categoryText.Location = new System.Drawing.Point(491, 97);
            this.categoryText.Name = "categoryText";
            this.categoryText.Size = new System.Drawing.Size(58, 20);
            this.categoryText.TabIndex = 11;
            this.categoryText.Text = "Кошка";
            // 
            // genderText
            // 
            this.genderText.AutoSize = true;
            this.genderText.ForeColor = System.Drawing.Color.Navy;
            this.genderText.Location = new System.Drawing.Point(491, 175);
            this.genderText.Name = "genderText";
            this.genderText.Size = new System.Drawing.Size(22, 20);
            this.genderText.TabIndex = 12;
            this.genderText.Text = "М";
            // 
            // nameText
            // 
            this.nameText.AutoSize = true;
            this.nameText.ForeColor = System.Drawing.Color.Navy;
            this.nameText.Location = new System.Drawing.Point(491, 251);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(45, 20);
            this.nameText.TabIndex = 13;
            this.nameText.Text = "Бакс";
            // 
            // locationText
            // 
            this.locationText.AutoSize = true;
            this.locationText.ForeColor = System.Drawing.Color.Navy;
            this.locationText.Location = new System.Drawing.Point(491, 334);
            this.locationText.Name = "locationText";
            this.locationText.Size = new System.Drawing.Size(68, 20);
            this.locationText.TabIndex = 14;
            this.locationText.Text = "Тюмень";
            // 
            // dateText
            // 
            this.dateText.AutoSize = true;
            this.dateText.ForeColor = System.Drawing.Color.Navy;
            this.dateText.Location = new System.Drawing.Point(494, 414);
            this.dateText.Name = "dateText";
            this.dateText.Size = new System.Drawing.Size(156, 20);
            this.dateText.TabIndex = 15;
            this.dateText.Text = "19 февраля 2022 г.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(55, 104);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 278);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateText);
            this.Controls.Add(this.locationText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.genderText);
            this.Controls.Add(this.categoryText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label categoryText;
        private System.Windows.Forms.Label genderText;
        private System.Windows.Forms.Label nameText;
        private System.Windows.Forms.Label locationText;
        private System.Windows.Forms.Label dateText;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}