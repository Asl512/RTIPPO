
namespace RTIPPO
{
    partial class BulletinBoard
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonPlace = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.AboutMissing = new System.Windows.Forms.TabPage();
            this.AboutFinding = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewFind = new System.Windows.Forms.DataGridView();
            this.dataGridMissing = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.dateBeafor = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.AboutMissing.SuspendLayout();
            this.AboutFinding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMissing)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonPlace
            // 
            this.ButtonPlace.BackColor = System.Drawing.Color.Red;
            this.ButtonPlace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonPlace.ForeColor = System.Drawing.Color.Snow;
            this.ButtonPlace.Location = new System.Drawing.Point(599, 12);
            this.ButtonPlace.Name = "ButtonPlace";
            this.ButtonPlace.Size = new System.Drawing.Size(206, 33);
            this.ButtonPlace.TabIndex = 0;
            this.ButtonPlace.Text = "Подать объявления";
            this.ButtonPlace.UseVisualStyleBackColor = false;
            this.ButtonPlace.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "Доска объявлений";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.AboutMissing);
            this.tabControl.Controls.Add(this.AboutFinding);
            this.tabControl.Location = new System.Drawing.Point(12, 89);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(529, 369);
            this.tabControl.TabIndex = 3;
            // 
            // AboutMissing
            // 
            this.AboutMissing.Controls.Add(this.dataGridMissing);
            this.AboutMissing.Controls.Add(this.label3);
            this.AboutMissing.Location = new System.Drawing.Point(4, 25);
            this.AboutMissing.Name = "AboutMissing";
            this.AboutMissing.Padding = new System.Windows.Forms.Padding(3);
            this.AboutMissing.Size = new System.Drawing.Size(521, 340);
            this.AboutMissing.TabIndex = 0;
            this.AboutMissing.Text = "О пропаже";
            this.AboutMissing.UseVisualStyleBackColor = true;
            // 
            // AboutFinding
            // 
            this.AboutFinding.Controls.Add(this.dataGridViewFind);
            this.AboutFinding.Controls.Add(this.label2);
            this.AboutFinding.Location = new System.Drawing.Point(4, 25);
            this.AboutFinding.Name = "AboutFinding";
            this.AboutFinding.Padding = new System.Windows.Forms.Padding(3);
            this.AboutFinding.Size = new System.Drawing.Size(521, 340);
            this.AboutFinding.TabIndex = 1;
            this.AboutFinding.Text = "О нахождении";
            this.AboutFinding.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "1";
            // 
            // dataGridViewFind
            // 
            this.dataGridViewFind.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFind.Location = new System.Drawing.Point(6, 26);
            this.dataGridViewFind.Name = "dataGridViewFind";
            this.dataGridViewFind.RowHeadersWidth = 51;
            this.dataGridViewFind.RowTemplate.Height = 24;
            this.dataGridViewFind.Size = new System.Drawing.Size(509, 308);
            this.dataGridViewFind.TabIndex = 1;
            // 
            // dataGridMissing
            // 
            this.dataGridMissing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMissing.Location = new System.Drawing.Point(6, 23);
            this.dataGridMissing.Name = "dataGridMissing";
            this.dataGridMissing.RowHeadersWidth = 51;
            this.dataGridMissing.RowTemplate.Height = 24;
            this.dataGridMissing.Size = new System.Drawing.Size(509, 311);
            this.dataGridMissing.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(557, 140);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 22);
            this.textBox1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(554, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Населенный пункт:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(554, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Категори:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(556, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 18);
            this.label8.TabIndex = 10;
            this.label8.Text = "Дата:";
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Кошка ",
            "Собака"});
            this.comboBox1.Location = new System.Drawing.Point(557, 225);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(238, 24);
            this.comboBox1.TabIndex = 11;
            // 
            // dateFrom
            // 
            this.dateFrom.Location = new System.Drawing.Point(616, 310);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(143, 22);
            this.dateFrom.TabIndex = 12;
            this.dateFrom.ValueChanged += new System.EventHandler(this.dateFrom_ValueChanged);
            // 
            // dateBeafor
            // 
            this.dateBeafor.Location = new System.Drawing.Point(616, 352);
            this.dateBeafor.Name = "dateBeafor";
            this.dateBeafor.Size = new System.Drawing.Size(143, 22);
            this.dateBeafor.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(556, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "От";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(556, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "До";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSubmit.Location = new System.Drawing.Point(557, 403);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(238, 31);
            this.buttonSubmit.TabIndex = 16;
            this.buttonSubmit.Text = "Применить";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // BulletinBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 470);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateBeafor);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonPlace);
            this.Name = "BulletinBoard";
            this.Text = "BulletinBoard";
            this.Load += new System.EventHandler(this.BulletinBoard_Load);
            this.tabControl.ResumeLayout(false);
            this.AboutMissing.ResumeLayout(false);
            this.AboutMissing.PerformLayout();
            this.AboutFinding.ResumeLayout(false);
            this.AboutFinding.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMissing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonPlace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage AboutMissing;
        private System.Windows.Forms.TabPage AboutFinding;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridMissing;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewFind;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.DateTimePicker dateBeafor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonSubmit;
    }
}

