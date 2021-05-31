using System;
using System.Linq;
using System.Windows.Forms;

namespace Project2
{
    public partial class AdminForm : Form
    {
        int selectedIndex = 0;
        MyModel myModel = new MyModel();
        DataDisplayMeneger displayMeneger = new DataDisplayMeneger();

        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndex = comboBox1.SelectedIndex;
            ShowData();
        }

        private void ShowData()
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        AddPanel.Visible = false;
                        displayMeneger.ShowProducts(dataGridView1);                        
                        break;
                    }
                case 1:
                    {
                        AddPanel.Visible = true;
                        displayMeneger.ShowUsers(dataGridView1);                        
                        break;
                    }
                case 2:
                    {
                        AddPanel.Visible = false;
                        displayMeneger.ShowOrders(dataGridView1);
                        break;
                    }
                default:
                    break;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            User user = null;
            int id = int.Parse(IdTextBox.Text);
            var rowToEdit = myModel.Users.FirstOrDefault(x => x.Id == id );
            if (rowToEdit == null)
            {
                user = new User();
            }
            else
            {
                user = rowToEdit;  
            }

            user.UserId = id;
            user.password = passwordTextBox.Text;
            user.userAddress = userAddressTextBox.Text;
            user.userName = userNameTextBox.Text;
            user.userType = GetUserType();


            DBManager dBManager = new DBManager(myModel);
            dBManager.AddOrUpdate(user, rowToEdit != null);
            ShowData();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        /// <summary>
        /// Заполнить поля для редактирования данными из текущей строки
        /// </summary>
        private void GetDataFromCurrentRow()
        {
            if ((selectedIndex == 1) &&
                            (dataGridView1.Rows.Count > 0) &&
                            (dataGridView1.CurrentRow != null))
            {
                IdTextBox.Text = GetValue(0);
                userNameTextBox.Text = GetValue(1);
                userAddressTextBox.Text = GetValue(2);
                passwordTextBox.Text = GetValue(4);
                
                if (!Int32.TryParse(GetValue(3), out int userType))
                {
                    userType = 1;
                }
                SetUserTypeChecker(userType);


            }
        }

        /// <summary>
        /// Если значение ячейки тьекущей строки не пустое, то приводит его к строке
        /// </summary>
        /// <param name="index"> Индекс ячейки</param>
        /// <returns></returns>
        private string GetValue(int index)
        {
            string value = string.Empty;
            if (dataGridView1.CurrentRow.Cells[index].Value != null)
            {
                value = dataGridView1.CurrentRow.Cells[index].Value.ToString();
            }
            return value;
        }


        /// <summary>
        /// Получить тип пользователя
        /// </summary>
        /// <returns>Тип пользователя</returns>
        private int GetUserType()
        {
            int userType = 0;
            if (userButton.Checked == true)
            {
                userType = 1;
            }
            else if (adminButton.Checked == true)
            {
                userType = 2;
            }
            else if (menegerButton.Checked == true)
            {
                userType = 3;
            }
            return userType;
        }

        /// <summary>
        /// Настроить CheckBox в зависимости от типа пользователя
        /// </summary>
        /// <param name="userType">Тип пользователя</param>
        private void SetUserTypeChecker(int userType)
        {
            switch (userType)
            {
                case 1:
                    {
                        userButton.Checked = true;
                        break;
                    }
                case 2:
                    {
                        adminButton.Checked = true;
                        break;
                    }
                case 3:
                    {
                        menegerButton.Checked = true;
                        break;
                    }
                default: 
                    {
                        userButton.Checked = true;
                        break;
                    }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetDataFromCurrentRow();
        }

        private void menegerButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void userButton_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
