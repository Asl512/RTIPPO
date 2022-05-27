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
            LocationRepository locationRepository = new LocationRepository();
            DataTable location = locationRepository.getAll();
            foreach (DataRow row in location.Rows)
            {
                var cells = row.ItemArray;
                comboBox1.Items.Add(cells[1]);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Authorization formAuthorization = new Authorization();
            formAuthorization.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Authorization formAuthorization = new Authorization();
            formAuthorization.Show();
            UserRepository userRepository = new UserRepository();
            DataBase db = new DataBase("select id, name from location");
            int location = 1;
            foreach (DataRow row in db.data.Rows)
            {
                var cells = row.ItemArray;
                if (cells[1].ToString().Trim() == comboBox1.SelectedItem.ToString())
                {
                    location = Int32.Parse(cells[0].ToString());
                }
                /*else 
                {
                    location++;
                }*/
            } 
            string status = userRepository.registration(loginBoxR.Text, passwordBoxR.Text, location);
            if (status =="") 
            {
                formAuthorization.Show(); 
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

        private void Registration_Load(object sender, EventArgs e)
        {

        }
    }
}
