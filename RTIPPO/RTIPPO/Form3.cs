using RTIPPO.repositories;
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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Authorization formAuthorization = new Authorization();
            formAuthorization.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BulletinBoard board = new BulletinBoard(true);
            UserRepository userRepository = new UserRepository();

            string status = userRepository.registration(loginBoxR.Text, passwordBoxR.Text, 0);
            if (status =="") 
            { 
                board.Show(); 
                Hide(); 
            }
            else 
            {
                string message = status;
                string caption = "Ошибка валидации";
                MessageBoxButtons buttons = MessageBoxButtons.OK;

                MessageBox.Show(message, caption, buttons);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
