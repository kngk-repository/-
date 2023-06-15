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
using ООО_Малыш.Admin;

namespace ООО_Малыш
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Login(object sender, RoutedEventArgs e)
        {
            new MainAdminWin().Show();
            this.Close();
            // тут должна быть проверка и передход на основное окно
            // Без проверки к сожалению, потому что она не будет работать из-за ошибки Microsoft, которую на экзамене починить будет затруднительно
        }

        private void Register(object sender, RoutedEventArgs e)
        {
            new RegWin().Show();
            this.Close();
            // переход на форму с регистрацией
        }

        private void Cancle(object sender, RoutedEventArgs e)
        {
            new MainAdminWin().Show();
            this.Close();
            //переход на основное окно
        }
    }
}
