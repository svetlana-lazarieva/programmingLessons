
namespace Task_7
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxDate = new System.Windows.Forms.CheckBox();
            this.checkBoxYear = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCount = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxDate);
            this.panel1.Controls.Add(this.checkBoxYear);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 65);
            this.panel1.TabIndex = 9;
            // 
            // checkBoxDate
            // 
            this.checkBoxDate.AutoSize = true;
            this.checkBoxDate.Location = new System.Drawing.Point(18, 33);
            this.checkBoxDate.Name = "checkBoxDate";
            this.checkBoxDate.Size = new System.Drawing.Size(220, 24);
            this.checkBoxDate.TabIndex = 10;
            this.checkBoxDate.Text = "Считаем точный возраст";
            this.checkBoxDate.UseVisualStyleBackColor = true;
            this.checkBoxDate.CheckedChanged += new System.EventHandler(this.checkBoxDate_CheckedChanged);
            // 
            // checkBoxYear
            // 
            this.checkBoxYear.AutoSize = true;
            this.checkBoxYear.Location = new System.Drawing.Point(18, 3);
            this.checkBoxYear.Name = "checkBoxYear";
            this.checkBoxYear.Size = new System.Drawing.Size(213, 24);
            this.checkBoxYear.TabIndex = 9;
            this.checkBoxYear.Text = "Считаем только по году";
            this.checkBoxYear.UseVisualStyleBackColor = true;
            this.checkBoxYear.CheckedChanged += new System.EventHandler(this.checkBoxYear_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBoxAge);
            this.panel2.Controls.Add(this.textBoxYear);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.buttonCount);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(495, 218);
            this.panel2.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(18, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Год рождения:";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(232, 106);
            this.textBoxAge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.ReadOnly = true;
            this.textBoxAge.Size = new System.Drawing.Size(244, 26);
            this.textBoxAge.TabIndex = 11;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(232, 40);
            this.textBoxYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(244, 26);
            this.textBoxYear.TabIndex = 10;
            this.textBoxYear.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Возраст:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Дата рождения:";
            // 
            // buttonCount
            // 
            this.buttonCount.Location = new System.Drawing.Point(232, 167);
            this.buttonCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(112, 35);
            this.buttonCount.TabIndex = 7;
            this.buttonCount.Text = "Считать";
            this.buttonCount.UseVisualStyleBackColor = true;
            this.buttonCount.Click += new System.EventHandler(this.ButtonCount_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 283);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(511, 322);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(511, 322);
            this.Name = "Form1";
            this.Text = "Task_7";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxDate;
        private System.Windows.Forms.CheckBox checkBoxYear;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

