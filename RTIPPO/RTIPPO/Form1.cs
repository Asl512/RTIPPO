using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTIPPO
{
    public partial class BulletinBoard : Form
    {
        public bool auth = false;
        public BulletinBoard(bool auth)
        {
            this.auth = auth;
            InitializeComponent();
            if(!auth)
            {
                ButtonPlace.Text = "Войти";
                menuStrip1.Visible = false;
            }
            else
            {
                ButtonPlace.Text = "Подать объявление";
                menuStrip1.Visible = true;
            }
            dataGridMissing.Rows.Add("Барсик", "Кошка", "М", "Тюмень", "12.02.2022");
            dataGridMissing.Rows.Add("Ласточка", "Собака", "Ж", "Тюмень", "22.02.2022");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!auth)
            {
                Authorization formAuthorization = new Authorization();
                formAuthorization.Show();
                this.Hide();
            }
        }

        private void BulletinBoard_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateFrom_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Authorization formAuthorization = new Authorization();
            formAuthorization.Show();
            this.Hide();
        }

        private void dataGridMissing_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            var name = (String)dataGridMissing[0, row].Value;
            var category = (String)dataGridMissing[1, row].Value;
            var gender = (String)dataGridMissing[2, row].Value;
            var location = (String)dataGridMissing[3,row].Value;
            var date = (String)dataGridMissing[4,row].Value;

            Form4 form4 = new Form4(name, gender, location, date, category);
            form4.Show();
            this.Hide();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
