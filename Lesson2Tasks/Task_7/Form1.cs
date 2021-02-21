using System;
using System.Windows.Forms;

namespace Task_7
{
    //Используя Visual Studio, создайте проект по шаблону 
    //Windows Forms(.Net framework). Создайте программу для 
    //расчета возраста пользователя, по введенному им году 
    //рождения необходимо вывести его текущий возраст. 
    //(использовать DateTime).

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkBoxDate.Checked = true;
            checkBoxYear.Checked = false;
            dateTimePicker1.Enabled = true;
            textBoxYear.Enabled = false;
        }

        private void ButtonCount_Click(object sender, EventArgs e)
        {
            if (checkBoxYear.Checked == true)
            {
                GetAge();
            }
            else
            {
                GetCorrectAge();
            }
        }
        /// <summary>
        /// Определить возраст только по году
        /// </summary>
        private void GetAge()
        {
            Int32.TryParse(textBoxYear.Text, out int year);
            int thisYear = DateTime.Now.Year;
            try
            {
                int age = thisYear - year;
                textBoxAge.Text = age.ToString();
            }
            catch
            {
                MessageBox.Show("Ошибочка");
            }
        }

        /// <summary>
        /// Определить возраст по дате рождения
        /// </summary>
        private void GetCorrectAge()
        {
            DateTime thisYear = DateTime.Now.Date;
            DateTime year = dateTimePicker1.Value.ToLocalTime();
            try
            {
                TimeSpan age = thisYear - year;
                textBoxAge.Text = ((int)(age.TotalDays / 365)).ToString();
            }
            catch
            {
                MessageBox.Show("Ошибочка");
            }
        }

        private void checkBoxYear_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxYear.Checked == true)
            {
                checkBoxDate.Checked    = false;
                dateTimePicker1.Enabled = false;
                textBoxYear.Enabled     = true;
            }
            else
            {
                checkBoxDate.Checked    = true;
                dateTimePicker1.Enabled = true;
                textBoxYear.Enabled     = false;
                textBoxYear.Text = string.Empty;
            }
        }

        private void checkBoxDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDate.Checked == true)
            {
                checkBoxYear.Checked = false;
            }
            else
            {
                checkBoxYear.Checked = true;
            }
        }
    }
}
