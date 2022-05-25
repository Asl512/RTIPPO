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
    public partial class Form4 : Form
    {
        //public string name;
        //public string gender;
        //public string location;
        //public string date;
        //public string category;

        public Form4(string name, string gender, string location, string date, string category)
        {
            InitializeComponent();
            //this.name = name;
            //this.gender = gender;
            //this.location = location;
            //this.date = date;
            //this.category = category;
            nameText.Text = name;
            genderText.Text = gender;
            locationText.Text = location;
            dateText.Text = date;
            categoryText.Text = category;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BulletinBoard formBB = new BulletinBoard();
            formBB.Show();
            this.Close();
        }
    }
}
