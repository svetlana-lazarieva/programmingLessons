using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Schedule : Form
    {
        public Component Component { get; set; }
        public Schedule()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Schedule_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckTimeOfActivity();
        }

        /// <summary>
        /// Ввести данные в дневное расписание
        /// </summary>
        private void InputDataToPlanList(string timeOfActivity)
        {
            string planeText = $"{timeOfActivity}  {richTextBox1.Text}";
            if (!string.IsNullOrEmpty(Component.RichTextBox.Text))
            {
                Component.RichTextBox.Text = $"{Component.RichTextBox.Text}\n{planeText}";
            }
            else
            {
                Component.RichTextBox.Text = planeText;
            }
            Close();
        }

        private void CheckTimeOfActivity()
        {
            if (string.IsNullOrEmpty($"{listBox1.SelectedItem}"))
            {               
                MessageBox.Show("Оберіть час події.");
            }
            else
            {
                InputDataToPlanList(listBox1.SelectedItem.ToString());
            }

        }






    }
}
