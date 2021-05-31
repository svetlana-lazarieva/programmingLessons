using System.Windows.Forms;

namespace Project2
{
    /// <summary>
    /// Отображает данные
    /// </summary>
    public class DataDisplayMeneger
    {
        MyModel myModel = new MyModel();

        /// <summary>
        /// Вывести данные из таблици "Orders"
        /// </summary>
        public void ShowOrders(DataGridView dataGridView)
        {
            DeleteColumns(dataGridView);

            dataGridView.Columns.Add("Id", "Id заказа");
            dataGridView.Columns.Add("orderName", "Название заказа");
            dataGridView.Columns.Add("userId", "Id пользователя");
            dataGridView.Columns.Add("productID", "Id товара");
            dataGridView.Columns.Add("productQuantity", "Кол.ед. товара");

            foreach (var item in myModel.Orders)
            {
                int rowId = dataGridView.Rows.Add();
                DataGridViewRow row = dataGridView.Rows[rowId];

                row.Cells["Id"].Value = item.Id;
                row.Cells["orderName"].Value = item.orderName;
                row.Cells["userId"].Value = item.UserId;
                row.Cells["productID"].Value = item.ProductId;
                row.Cells["productQuantity"].Value = item.productQuantity;
            }
        }

        /// <summary>
        /// Вывести данные из таблици "Users"
        /// </summary>
        public void ShowUsers(DataGridView dataGridView)
        {
            DeleteColumns(dataGridView);

            dataGridView.Columns.Add("Id", "Id пользователя");
            dataGridView.Columns.Add("userName", "Имя");
            dataGridView.Columns.Add("userAddress", "Адрес");
            dataGridView.Columns.Add("userType", "Тип пользователя");
            dataGridView.Columns.Add("password", "Пароль");

            myModel = new MyModel();

            foreach (var item in myModel.Users)
            {
                int rowId = dataGridView.Rows.Add();
                DataGridViewRow row = dataGridView.Rows[rowId];

                row.Cells["Id"].Value = item.Id;
                row.Cells["userName"].Value = item.userName;
                row.Cells["userAddress"].Value = item.userAddress;
                row.Cells["userType"].Value = item.userType;
                row.Cells["password"].Value = item.password;
            }
        }

        /// <summary>
        /// Вывести данные из таблици "Products"
        /// </summary>
        public void ShowProducts(DataGridView dataGridView)
        {
            DeleteColumns(dataGridView);

            dataGridView.Columns.Add("Id", "Id товара");
            dataGridView.Columns.Add("productName", "Название заказа");
            dataGridView.Columns.Add("productPrice", "Цена");

            foreach (var item in myModel.Products)
            {
                int rowId = dataGridView.Rows.Add();
                DataGridViewRow row = dataGridView.Rows[rowId];

                row.Cells["Id"].Value = item.Id;
                row.Cells["productName"].Value = item.productName;
                row.Cells["productPrice"].Value = item.productPrice;
            }
        }

        /// <summary>
        /// Убираем лишние колонки из DataGridView
        /// </summary>
        private void DeleteColumns(DataGridView dataGridView)
        {
            int i = dataGridView.Columns.Count;
            while (i > 0)
            {
                dataGridView.Columns.Remove(dataGridView.Columns[i-1]);
                i = dataGridView.Columns.Count;
            }
        }
    }
}
