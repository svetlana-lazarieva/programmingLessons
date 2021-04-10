using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace FinalProject
{
    public static class Extensions
    {
        #region Lable

        /// <summary>
        /// Устанавливает имя label по дате
        /// </summary>
        /// <param name="label">label</param>
        /// <param name="date">Дата</param>
        public static void SetText(this Label label, DateTime date)
        {
            label.Text = date.ToString("d");
        }

        /// <summary>
        /// Получить дату из текста label
        /// </summary>
        /// <param name="label">label</param>
        /// <returns>Дата</returns>
        public static DateTime GetDateByText(this Label label)
        {
            string text = label.Text;
            DateTime.TryParse(text, out DateTime date);

            return date;
        }

        /// <summary>
        /// Спрятать Lable следующего месяца
        /// </summary>
        /// <param name="richTextBox"></param>
        /// <param name="date"></param>
        public static void MakeInvisible(this Label label, DateTime date1, DateTime date2)
        {
            if (date1.Month != date2.Month)
            {
                label.Visible = false;
            }
            else
            {
                label.Visible = true;
            }

        }

        #endregion Lable

        #region RichTextBox

        /// <summary>
        /// richTextBox видимый если видимый сооьветствующий Label
        /// </summary>
        /// <param name="richTextBox"></param>
        /// <param name="label"></param>
        public static void MakeUnvisible(this RichTextBox richTextBox, Label label)
        {
            if (label.Visible == false)
            {
                richTextBox.Visible = false;
            }
            else if (label.Visible == true)
            {
                richTextBox.Visible = true;
            }

        }

        /// <summary>
        /// Устанавливает цвет фона richTextBox по дате
        /// </summary>
        /// <param name="richTextBox">richTextBox</param>
        /// <param name="date">Дата</param>
        public static void SetBackColor(this RichTextBox richTextBox, DateTime date)
        {
            Day day = new Day();
            bool weekend = day.Weekand(date);
            bool lastDay = day.LestDay(date);
            if (lastDay == true)
            {
                richTextBox.BackColor = System.Drawing.Color.LightGray;
                richTextBox.ReadOnly = true;
            }
            else if (weekend == true && lastDay == false)
            {
                richTextBox.BackColor = System.Drawing.Color.LightPink;
                richTextBox.ReadOnly = false;
            }
            else
            {
                richTextBox.BackColor = System.Drawing.Color.White;
                richTextBox.ReadOnly = false;
            }
        }

        #endregion RichTextBox
    }
}
