
namespace Project2
{
    partial class AdminForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TableChoseLabel1 = new System.Windows.Forms.Label();
            this.AddPanel = new System.Windows.Forms.Panel();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.userAddressTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.userButton = new System.Windows.Forms.RadioButton();
            this.adminButton = new System.Windows.Forms.RadioButton();
            this.menegerButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.AddPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AddPanel);
            this.panel1.Controls.Add(this.TableChoseLabel1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 95);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(797, 355);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(797, 355);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Продукты",
            "Пользователи",
            "Заказы"});
            this.comboBox1.Location = new System.Drawing.Point(12, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // TableChoseLabel1
            // 
            this.TableChoseLabel1.AutoSize = true;
            this.TableChoseLabel1.Location = new System.Drawing.Point(12, 21);
            this.TableChoseLabel1.Name = "TableChoseLabel1";
            this.TableChoseLabel1.Size = new System.Drawing.Size(82, 13);
            this.TableChoseLabel1.TabIndex = 0;
            this.TableChoseLabel1.Text = "Список таблиц";
            // 
            // AddPanel
            // 
            this.AddPanel.Controls.Add(this.groupBox1);
            this.AddPanel.Controls.Add(this.AddButton);
            this.AddPanel.Controls.Add(this.label5);
            this.AddPanel.Controls.Add(this.label3);
            this.AddPanel.Controls.Add(this.label2);
            this.AddPanel.Controls.Add(this.label1);
            this.AddPanel.Controls.Add(this.passwordTextBox);
            this.AddPanel.Controls.Add(this.userAddressTextBox);
            this.AddPanel.Controls.Add(this.userNameTextBox);
            this.AddPanel.Controls.Add(this.IdTextBox);
            this.AddPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.AddPanel.Location = new System.Drawing.Point(188, 0);
            this.AddPanel.Name = "AddPanel";
            this.AddPanel.Size = new System.Drawing.Size(609, 95);
            this.AddPanel.TabIndex = 1;
            this.AddPanel.Visible = false;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(5, 25);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(50, 20);
            this.IdTextBox.TabIndex = 0;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(61, 25);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.userNameTextBox.TabIndex = 1;
            // 
            // userAddressTextBox
            // 
            this.userAddressTextBox.Location = new System.Drawing.Point(167, 25);
            this.userAddressTextBox.Name = "userAddressTextBox";
            this.userAddressTextBox.Size = new System.Drawing.Size(219, 20);
            this.userAddressTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(392, 25);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Адрес";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Пароль";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(5, 51);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 10;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // userButton
            // 
            this.userButton.AutoSize = true;
            this.userButton.Checked = true;
            this.userButton.Location = new System.Drawing.Point(6, 16);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(54, 17);
            this.userButton.TabIndex = 12;
            this.userButton.TabStop = true;
            this.userButton.Text = "Гость";
            this.userButton.UseVisualStyleBackColor = true;
            this.userButton.CheckedChanged += new System.EventHandler(this.userButton_CheckedChanged);
            // 
            // adminButton
            // 
            this.adminButton.AutoSize = true;
            this.adminButton.Location = new System.Drawing.Point(6, 34);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(61, 17);
            this.adminButton.TabIndex = 13;
            this.adminButton.Text = "Админ.";
            this.adminButton.UseVisualStyleBackColor = true;
            // 
            // menegerButton
            // 
            this.menegerButton.AutoSize = true;
            this.menegerButton.Location = new System.Drawing.Point(6, 54);
            this.menegerButton.Name = "menegerButton";
            this.menegerButton.Size = new System.Drawing.Size(78, 17);
            this.menegerButton.TabIndex = 14;
            this.menegerButton.Text = "Менеджер";
            this.menegerButton.UseVisualStyleBackColor = true;
            this.menegerButton.CheckedChanged += new System.EventHandler(this.menegerButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.userButton);
            this.groupBox1.Controls.Add(this.menegerButton);
            this.groupBox1.Controls.Add(this.adminButton);
            this.groupBox1.Location = new System.Drawing.Point(498, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(101, 86);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип ";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminForm";
            this.Text = "Администрирование";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.AddPanel.ResumeLayout(false);
            this.AddPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label TableChoseLabel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel AddPanel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox userAddressTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton userButton;
        private System.Windows.Forms.RadioButton menegerButton;
        private System.Windows.Forms.RadioButton adminButton;
    }
}

