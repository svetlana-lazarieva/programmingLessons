using System;
using System.Windows.Forms;

namespace Task_4
{
    public partial class Form1 : Form
    {       
        Timer timer = new Timer();
        int timerCounter = 0;
        

        public Form1()
        {
            InitializeComponent();
            timer.Interval = 1000;            
            textBoxTimer.Text = "00:00:00";
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer.Tick -= timer_Tick;
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = new DateTime();
            dateTime = DateTime.Parse("00:00:00");
            textBoxTimer.Text = dateTime.AddSeconds(++timerCounter).ToString("HH:mm:ss");     
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxTimer.Text = "00:00:00";
            timerCounter = 0;
            timer.Stop();
            timer.Tick -= timer_Tick;
            timer.Dispose();
            timer = new Timer();
            timer.Interval = 1000;
        }
    }
}
