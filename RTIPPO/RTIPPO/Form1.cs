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

        }
    }
}
