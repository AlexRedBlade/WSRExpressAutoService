using System;
using System.Collections.Generic;
using System.IO;
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

namespace WSRExpressAutoService
{
    /// <summary>
    /// Логика взаимодействия для Clients.xaml
    /// </summary>
    public partial class Clients : Window
    {
        public Clients()
        {
            InitializeComponent();
            this.Loaded += Clients_Loaded;
            this.Closed += Clients_Closed;
        }
        private void Clients_Loaded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hi!");
        }
        private void Clients_Closed(object sender, EventArgs e)
        {
            MainWindow tw = new MainWindow();
            tw.Show();
            this.Close();
        }
    }
}
