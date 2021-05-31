
namespace Project2
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.AllProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.NextPanel = new System.Windows.Forms.Panel();
            this.ServisePanel = new System.Windows.Forms.Panel();
            this.OrderLabel = new System.Windows.Forms.Label();
            this.OrderListComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.TotalCostPanel = new System.Windows.Forms.Panel();
            this.CreateNewOrderButton = new System.Windows.Forms.Button();
            this.TotalCostLabel = new System.Windows.Forms.Label();
            this.OrderNamePanel = new System.Windows.Forms.Panel();
            this.OrderNameTextBox = new System.Windows.Forms.TextBox();
            this.OrderNameLabel = new System.Windows.Forms.Label();
            this.ConfigButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllProductsDataGridView)).BeginInit();
            this.ServisePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.TotalCostPanel.SuspendLayout();
            this.OrderNamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.AllProductsDataGridView);
            this.splitContainer1.Panel1.Controls.Add(this.NextPanel);
            this.splitContainer1.Panel1.Controls.Add(this.ServisePanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Controls.Add(this.vScrollBar1);
            this.splitContainer1.Panel2.Controls.Add(this.TotalCostPanel);
            this.splitContainer1.Panel2.Controls.Add(this.OrderNamePanel);
            this.splitContainer1.Size = new System.Drawing.Size(856, 450);
            this.splitContainer1.SplitterDistance = 429;
            this.splitContainer1.TabIndex = 0;
            // 
            // AllProductsDataGridView
            // 
            this.AllProductsDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.AllProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllProductsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllProductsDataGridView.Location = new System.Drawing.Point(0, 59);
            this.AllProductsDataGridView.Name = "AllProductsDataGridView";
            this.AllProductsDataGridView.Size = new System.Drawing.Size(427, 342);
            this.AllProductsDataGridView.TabIndex = 2;
            this.AllProductsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllProductsDataGridView_CellDoubleClick);
            // 
            // NextPanel
            // 
            this.NextPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NextPanel.Location = new System.Drawing.Point(0, 401);
            this.NextPanel.Name = "NextPanel";
            this.NextPanel.Size = new System.Drawing.Size(427, 47);
            this.NextPanel.TabIndex = 1;
            // 
            // ServisePanel
            // 
            this.ServisePanel.Controls.Add(this.ConfigButton);
            this.ServisePanel.Controls.Add(this.OrderLabel);
            this.ServisePanel.Controls.Add(this.OrderListComboBox);
            this.ServisePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ServisePanel.Location = new System.Drawing.Point(0, 0);
            this.ServisePanel.Name = "ServisePanel";
            this.ServisePanel.Size = new System.Drawing.Size(427, 59);
            this.ServisePanel.TabIndex = 0;
            // 
            // OrderLabel
            // 
            this.OrderLabel.AutoSize = true;
            this.OrderLabel.Location = new System.Drawing.Point(12, 13);
            this.OrderLabel.Name = "OrderLabel";
            this.OrderLabel.Size = new System.Drawing.Size(69, 13);
            this.OrderLabel.TabIndex = 1;
            this.OrderLabel.Text = "Мои заказы";
            // 
            // OrderListComboBox
            // 
            this.OrderListComboBox.FormattingEnabled = true;
            this.OrderListComboBox.Location = new System.Drawing.Point(15, 29);
            this.OrderListComboBox.Name = "OrderListComboBox";
            this.OrderListComboBox.Size = new System.Drawing.Size(244, 21);
            this.OrderListComboBox.TabIndex = 0;
            this.OrderListComboBox.SelectedIndexChanged += new System.EventHandler(this.OrderListComboBox_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(404, 370);
            this.dataGridView1.TabIndex = 3;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(404, 31);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 370);
            this.vScrollBar1.TabIndex = 2;
            // 
            // TotalCostPanel
            // 
            this.TotalCostPanel.Controls.Add(this.CreateNewOrderButton);
            this.TotalCostPanel.Controls.Add(this.TotalCostLabel);
            this.TotalCostPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TotalCostPanel.Location = new System.Drawing.Point(0, 401);
            this.TotalCostPanel.Name = "TotalCostPanel";
            this.TotalCostPanel.Size = new System.Drawing.Size(421, 47);
            this.TotalCostPanel.TabIndex = 1;
            // 
            // CreateNewOrderButton
            // 
            this.CreateNewOrderButton.Location = new System.Drawing.Point(180, 8);
            this.CreateNewOrderButton.Name = "CreateNewOrderButton";
            this.CreateNewOrderButton.Size = new System.Drawing.Size(66, 28);
            this.CreateNewOrderButton.TabIndex = 1;
            this.CreateNewOrderButton.Text = "Заказать";
            this.CreateNewOrderButton.UseVisualStyleBackColor = true;
            this.CreateNewOrderButton.Click += new System.EventHandler(this.CreateNewOrderButton_Click);
            // 
            // TotalCostLabel
            // 
            this.TotalCostLabel.AutoSize = true;
            this.TotalCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalCostLabel.Location = new System.Drawing.Point(2, 16);
            this.TotalCostLabel.Name = "TotalCostLabel";
            this.TotalCostLabel.Size = new System.Drawing.Size(52, 16);
            this.TotalCostLabel.TabIndex = 0;
            this.TotalCostLabel.Text = "Всего: ";
            // 
            // OrderNamePanel
            // 
            this.OrderNamePanel.Controls.Add(this.OrderNameTextBox);
            this.OrderNamePanel.Controls.Add(this.OrderNameLabel);
            this.OrderNamePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.OrderNamePanel.Location = new System.Drawing.Point(0, 0);
            this.OrderNamePanel.Name = "OrderNamePanel";
            this.OrderNamePanel.Size = new System.Drawing.Size(421, 31);
            this.OrderNamePanel.TabIndex = 0;
            // 
            // OrderNameTextBox
            // 
            this.OrderNameTextBox.Location = new System.Drawing.Point(135, 6);
            this.OrderNameTextBox.Name = "OrderNameTextBox";
            this.OrderNameTextBox.Size = new System.Drawing.Size(109, 20);
            this.OrderNameTextBox.TabIndex = 1;
            // 
            // OrderNameLabel
            // 
            this.OrderNameLabel.AutoSize = true;
            this.OrderNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderNameLabel.Location = new System.Drawing.Point(3, 9);
            this.OrderNameLabel.Name = "OrderNameLabel";
            this.OrderNameLabel.Size = new System.Drawing.Size(136, 17);
            this.OrderNameLabel.TabIndex = 0;
            this.OrderNameLabel.Text = "Список покупочек: ";
            // 
            // ConfigButton
            // 
            this.ConfigButton.Location = new System.Drawing.Point(361, 4);
            this.ConfigButton.Name = "ConfigButton";
            this.ConfigButton.Size = new System.Drawing.Size(63, 22);
            this.ConfigButton.TabIndex = 2;
            this.ConfigButton.Text = "Настройки";
            this.ConfigButton.UseVisualStyleBackColor = true;
            this.ConfigButton.Click += new System.EventHandler(this.ConfigButton_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserForm_FormClosed);
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AllProductsDataGridView)).EndInit();
            this.ServisePanel.ResumeLayout(false);
            this.ServisePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.TotalCostPanel.ResumeLayout(false);
            this.TotalCostPanel.PerformLayout();
            this.OrderNamePanel.ResumeLayout(false);
            this.OrderNamePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel ServisePanel;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Panel TotalCostPanel;
        private System.Windows.Forms.Panel OrderNamePanel;
        private System.Windows.Forms.Panel NextPanel;
        private System.Windows.Forms.Label OrderNameLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label TotalCostLabel;
        private System.Windows.Forms.Button CreateNewOrderButton;
        private System.Windows.Forms.Label OrderLabel;
        private System.Windows.Forms.ComboBox OrderListComboBox;
        private System.Windows.Forms.DataGridView AllProductsDataGridView;
        private System.Windows.Forms.TextBox OrderNameTextBox;
        private System.Windows.Forms.Button ConfigButton;
    }
}