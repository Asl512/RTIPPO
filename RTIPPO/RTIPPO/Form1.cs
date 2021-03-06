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

    enum Sorting
    {
        ascending,
        descending,
        not
    }

    enum ColumnSort
    {
        user,
        gender,
        location,
        date,
        category,
        name,
        not
    }

    public partial class BulletinBoard : Form
    {
        public bool auth;
        UserRepository userRepository;
        RecordRepository recordsRepository;
        private int page = 0;
        private int offset = 0;

        private string location;
        private string category;
        private string gender;
        private string dateFromValue;
        private string dateBeaforValue;

        private Sorting dateSort = Sorting.not;
        private Sorting nameSort = Sorting.not;
        private Sorting genderSort = Sorting.not;
        private Sorting locationSort = Sorting.not;
        private Sorting userSort = Sorting.not;
        private Sorting categorySort = Sorting.not;
        private ColumnSort lastColumnSort = ColumnSort.not;

        public BulletinBoard(UserRepository userRepository)
        {
            InitializeComponent();
            labelPage.Text = page.ToString();

            dateSortButton.Text = "Дата";
            nameSortButton.Text = "Кличка";
            genderSortButton.Text = "Пол";
            locationSortButton.Text = "Город";
            userSortButton.Text = "Пользователь";
            categorySortButton.Text = "Категория";

            recordsRepository = new RecordRepository();
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

            LocationRepository locationRepository = new LocationRepository();
            DataTable location = locationRepository.getAll();
            foreach (DataRow row in location.Rows)
            {
                var cells = row.ItemArray;
                comboBox2.Items.Add(cells[1]);
            }
            GenderAnimalRepository genderAnimalRepository = new GenderAnimalRepository();
            DataTable gender = genderAnimalRepository.getAll();
            foreach (DataRow row in gender.Rows)
            {
                var cells = row.ItemArray;
                comboBox3.Items.Add(cells[1]);
            }
            CategoryAnimalRepository categoryAnimalRepository = new CategoryAnimalRepository();
            DataTable category = categoryAnimalRepository.getAll();
            foreach (DataRow row in category.Rows)
            {
                var cells = row.ItemArray;
                comboBox1.Items.Add(cells[1]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!auth)
            {
                AuthForm formAuthorization = new AuthForm();
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
            dateFromValue = dateFrom.Value.ToString();
        }

        private void dateBeafor_ValueChanged(object sender, EventArgs e)
        {
            dateBeaforValue = dateBeafor.Value.ToString();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            submitRecord();
        }

        private void submitRecord()
        {
            dataGridMissing.DataSource = recordsRepository.getRecords(location: location, category: category, gender: gender,
                dateFrom: dateFromValue, dateBeafor:dateBeaforValue, dateSort: dateSort, nameSort: nameSort, genderSort: genderSort,
                locationSort: locationSort, userSort: userSort, categorySort: categorySort, lastColumnSort: lastColumnSort, offset: offset);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthForm formAuthorization = new AuthForm();
            formAuthorization.Show();
            userRepository.logout();
            this.Hide();
        }

        private void dataGridMissing_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string index = dataGridMissing.SelectedCells[0].Value.ToString();
            CardForm form4 = new CardForm(index);
            form4.ShowDialog();
        }
        
        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            location = comboBox2.SelectedItem.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            category = comboBox1.SelectedItem.ToString();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            gender = comboBox3.SelectedItem.ToString();
        }

        private void dateSortButton_Click(object sender, EventArgs e)
        {
            lastColumnSort = ColumnSort.date;
            if (dateSort == Sorting.descending || dateSort ==  Sorting.not)
            {
                dateSort = Sorting.ascending;
                dateSortButton.Text = "Дата↑";
            }
            else if(dateSort == Sorting.ascending)
            {
                dateSort = Sorting.descending;
                dateSortButton.Text = "Дата↓";
            }
            submitRecord();
        }

        private void nameSortButton_Click(object sender, EventArgs e)
        {
            lastColumnSort = ColumnSort.name;
            if (nameSort == Sorting.descending || nameSort == Sorting.not)
            {
                nameSort = Sorting.ascending;
                nameSortButton.Text = "Кличка↑";
            }
            else if (nameSort == Sorting.ascending)
            {
                nameSort = Sorting.descending;
                nameSortButton.Text = "Кличка↓";
            }
            submitRecord();
        }

        private void categorySortButton_Click(object sender, EventArgs e)
        {
            lastColumnSort = ColumnSort.category;
            if (categorySort == Sorting.descending || categorySort == Sorting.not)
            {
                categorySort = Sorting.ascending;
                categorySortButton.Text = "Категория↑";
            }
            else if (categorySort == Sorting.ascending)
            {
                categorySort = Sorting.descending;
                categorySortButton.Text = "Категория↓";
            }
            submitRecord();
        }

        private void genderSortButton_Click(object sender, EventArgs e)
        {
            lastColumnSort = ColumnSort.gender;
            if (genderSort == Sorting.descending || genderSort == Sorting.not)
            {
                genderSort = Sorting.ascending;
                genderSortButton.Text = "Пол↑";
            }
            else if (genderSort == Sorting.ascending)
            {
                genderSort = Sorting.descending;
                genderSortButton.Text = "Пол↓";
            }
            submitRecord();
        }

        private void userSortButton_Click(object sender, EventArgs e)
        {
            lastColumnSort = ColumnSort.user;
            if (userSort == Sorting.descending || userSort == Sorting.not)
            {
                userSort = Sorting.ascending;
                userSortButton.Text = "Пользователь↑";
            }
            else if (userSort == Sorting.ascending)
            {
                userSort = Sorting.descending;
                userSortButton.Text = "Пользователь↓";
            }
            submitRecord();
        }

        private void locationSortButton_Click(object sender, EventArgs e)
        {
            lastColumnSort = ColumnSort.location;
            if (locationSort == Sorting.descending || locationSort == Sorting.not)
            {
                locationSort = Sorting.ascending;
                locationSortButton.Text = "Город↑";
            }
            else if (locationSort == Sorting.ascending)
            {
                locationSort = Sorting.descending;
                locationSortButton.Text = "Город↓";
            }
            submitRecord();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void nextPageButton_Click(object sender, EventArgs e)
        {
            page++;
            labelPage.Text = page.ToString();
            offset += 2;
            submitRecord();
        }

        private void backPageButton_Click(object sender, EventArgs e)
        {
            if(page > 0)
            {
                page--;
                offset -= 2;
                labelPage.Text = page.ToString();
                submitRecord();
            }
        }
    }
}
