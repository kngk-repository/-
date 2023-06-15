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

namespace ООО_Малыш.Admin
{
    /// <summary>
    /// Логика взаимодействия для MainAdminWin.xaml
    /// </summary>
    public partial class MainAdminWin : Window
    {
        public MainAdminWin()
        {
            InitializeComponent();
        }

        private void Product(object sender, RoutedEventArgs e)
        {
            AdminFrame.Navigate(new ListProduct());
        }

        private void CreatorPage(object sender, RoutedEventArgs e)
        {
            AdminFrame.Navigate(new Creator());
        }

        private void UsersPage(object sender, RoutedEventArgs e)
        {
            AdminFrame.Navigate(new Users());
        }

        private void RegWin(object sender, RoutedEventArgs e)
        {
            new RegWin().Show();
            this.Close();
        }
    }
}
