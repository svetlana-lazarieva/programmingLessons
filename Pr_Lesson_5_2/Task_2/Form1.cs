using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2
{
    public partial class Form1 : Form
    {
        MyDatabaseEntities dbContext = new MyDatabaseEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("Name", "Имя");
            dataGridView1.Columns.Add("Second_name", "Фамилия");
            ShowData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Вывести данные из таблицы
        /// </summary>
        private void ShowData()
        {
            foreach (var item in dbContext.Table1)
            {
                int rowId = dataGridView1.Rows.Add();
                DataGridViewRow row = dataGridView1.Rows[rowId];
                row.Cells["Id"].Value = item.ID;
                row.Cells["Name"].Value = item.Name;
                row.Cells["Second_name"].Value = item.Second_name;

            }
        }
    }
}
