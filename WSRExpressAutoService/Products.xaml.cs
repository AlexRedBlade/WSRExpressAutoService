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
using System.Data;
using System.Data.SqlClient;

namespace WSRExpressAutoService
{
    /// <summary>
    /// Логика взаимодействия для Products.xaml
    /// </summary>
    public partial class Products : Window
    {
        public Products()
        {
            InitializeComponent();
            this.Loaded += Products_Loaded;
            this.Closed += Products_Closed;
        }
        private void Products_Loaded(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.AutoServiceConnectionString);
            try
            {
                connection.Open();
                string cmd = "SELECT * FROM product_a_import"; // Из какой таблицы нужен вывод 
                SqlCommand createCommand = new SqlCommand(cmd, connection);
                createCommand.ExecuteNonQuery();

                SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
                DataTable dt = new DataTable("Products");
                dataAdp.Fill(dt);
                ProductsGrid.ItemsSource = dt.DefaultView; // Сам вывод 
                connection.Close();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Ooops! Что-то пошло не так!");
            }
        }
        private void Products_Closed(object sender, EventArgs e)
        {
            MainWindow tw = new MainWindow();
            tw.Show();
            this.Close();
        }
    }
}
