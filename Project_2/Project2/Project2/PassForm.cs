using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace Project2
{
    public partial class PassForm : Form
    {
        MyModel myModel = new MyModel();
        
        public PassForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int userType = 0;
            userType = GetUserType(userType);
            CheckUserType(userType);
        }

        /// <summary>
        /// Получить признак типа пользователя
        /// </summary>
        /// <param name="userType">Тип пользователя</param>
        /// <returns></returns>
        private int GetUserType(int userType)
        {
            Authenticator authenticator = new Authenticator(myModel);
            bool userExsists = authenticator.Authenticate(NameTextBox.Text, PassTextBox.Text);
            if (userExsists)
            {
                // 2 - adm 1, 3 - user 0 - no
                userType = AppState.CurrentUser.userType;
            }

            return userType;
        }

        /// <summary>
        /// Определить тип пользователя
        /// </summary>
        /// <param name="userType"> Признак типа пользователя</param>
        private void CheckUserType(int userType)
        {
            if (userType == 2)
            {
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
                this.Hide();
            }
            else if ((userType == 1) || (userType == 3))
            {
                UserForm userForm = new UserForm();
                userForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Пароль не верный.");
            }
        }
       
        private void PassForm_Load(object sender, EventArgs e)
        {
           // AddTestData();
        }

        /// <summary>
        /// Обновить БД и добавить тестовые даные
        /// </summary>
        private void AddTestData()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<MyModel>());
            AddDataToUsers(myModel);
            AddDataToProduct(myModel);
            AddDataToOrders(myModel);
            myModel.SaveChanges();
        }
        private void AddDataToUsers(MyModel myModel)
        {
            myModel.Users.Add(new User()
            {
                UserId = 1,
                userName = "1",
                userAddress = "есть, наверное",
                userType = 1,
                password = "1"
            });
            myModel.Users.Add(new User()
            {
                UserId = 2,
                userName = "Николай",
                userAddress = "точно есть",
                userType = 2,
                password = "123"
            });
            myModel.Users.Add(new User()
            {
                UserId = 3,
                userName = "Трафим",
                userAddress = "живет в каптерке",
                userType = 3,
                password = "1234"
            });
            myModel.Users.Add(new User()
            {
                UserId = 4,
                userName = "Виолета Владиславовна",
                userAddress = "южный полюс",
                userType = 1,
                password = "12345"
            });
        }

        private void AddDataToProduct(MyModel myModel)
        {
            myModel.Products.Add(new Product()
            {
                ProductId = 1,
                productName = "Тюлень",
                productPrice = 45
            });
            myModel.Products.Add(new Product()
            {
                ProductId = 2,
                productName = "Палка",
                productPrice = 4
            });
            myModel.Products.Add(new Product()
            {
                ProductId = 3,
                productName = "Томат",
                productPrice = 70
            });
            myModel.Products.Add(new Product()
            {
                ProductId = 4,
                productName = "Пальма",
                productPrice = 38
            });
            myModel.Products.Add(new Product()
            {
                ProductId = 5,
                productName = "Тюлень на пальме",
                productPrice = 6738
            });
        }

        private void AddDataToOrders(MyModel myModel)
        {
            myModel.Orders.Add(new Order()
            {
                OrderRecordId = 1,
                orderName = "НГ",
                UserId = 1,
                ProductId = 1,
                productQuantity = 3
            });
            myModel.Orders.Add(new Order()
            {
                OrderRecordId = 1,
                orderName = "НГ",
                UserId = 1,
                ProductId = 2,
                productQuantity = 1
            });
            myModel.Orders.Add(new Order()
            {
                OrderRecordId = 1,
                orderName = "НГ",
                UserId = 1,
                ProductId = 3,
                productQuantity = 1
            });
            myModel.Orders.Add(new Order()
            {
                OrderRecordId = 2,
                orderName = "Было скучно",
                UserId = 1,
                ProductId = 2,
                productQuantity = 1
            });
            myModel.Orders.Add(new Order()
            {
                OrderRecordId = 2,
                orderName = "Было скучно",
                UserId = 1,
                ProductId = 5,
                productQuantity = 1
            });

        }
    }
}
