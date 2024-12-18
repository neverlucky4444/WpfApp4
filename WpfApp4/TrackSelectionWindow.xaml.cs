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
    public partial class TrackSelectionWindow : Window
    {
        public TrackSelectionWindow()
        {
            InitializeComponent();
            LoadTracks();
        }

        private void LoadTracks()
        {
            using (var connection = new MySql.Data.MySqlClient.MySqlConnection("server=localhost;database=kartingdb;user=root;password=yourpassword"))
            {
                connection.Open();
                string query = "SELECT Name FROM tracks";
                using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TrackComboBox.Items.Add(reader.GetString("Name"));
                    }
                }
            }
        }
    }
}
