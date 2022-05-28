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
    public partial class AuthForm : Form
    {
        UserRepository userRepository;
        public AuthForm()
        {
            InitializeComponent();
            userRepository = new UserRepository();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registration formRegistration = new Registration();
            formRegistration.Show();
            this.Hide();
        }

        private void доскаОбъявленийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BulletinBoard formBB = new BulletinBoard(userRepository);
            formBB.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string status = userRepository.enter(textLogin.Text, textPassword.Text);
            if (status == "")
            {
                BulletinBoard formBB = new BulletinBoard(userRepository);
                formBB.Show();
                this.Hide();
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
