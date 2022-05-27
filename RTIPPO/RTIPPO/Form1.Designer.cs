
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.dateBeafor = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.buttonLayut = new System.Windows.Forms.ToolStripMenuItem();
            this.myRecords = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridMissing = new System.Windows.Forms.DataGridView();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateSortButton = new System.Windows.Forms.Button();
            this.nameSortButton = new System.Windows.Forms.Button();
            this.categorySortButton = new System.Windows.Forms.Button();
            this.genderSortButton = new System.Windows.Forms.Button();
            this.userSortButton = new System.Windows.Forms.Button();
            this.locationSortButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMissing)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonPlace
            // 
            this.ButtonPlace.BackColor = System.Drawing.Color.Red;
            this.ButtonPlace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonPlace.ForeColor = System.Drawing.Color.Snow;
            this.ButtonPlace.Location = new System.Drawing.Point(674, 48);
            this.ButtonPlace.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonPlace.Name = "ButtonPlace";
            this.ButtonPlace.Size = new System.Drawing.Size(232, 41);
            this.ButtonPlace.TabIndex = 0;
            this.ButtonPlace.Text = "Подать объявления";
            this.ButtonPlace.UseVisualStyleBackColor = false;
            this.ButtonPlace.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F);
            this.label1.Location = new System.Drawing.Point(29, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(656, 53);
            this.label1.TabIndex = 2;
            this.label1.Text = "Доска объявлений о находке";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(623, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Город:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(623, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Категория:";
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Все"});
            this.comboBox1.Location = new System.Drawing.Point(726, 231);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 28);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dateFrom
            // 
            this.dateFrom.Location = new System.Drawing.Point(693, 388);
            this.dateFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(160, 26);
            this.dateFrom.TabIndex = 12;
            this.dateFrom.ValueChanged += new System.EventHandler(this.dateFrom_ValueChanged);
            // 
            // dateBeafor
            // 
            this.dateBeafor.Location = new System.Drawing.Point(693, 440);
            this.dateBeafor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateBeafor.Name = "dateBeafor";
            this.dateBeafor.Size = new System.Drawing.Size(160, 26);
            this.dateBeafor.TabIndex = 13;
            this.dateBeafor.ValueChanged += new System.EventHandler(this.dateBeafor_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(626, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 22);
            this.label6.TabIndex = 14;
            this.label6.Text = "От";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(626, 440);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 22);
            this.label7.TabIndex = 15;
            this.label7.Text = "До";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSubmit.Location = new System.Drawing.Point(627, 504);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(268, 39);
            this.buttonSubmit.TabIndex = 16;
            this.buttonSubmit.Text = "Применить";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonLayut,
            this.myRecords});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(938, 36);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // buttonLayut
            // 
            this.buttonLayut.Name = "buttonLayut";
            this.buttonLayut.Size = new System.Drawing.Size(80, 29);
            this.buttonLayut.Text = "Выход";
            this.buttonLayut.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // myRecords
            // 
            this.myRecords.Name = "myRecords";
            this.myRecords.Size = new System.Drawing.Size(168, 29);
            this.myRecords.Text = "Мои объявления";
            // 
            // dataGridMissing
            // 
            this.dataGridMissing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMissing.Location = new System.Drawing.Point(14, 178);
            this.dataGridMissing.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridMissing.Name = "dataGridMissing";
            this.dataGridMissing.RowHeadersWidth = 51;
            this.dataGridMissing.RowTemplate.Height = 24;
            this.dataGridMissing.Size = new System.Drawing.Size(603, 365);
            this.dataGridMissing.TabIndex = 2;
            this.dataGridMissing.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMissing_CellContentClick);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Все"});
            this.comboBox2.Location = new System.Drawing.Point(726, 178);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(168, 28);
            this.comboBox2.TabIndex = 18;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(626, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 22);
            this.label8.TabIndex = 10;
            this.label8.Text = "Дата:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Все"});
            this.comboBox3.Location = new System.Drawing.Point(726, 276);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(168, 28);
            this.comboBox3.TabIndex = 19;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(623, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "Пол:";
            // 
            // dateSortButton
            // 
            this.dateSortButton.Location = new System.Drawing.Point(12, 129);
            this.dateSortButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateSortButton.Name = "dateSortButton";
            this.dateSortButton.Size = new System.Drawing.Size(83, 41);
            this.dateSortButton.TabIndex = 21;
            this.dateSortButton.Text = "Дата ↓";
            this.dateSortButton.UseVisualStyleBackColor = true;
            this.dateSortButton.Click += new System.EventHandler(this.dateSortButton_Click);
            // 
            // nameSortButton
            // 
            this.nameSortButton.Location = new System.Drawing.Point(102, 129);
            this.nameSortButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameSortButton.Name = "nameSortButton";
            this.nameSortButton.Size = new System.Drawing.Size(96, 41);
            this.nameSortButton.TabIndex = 22;
            this.nameSortButton.Text = "Кличка ↓";
            this.nameSortButton.UseVisualStyleBackColor = true;
            this.nameSortButton.Click += new System.EventHandler(this.nameSortButton_Click);
            // 
            // categorySortButton
            // 
            this.categorySortButton.Location = new System.Drawing.Point(205, 129);
            this.categorySortButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.categorySortButton.Name = "categorySortButton";
            this.categorySortButton.Size = new System.Drawing.Size(112, 41);
            this.categorySortButton.TabIndex = 23;
            this.categorySortButton.Text = "Категория ↓";
            this.categorySortButton.UseVisualStyleBackColor = true;
            this.categorySortButton.Click += new System.EventHandler(this.categorySortButton_Click);
            // 
            // genderSortButton
            // 
            this.genderSortButton.Location = new System.Drawing.Point(324, 129);
            this.genderSortButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.genderSortButton.Name = "genderSortButton";
            this.genderSortButton.Size = new System.Drawing.Size(62, 41);
            this.genderSortButton.TabIndex = 24;
            this.genderSortButton.Text = "Пол ↓";
            this.genderSortButton.UseVisualStyleBackColor = true;
            this.genderSortButton.Click += new System.EventHandler(this.genderSortButton_Click);
            // 
            // userSortButton
            // 
            this.userSortButton.Location = new System.Drawing.Point(393, 129);
            this.userSortButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userSortButton.Name = "userSortButton";
            this.userSortButton.Size = new System.Drawing.Size(141, 41);
            this.userSortButton.TabIndex = 25;
            this.userSortButton.Text = "Пользователь ↓";
            this.userSortButton.UseVisualStyleBackColor = true;
            this.userSortButton.Click += new System.EventHandler(this.userSortButton_Click);
            // 
            // locationSortButton
            // 
            this.locationSortButton.Location = new System.Drawing.Point(540, 129);
            this.locationSortButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.locationSortButton.Name = "locationSortButton";
            this.locationSortButton.Size = new System.Drawing.Size(76, 41);
            this.locationSortButton.TabIndex = 26;
            this.locationSortButton.Text = "Город ↓";
            this.locationSortButton.UseVisualStyleBackColor = true;
            this.locationSortButton.Click += new System.EventHandler(this.locationSortButton_Click);
            // 
            // BulletinBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 588);
            this.Controls.Add(this.locationSortButton);
            this.Controls.Add(this.userSortButton);
            this.Controls.Add(this.genderSortButton);
            this.Controls.Add(this.categorySortButton);
            this.Controls.Add(this.nameSortButton);
            this.Controls.Add(this.dateSortButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.dataGridMissing);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateBeafor);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonPlace);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BulletinBoard";
            this.Text = "BulletinBoard";
            this.Load += new System.EventHandler(this.BulletinBoard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMissing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonPlace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.DateTimePicker dateBeafor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem buttonLayut;
        private System.Windows.Forms.ToolStripMenuItem myRecords;
        private System.Windows.Forms.DataGridView dataGridMissing;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button dateSortButton;
        private System.Windows.Forms.Button nameSortButton;
        private System.Windows.Forms.Button categorySortButton;
        private System.Windows.Forms.Button genderSortButton;
        private System.Windows.Forms.Button userSortButton;
        private System.Windows.Forms.Button locationSortButton;
    }
}

