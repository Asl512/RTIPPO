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
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registration formRegistration = new Registration();
            formRegistration.Show();
            this.Hide();
        }

        private void доскаОбъявленийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BulletinBoard formBB = new BulletinBoard(false);
            formBB.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BulletinBoard board = new BulletinBoard(true);
            UserRepository userRepository = new UserRepository();

            string status = userRepository.enter(textLogin.Text, textPassword.Text);
            if (status == "")
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
    }
}
