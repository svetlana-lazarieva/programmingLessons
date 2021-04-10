
namespace FinalProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelCurrentMonth = new System.Windows.Forms.Panel();
            this.buttonGigthe = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.labelOfCurrentMonth = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBoxReport = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDateChange = new System.Windows.Forms.Button();
            this.textBoxDateChange = new System.Windows.Forms.TextBox();
            this.panelCurrentMonth.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCurrentMonth
            // 
            this.panelCurrentMonth.Controls.Add(this.buttonGigthe);
            this.panelCurrentMonth.Controls.Add(this.buttonLeft);
            this.panelCurrentMonth.Controls.Add(this.labelOfCurrentMonth);
            this.panelCurrentMonth.Location = new System.Drawing.Point(428, 12);
            this.panelCurrentMonth.Name = "panelCurrentMonth";
            this.panelCurrentMonth.Size = new System.Drawing.Size(272, 52);
            this.panelCurrentMonth.TabIndex = 1;
            // 
            // buttonGigthe
            // 
            this.buttonGigthe.Location = new System.Drawing.Point(229, 14);
            this.buttonGigthe.Name = "buttonGigthe";
            this.buttonGigthe.Size = new System.Drawing.Size(37, 23);
            this.buttonGigthe.TabIndex = 75;
            this.buttonGigthe.Text = ">>";
            this.buttonGigthe.UseVisualStyleBackColor = true;
            this.buttonGigthe.Click += new System.EventHandler(this.buttonGigthe_Click);
            this.buttonGigthe.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonGigthe_MouseDown);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(3, 14);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(41, 23);
            this.buttonLeft.TabIndex = 74;
            this.buttonLeft.Text = "<<";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            this.buttonLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonLeft_MouseDown);
            // 
            // labelOfCurrentMonth
            // 
            this.labelOfCurrentMonth.AutoSize = true;
            this.labelOfCurrentMonth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOfCurrentMonth.Location = new System.Drawing.Point(69, 14);
            this.labelOfCurrentMonth.Name = "labelOfCurrentMonth";
            this.labelOfCurrentMonth.Size = new System.Drawing.Size(66, 21);
            this.labelOfCurrentMonth.TabIndex = 73;
            this.labelOfCurrentMonth.Text = "label36";
            this.labelOfCurrentMonth.TextChanged += new System.EventHandler(this.labelOfCurrentMonth_TextChanged);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(882, 716);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Розрахувати завантаженність";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBoxReport
            // 
            this.richTextBoxReport.Location = new System.Drawing.Point(882, 750);
            this.richTextBoxReport.Name = "richTextBoxReport";
            this.richTextBoxReport.ReadOnly = true;
            this.richTextBoxReport.Size = new System.Drawing.Size(202, 175);
            this.richTextBoxReport.TabIndex = 6;
            this.richTextBoxReport.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDateChange);
            this.groupBox1.Controls.Add(this.textBoxDateChange);
            this.groupBox1.Location = new System.Drawing.Point(608, 750);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 75);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Змінити дату";
            // 
            // buttonDateChange
            // 
            this.buttonDateChange.Location = new System.Drawing.Point(222, 34);
            this.buttonDateChange.Name = "buttonDateChange";
            this.buttonDateChange.Size = new System.Drawing.Size(38, 23);
            this.buttonDateChange.TabIndex = 10;
            this.buttonDateChange.Text = "Ок";
            this.buttonDateChange.UseVisualStyleBackColor = true;
            this.buttonDateChange.Click += new System.EventHandler(this.buttonDateChange_Click);
            // 
            // textBoxDateChange
            // 
            this.textBoxDateChange.Location = new System.Drawing.Point(13, 34);
            this.textBoxDateChange.Name = "textBoxDateChange";
            this.textBoxDateChange.Size = new System.Drawing.Size(203, 23);
            this.textBoxDateChange.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 976);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBoxReport);
            this.Controls.Add(this.panelCurrentMonth);
            this.MaximumSize = new System.Drawing.Size(1130, 1015);
            this.MinimumSize = new System.Drawing.Size(1130, 1015);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Organizer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelCurrentMonth.ResumeLayout(false);
            this.panelCurrentMonth.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCurrentMonth;
        private System.Windows.Forms.Button buttonGigthe;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Label labelOfCurrentMonth;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBoxReport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonDateChange;
        private System.Windows.Forms.TextBox textBoxDateChange;
    }
}

