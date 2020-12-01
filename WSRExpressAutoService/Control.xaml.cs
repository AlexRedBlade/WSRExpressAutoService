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

namespace WSRExpressAutoService
{
    /// <summary>
    /// Логика взаимодействия для Control.xaml
    /// </summary>
    public partial class Control : Window
    {
        public Control()
        {
            InitializeComponent();
            this.Loaded += Control_Loaded;
            this.Closed += Control_Closed;
        }
        private void Control_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void Control_Closed(object sender, EventArgs e)
        {
            MainWindow tw = new MainWindow();
            tw.Show();
            this.Close();
        }
    }
}
