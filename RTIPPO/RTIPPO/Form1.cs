using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RTIPPO.repositories;

namespace RTIPPO
{
    public partial class BulletinBoard : Form
    {
        public bool auth;
        UserRepository userRepository;
        public BulletinBoard(UserRepository userRepository)
        {
            InitializeComponent();
            RecordRepository recordsRepository = new RecordRepository();
            dataGridMissing.DataSource = recordsRepository.getRecords();

            this.userRepository = userRepository;
            auth = this.userRepository.checkIsLogginIn();
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
            userRepository.logout();
            this.Hide();
        }

        private void dataGridMissing_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*int row = e.RowIndex;
            var name = (String)dataGridMissing[0, row].Value;
            var category = (String)dataGridMissing[1, row].Value;
            var gender = (String)dataGridMissing[2, row].Value;
            var location = (String)dataGridMissing[3,row].Value;
            var date = (String)dataGridMissing[4,row].Value;

            Form4 form4 = new Form4(name, gender, location, date, category);
            form4.ShowDialog();*/
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
