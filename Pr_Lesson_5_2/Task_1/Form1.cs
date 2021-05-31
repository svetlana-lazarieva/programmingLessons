using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyDatabaseEntities dbContext = new MyDatabaseEntities();
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("first_name", "First Name");
            dataGridView1.Columns.Add("last_name", "Second Name");

            foreach (var item in dbContext.Table)
            {
                int rowId = dataGridView1.Rows.Add();
                DataGridViewRow row = dataGridView1.Rows[rowId];
                row.Cells["Id"].Value = item.Id;
                row.Cells["first_name"].Value = item.first_name;
                row.Cells["last_name"].Value = item.last_name;

            }
        }
    }
}
