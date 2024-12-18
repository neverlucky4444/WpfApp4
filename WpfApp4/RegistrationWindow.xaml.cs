using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp4
{
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void RegisterUser(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Password;

            // Пример вставки в базу данных MySQL
            using (var connection = new MySql.Data.MySqlClient.MySqlConnection("server=localhost;database=kartingdb;user=root;password=yourpassword"))
            {
                connection.Open();
                string query = "INSERT INTO customers (Name, Email) VALUES (@name, @email)";
                using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@name", username);
                    cmd.Parameters.AddWithValue("@email", password);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Пользователь зарегистрирован!");
        }
    }
}