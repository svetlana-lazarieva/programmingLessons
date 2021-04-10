using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        private const int HorizontalOffset = 153;
        private const int VerticalOffset = 128;
        private const int HorizontalKoeficient = 130;
        private const int VerticalKoeficient = 50;

        public Component[] Components { get; set; }
        CalelendarStorage storage = new CalelendarStorage();
        
        

        public Form1()
        {
            InitializeComponent();
            
        }

        private void panelContaner_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelOfCurrentMonth.Text = DateTime.Today.ToString("Y");
            CreationOfComponents();
            SetCustomization(labelOfCurrentMonth.Text);
            LoadStorage();
        }

        private void LoadStorage()
        {
            if (storage.Load())
            {
                LoadCurrentMonth();
            }
        }

        private void LoadCurrentMonth()
        {
            int month = DateTime.Parse(labelOfCurrentMonth.Text).Month;
            if (storage.Load())
            {
                var componentData = storage.CurrentYear.GetMonthData(month).ComponentData;

                if (componentData.Count > 0)
                {
                    for (int i = 0; i < Components.Length; i++)
                    {
                        Components[i].SetComponentData(componentData[i]);
                    }
                }
            }
        }

        private void CreationOfComponents()
        {
            Components = new Component[35];
            int j = 1, k = 1;
            for (int i = 0; i < Components.Length; i++)
            {
                if (i > 0 && i % 7 == 0)
                {
                    ++j;
                    k = 1;
                }
                Components[i] = new Component(this);
                // Подписка на событие, когда кликнули на компонент(Component)
                Components[i].ComponentClicked += OnComponentClicked;
                Components[i].Position = new Point(k * HorizontalOffset - HorizontalKoeficient,
                                                   j * VerticalOffset - VerticalKoeficient);               
                k++;
            }
            
        }

        private void OnComponentClicked(Component comp)
        {
            Schedule schedule = new Schedule();
           
            schedule.Component = comp;
            schedule.Show();
        }

        private void CustomizationOfComponents(DateTime date)
        {
            DateTime date1 = DateTime.Parse(labelOfCurrentMonth.Text);
            foreach (var item in Components)
            {
                item.Label.SetText(date);
                item.Label.MakeInvisible(date, date1);
                item.RichTextBox.SetBackColor(date);
                item.RichTextBox.MakeUnvisible(item.Label);
                item.RichTextBox.Text = "";
                date = date.AddDays(1);
            }

        }

        /// <summary>
        /// Получить дату для установки настроек
        /// </summary>
        /// <param name="lableText"></param>
        /// <returns></returns>
        private DateTime GetDateForCustomization(string lableText)
        {
            DateTime.TryParse(lableText, out DateTime date);
            DateTime.Parse($"01.{date.Month}.{date.Year}");
            return DateTime.Parse($"01.{date.Month}.{date.Year}");
        }

        /// <summary>
        /// Установить настройки по значению даты
        /// </summary>
        /// <param name="lableText">Значение даты</param>
        private void SetCustomization(string lableText)
        {
            DateTime date = GetDateForCustomization(lableText);
            CustomizationOfComponents(date);
           
        }

        /// <summary>
        /// Стрелка в право
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGigthe_Click(object sender, EventArgs e)
        {
            SaveToStorage();
            ChengeLableText(1);
            SetCustomization(labelOfCurrentMonth.Text);
            LoadCurrentMonth();
        }

        /// <summary>
        /// Стрелка влево
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLeft_Click(object sender, EventArgs e)
        {
            SaveToStorage();
            ChengeLableText(2);
            SetCustomization(labelOfCurrentMonth.Text);
            LoadCurrentMonth();
        }

        /// <summary>
        /// Изменить текущий месяц
        /// </summary>
        /// <param name="n">1- следующий, 2-предидущий</param>
        private void ChengeLableText(int n)
        {
            DateTime date = DateTime.Parse(labelOfCurrentMonth.Text);
            if (n == 1)
            {
                date = date.AddMonths(1);
            }
            else
            {
                date = date.AddMonths(-1);
            }
            labelOfCurrentMonth.Text = date.ToString("Y");
        }

        /// <summary>
        /// При изменении текущего месяца меняет настройки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelOfCurrentMonth_TextChanged(object sender, EventArgs e)
        {
            //string str = labelOfCurrentMonth.Text;
            //SetCustomization(str);
        }

        /// <summary>
        /// Определить колличество занятых дней в месяце
        /// </summary>
        /// <returns>Колличество занятых днец в месяце</returns>
        private int CountWorkloadedDays()
        {
            int workloadedDays = 0;
            foreach (var item in Components)
            {
                if (item.RichTextBox.Visible == true &&
                    item.RichTextBox.Text != "")
                {
                    workloadedDays++;
                }
            }

            return workloadedDays;
        }

        /// <summary>
        /// Определить колличество занятых дней в месяце
        /// </summary>
        /// <returns>Колличество занятых днец в месяце</returns>
        private int CountWorkloadedDays(out int workloadedHourse)
        {
            int workloadedDays = 0;
            workloadedHourse = 0;

            foreach (var item in Components)
            {
                if (item.RichTextBox.Visible == true &&
                    item.RichTextBox.Text != "")
                {
                    workloadedHourse += RowsInRichTextBox(item.RichTextBox);
                    workloadedDays++;
                }
            }

            return workloadedDays;
        }

        /// <summary>
        /// Считает количество строк в RichTextBox 
        /// </summary>
        /// <param name="richTextBox"></param>
        /// <returns>Количество строк в RichTextBox </returns>
        private int RowsInRichTextBox(RichTextBox richTextBox)
        {
            int countRows = 0;
            if (!string.IsNullOrEmpty(richTextBox.Text))
            {
                countRows = richTextBox.Lines.Length;
            }

            return countRows;
        }

        /// <summary>
        /// Отчет о загруженности
        /// </summary>
        private void GetInfo()
        {
            int workloadedHourse, freeDays, freeHourse;
            //int workloadedDays = CountWorkloadedDays();
            int workloadedDays = CountWorkloadedDays(out workloadedHourse);
            DateTime date = DateTime.Parse(labelOfCurrentMonth.Text);
            Day day = new Day();
            //day.CalculateWorkload(date, workloadedDays, out workloadedHourse, out freeDays, out freeHourse);
            day.CalculateWorkload(date, workloadedDays, workloadedHourse, out freeDays, out freeHourse);
            richTextBoxReport.Text = $" Звіт: \n Квлькість завантаженних днів: {workloadedDays}\n" +
                                     $" Квлькість завантаженних годин: {workloadedHourse}\n" +
                                     $" Квлькість вільних днів: {freeDays}\n" +
                                     $" Квлькість вільних годин: {freeHourse}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetInfo();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void buttonDateChange_Click(object sender, EventArgs e)
        {
            SaveToStorage();
            labelOfCurrentMonth.Text = StringToStringAsDate(textBoxDateChange.Text);
            SetCustomization(labelOfCurrentMonth.Text);
            LoadCurrentMonth();
        }

        /// <summary>
        /// Подготовить строку для установки текущего месяца
        /// </summary>
        /// <param name="text">Строка</param>
        /// <returns>Текущий месяц</returns>
        private string StringToStringAsDate(string text)
        {
            string cuurentDate = labelOfCurrentMonth.Text;
            try
            {
                cuurentDate = DateTime.Parse(text).ToString("Y");
            }
            catch (Exception)
            {                
                MessageBox.Show("Введене значення не коректне.");
            }
            return cuurentDate;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveToStorage();
        }

        private void SaveToStorage()
        {
            var data = Components.Select(item => item.DataPerDay).ToList();
            int month = DateTime.Parse(labelOfCurrentMonth.Text).Month;
            MonthData monthData = storage.CurrentYear.GetMonthData(month);
            monthData.ComponentData = data;

            storage.Save();
        }

        private void buttonGigthe_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void buttonLeft_MouseDown(object sender, MouseEventArgs e)
        {
            
        }
    }
}
