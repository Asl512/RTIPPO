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
    public partial class CardForm : Form
    {
        private DataTable record;

        public CardForm(string index)
        {

            InitializeComponent();
            RecordRepository record = new RecordRepository();
            this.record = record.getOne(index);
            DataRow animal = this.record.Rows[0];
            categoryText.Text = animal.ItemArray[2].ToString();
            nameText.Text = animal.ItemArray[1].ToString();
            genderText.Text = animal.ItemArray[3].ToString();
            locationText.Text = animal.ItemArray[4].ToString();
            dateText.Text = animal.ItemArray[0].ToString().Substring(0, animal.ItemArray[0].ToString().Length - 8);
            animalPhoto.ImageLocation = animal.ItemArray[5].ToString();
        }
    }
}
