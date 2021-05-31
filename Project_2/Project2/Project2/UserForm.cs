using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace Project2
{
    public partial class UserForm : Form
    {
        public const string ConfigFilePath = "Temp//Config.json";
        MyModel myModel = new MyModel();
        public SingleUserConfig singleUserConfig = new SingleUserConfig();       

        public UserForm()
        {
            InitializeComponent();           
        }

       

        private void UserForm_Load(object sender, EventArgs e)
        {
            LoadConfig();
            AddCells();
            TotalCostLabel.Text = "Всего: 0 грн";
            GetCurrrentUserOrders();
            GetProdudtList();
        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Загрузить настройки
        /// </summary>
        private void LoadConfig()
        {
            if (File.Exists(ConfigFilePath))
            {
                string json = File.ReadAllText(ConfigFilePath);
                Config.UserSettings = JsonConvert.DeserializeObject<Dictionary<int, SingleUserConfig>>(json);
                int currUserId = AppState.CurrentUser.Id;
                singleUserConfig = Config.UserSettings[currUserId];
                UpdateComponents(singleUserConfig);
            }
        }

        /// <summary>
        ///  Обновляет компоненты на форме
        /// </summary>
        private void UpdateComponents(SingleUserConfig config)
        {
            // Цвет фона
            this.BackColor = Color.FromArgb(config.BackColor.R,
                                                config.BackColor.G,
                                                config.BackColor.B);
            // Цвет текста
            this.ForeColor = Color.FromArgb(config.FontColor.R,
                                                config.FontColor.G,
                                                config.FontColor.B);
            // Шрифт
            if (config.MyFont.Name != null)
            {
                var FontFamily = new FontFamily(config.MyFont.Name);
                this.Font = new Font(FontFamily,
                                         config.MyFont.EmSize,
                                         config.MyFont.Style);
            }
        }



        /// <summary>
        /// Получить список товаров
        /// </summary>
        private void GetProdudtList()
        {
            string sql = "select * from Product";
            var query = myModel.Database.SqlQuery<Product>(sql);

            foreach (var item in query)
            {
                int rowId = AllProductsDataGridView.Rows.Add();
                DataGridViewRow row = AllProductsDataGridView.Rows[rowId];
                row.Cells["productId"].Value = item.ProductId;
                row.Cells["productName"].Value = item.productName;
                row.Cells["productPrice"].Value = item.productPrice;
            }
        }

        /// <summary>
        /// Добавить колонки в DataGridView
        /// </summary>
        private void AddCells()
        {
            AllProductsDataGridView.Columns.Add("productId", "Id");
            AllProductsDataGridView.Columns.Add("productName", "Название товара");
            AllProductsDataGridView.Columns.Add("productPrice", "Цена");

            dataGridView1.Columns.Add("productId", "Id");
            dataGridView1.Columns.Add("productName", "Название товара");
            dataGridView1.Columns.Add("productPrice", "Цена");
            dataGridView1.Columns.Add("productQuantity", "Количество");
        }

        private void AllProductsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RefreshBascet();
        }

        /// <summary>
        /// Добавить товары в корзину
        /// </summary>
        private void AddProductsToBascet()
        {
            string prId = AllProductsDataGridView.CurrentRow.Cells[0].Value.ToString();
            string prod = AllProductsDataGridView.CurrentRow.Cells[1].Value.ToString();
            string price = AllProductsDataGridView.CurrentRow.Cells[2].Value.ToString();

            // Проверяем, такой есть ли товар в корзине
            if (IsNewProduct(prId, out int rowNumber))
            {
                AddNewRow(prId, prod, price);
            }
            else
            {
                ChengeQuantityValue(rowNumber);
            }               
        }

        /// <summary>
        /// Увеличивает количество единиц товара на 1
        /// </summary>
        private void ChengeQuantityValue(int rNumb)
        {
            string quantityValue = dataGridView1.Rows[rNumb].Cells[3].Value.ToString();
            if(Int32.TryParse(quantityValue, out int qValue))
            {
                dataGridView1.Rows[rNumb].Cells[3].Value = qValue + 1;
            }
        }

        /// <summary>
        /// Добавить строку с новым товаром в корзину
        /// </summary>
        /// <param name="prId"> Id товара</param>
        /// <param name="prod"> Название товара</param>
        /// <param name="price"> Цена товара</param>
        private void AddNewRow(string prId, string prod, string price)
        {
            int rowsCpount = dataGridView1.Rows.Count;
            dataGridView1.Rows.Add();
            DataGridViewRow row = dataGridView1.Rows[rowsCpount - 1];

            row.Cells["productId"].Value = prId;
            row.Cells["productName"].Value = prod;
            row.Cells["productPrice"].Value = price;
            row.Cells["productQuantity"].Value = 1;
        }

        /// <summary>
        /// Проыеряет, есть ли такой товар в корзине по prId
        /// </summary>
        /// <param name="prId"> Id товара</param>
        /// <returns></returns>
        private bool IsNewProduct(string prId, out int rowNumber)
        {
            int rowCount = dataGridView1.RowCount;
            if (rowCount > 1)
            {
                for (int i = 0; i < rowCount-1; i++)
                {
                    if ((dataGridView1[0, i].Value != null) &&
                        (dataGridView1[0, i].Value.ToString() == prId))
                    {
                        rowNumber = i;
                        return false;
                    }
                }
            }
 
            rowNumber = 0;
            return true;
        }

        /// <summary>
        /// Получить общую стоимость заказа
        /// </summary>
        private double GetTotalPrice()
        {
            double totalPrice = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                string priceStr = row.Cells["productPrice"].Value.ToString();
                string prQuantity = row.Cells["productQuantity"].Value.ToString();

                if ((double.TryParse(priceStr, out double currentPrice))&&
                    (double.TryParse(prQuantity,out double prQ)))
                {
                    totalPrice += currentPrice* prQ;
                }
            }
            return totalPrice;
        }

        /// <summary>
        /// Обновить корзину
        /// </summary>
        private void RefreshBascet()
        {
            AddProductsToBascet();
            double totalPrice = GetTotalPrice();
            TotalCostLabel.Text = $"Всего: {totalPrice} грн";
        }


        private void CreateNewOrderButton_Click(object sender, EventArgs e)
        {
            CreateNewOrder();
        }

        /// <summary>
        /// Создать новый заказ
        /// </summary>
        private void CreateNewOrder()
        {
            string ordName = CreateOrderName();
            var usId = AppState.CurrentUser.UserId;
             
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                Int32.TryParse(row.Cells[0].Value.ToString(), out int prId);
                string prod = row.Cells[1].Value.ToString();
                string price = row.Cells[2].Value.ToString();
                Int32.TryParse(row.Cells[0].Value.ToString(), out int prQuantity);

                // Добавить в таблицу Order заказ
                myModel.Orders.Add(new Order()
                {
                    //OrderRecordId = 17,
                    orderName = ordName,
                    UserId = usId,
                    ProductId = prId,
                    productQuantity = prQuantity
                });
            }

            MessageBox.Show("Заказик принят.");
        }

        /// <summary>
        /// Получить Id продукта
        /// </summary>
        /// <returns>Id продукта</returns>
        private int GetProductId(string prod, string price)
        {
            int prId = 0;
            var prNames = myModel.Products.FirstOrDefault(x => x.productName == prod);
            return prId;
        }
      
        private void OrderListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Получить список заказов пользователя
        /// </summary>
        private void GetCurrrentUserOrders()
        {
            int userId = AppState.CurrentUser.UserId;
            var orderList = myModel.Orders.Where(x => x.UserId == userId).Select(y => y.orderName).Distinct();
            int i = 0;

            foreach (var item in orderList)
            {
                OrderListComboBox.Items.Add(item);              
                i++;
            }
        }

        /// <summary>
        /// Сoздать имя заказа
        /// </summary>
        private string CreateOrderName()
        {
            return $"{OrderNameTextBox.Text}_{DateTime.Now}";
        }

        private void ConfigButton_Click(object sender, EventArgs e)
        {
            ConfigForm config = new ConfigForm(this);
            config.ShowDialog();
        }
    }
}
