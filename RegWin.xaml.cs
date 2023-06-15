
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
using ООО_Малыш.Admin;

namespace ООО_Малыш
{
    /// <summary>
    /// Логика взаимодействия для RegWin.xaml
    /// </summary>
    public partial class RegWin : Window
    {
        public RegWin()
        {
            InitializeComponent();
        }

        private void Register(object sender, RoutedEventArgs e)
        {
            //тут будет проверка и переход на главную страницу

            string Login = Log.Text;
            string Password1 = Pass.Password;
            string Password2 = Pass2.Password;
            int n = 0;

            if (Login != "")
            {
                n += 1;
                sdf();
            }
            else
            {
                n = 0;
                MessageBox.Show("Логин не корректный");
            }
            if (Password1 != "")
            {
                n += 1;
                sdf();
            }
            else
            {
                n = 0;
                MessageBox.Show("Пароль не корректный");
            }
            if (Password1 == Password2)
            {
                n += 1;
                sdf();
            }
            else
            {
                n = 0;
                MessageBox.Show("Пароли не совпадают");
            }

            void sdf()
            {
                if (n == 3)
                {
                    MessageBox.Show("Регистрация пройдена успешно");
                    new MainAdminWin().Show();
                    this.Close();
                }
            }
        }
    }
}
