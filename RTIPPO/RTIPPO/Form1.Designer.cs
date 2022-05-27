
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
            this.nextPageButton = new System.Windows.Forms.Button();
            this.backPageButton = new System.Windows.Forms.Button();
            this.labelPage = new System.Windows.Forms.Label();
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
            this.ButtonPlace.Location = new System.Drawing.Point(599, 49);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(112, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Доска объявлений о находке";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(554, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Город:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(554, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Категори:";
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Все"});
            this.comboBox1.Location = new System.Drawing.Point(645, 185);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 24);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            this.dateBeafor.ValueChanged += new System.EventHandler(this.dateBeafor_ValueChanged);
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
            this.buttonSubmit.Location = new System.Drawing.Point(559, 403);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(238, 31);
            this.buttonSubmit.TabIndex = 16;
            this.buttonSubmit.Text = "Применить";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonLayut,
            this.myRecords});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(817, 28);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // buttonLayut
            // 
            this.buttonLayut.Name = "buttonLayut";
            this.buttonLayut.Size = new System.Drawing.Size(67, 24);
            this.buttonLayut.Text = "Выход";
            this.buttonLayut.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // myRecords
            // 
            this.myRecords.Name = "myRecords";
            this.myRecords.Size = new System.Drawing.Size(143, 24);
            this.myRecords.Text = "Мои объявления";
            // 
            // dataGridMissing
            // 
            this.dataGridMissing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMissing.Location = new System.Drawing.Point(12, 142);
            this.dataGridMissing.Name = "dataGridMissing";
            this.dataGridMissing.RowHeadersWidth = 51;
            this.dataGridMissing.RowTemplate.Height = 24;
            this.dataGridMissing.Size = new System.Drawing.Size(536, 292);
            this.dataGridMissing.TabIndex = 2;
            this.dataGridMissing.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMissing_CellContentClick);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Все"});
            this.comboBox2.Location = new System.Drawing.Point(645, 142);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(150, 24);
            this.comboBox2.TabIndex = 18;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
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
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Все"});
            this.comboBox3.Location = new System.Drawing.Point(645, 221);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(150, 24);
            this.comboBox3.TabIndex = 19;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(554, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Пол:";
            // 
            // dateSortButton
            // 
            this.dateSortButton.Location = new System.Drawing.Point(11, 103);
            this.dateSortButton.Name = "dateSortButton";
            this.dateSortButton.Size = new System.Drawing.Size(74, 33);
            this.dateSortButton.TabIndex = 21;
            this.dateSortButton.Text = "Дата ↓";
            this.dateSortButton.UseVisualStyleBackColor = true;
            this.dateSortButton.Click += new System.EventHandler(this.dateSortButton_Click);
            // 
            // nameSortButton
            // 
            this.nameSortButton.Location = new System.Drawing.Point(91, 103);
            this.nameSortButton.Name = "nameSortButton";
            this.nameSortButton.Size = new System.Drawing.Size(85, 33);
            this.nameSortButton.TabIndex = 22;
            this.nameSortButton.Text = "Кличка ↓";
            this.nameSortButton.UseVisualStyleBackColor = true;
            this.nameSortButton.Click += new System.EventHandler(this.nameSortButton_Click);
            // 
            // categorySortButton
            // 
            this.categorySortButton.Location = new System.Drawing.Point(182, 103);
            this.categorySortButton.Name = "categorySortButton";
            this.categorySortButton.Size = new System.Drawing.Size(100, 33);
            this.categorySortButton.TabIndex = 23;
            this.categorySortButton.Text = "Категория ↓";
            this.categorySortButton.UseVisualStyleBackColor = true;
            this.categorySortButton.Click += new System.EventHandler(this.categorySortButton_Click);
            // 
            // genderSortButton
            // 
            this.genderSortButton.Location = new System.Drawing.Point(288, 103);
            this.genderSortButton.Name = "genderSortButton";
            this.genderSortButton.Size = new System.Drawing.Size(55, 33);
            this.genderSortButton.TabIndex = 24;
            this.genderSortButton.Text = "Пол ↓";
            this.genderSortButton.UseVisualStyleBackColor = true;
            this.genderSortButton.Click += new System.EventHandler(this.genderSortButton_Click);
            // 
            // userSortButton
            // 
            this.userSortButton.Location = new System.Drawing.Point(349, 103);
            this.userSortButton.Name = "userSortButton";
            this.userSortButton.Size = new System.Drawing.Size(125, 33);
            this.userSortButton.TabIndex = 25;
            this.userSortButton.Text = "Пользователь ↓";
            this.userSortButton.UseVisualStyleBackColor = true;
            this.userSortButton.Click += new System.EventHandler(this.userSortButton_Click);
            // 
            // locationSortButton
            // 
            this.locationSortButton.Location = new System.Drawing.Point(480, 103);
            this.locationSortButton.Name = "locationSortButton";
            this.locationSortButton.Size = new System.Drawing.Size(68, 33);
            this.locationSortButton.TabIndex = 26;
            this.locationSortButton.Text = "Город ↓";
            this.locationSortButton.UseVisualStyleBackColor = true;
            this.locationSortButton.Click += new System.EventHandler(this.locationSortButton_Click);
            // 
            // nextPageButton
            // 
            this.nextPageButton.Location = new System.Drawing.Point(69, 52);
            this.nextPageButton.Name = "nextPageButton";
            this.nextPageButton.Size = new System.Drawing.Size(30, 26);
            this.nextPageButton.TabIndex = 27;
            this.nextPageButton.Text = ">";
            this.nextPageButton.UseVisualStyleBackColor = true;
            this.nextPageButton.Click += new System.EventHandler(this.nextPageButton_Click);
            // 
            // backPageButton
            // 
            this.backPageButton.Location = new System.Drawing.Point(11, 52);
            this.backPageButton.Name = "backPageButton";
            this.backPageButton.Size = new System.Drawing.Size(30, 26);
            this.backPageButton.TabIndex = 28;
            this.backPageButton.Text = "<";
            this.backPageButton.UseVisualStyleBackColor = true;
            this.backPageButton.Click += new System.EventHandler(this.backPageButton_Click);
            // 
            // labelPage
            // 
            this.labelPage.AutoSize = true;
            this.labelPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelPage.Location = new System.Drawing.Point(45, 54);
            this.labelPage.Name = "labelPage";
            this.labelPage.Size = new System.Drawing.Size(18, 20);
            this.labelPage.TabIndex = 29;
            this.labelPage.Text = "0";
            this.labelPage.Click += new System.EventHandler(this.label3_Click);
            // 
            // BulletinBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 470);
            this.Controls.Add(this.labelPage);
            this.Controls.Add(this.backPageButton);
            this.Controls.Add(this.nextPageButton);
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
        private System.Windows.Forms.Button nextPageButton;
        private System.Windows.Forms.Button backPageButton;
        private System.Windows.Forms.Label labelPage;
    }
}

