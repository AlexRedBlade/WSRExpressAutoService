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
    /// Логика взаимодействия для Employees.xaml
    /// </summary>
    public partial class Employees : Window
    {
        public Employees()
        {
            InitializeComponent(); 
            this.Loaded += Employees_Loaded;
            this.Closed += Employees_Closed;
        }
        private void Employees_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void Employees_Closed(object sender, EventArgs e)
        {
            MainWindow tw = new MainWindow();
            tw.Show();
            this.Close();
        }
    }
}
