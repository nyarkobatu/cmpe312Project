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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace Proje
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 


    public partial class MainWindow : Window
    {





        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddProduct win2 = new AddProduct();
            win2.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           Close();
        }

        private void DarkMode_Checked(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.Proje = "Dark";
            Properties.Settings.Default.Save();
        }

        private void LightMode_Checked(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.Proje = "Light";
            Properties.Settings.Default.Save();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            UpdateProduct win3 = new UpdateProduct();
            win3.Show();
        }
    }
}
