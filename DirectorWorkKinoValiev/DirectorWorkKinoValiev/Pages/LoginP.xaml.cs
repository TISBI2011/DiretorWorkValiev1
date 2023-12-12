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

namespace DirectorWorkKinoValiev.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginP.xaml
    /// </summary>
    public partial class LoginP : Page
    {
        public LoginP()
        {
            InitializeComponent();
        }
        private void Bsubmit_Click(object sender, RoutedEventArgs e)
        {
            var user = App.DB.User.FirstOrDefault(x => x.Login == TBlogin.Text);
            if (user == null || user.Password != TBpass.Text)
            {
                MessageBox.Show("Неверный логин или пароль");
                return;
            }
            App.LUser = user;
            NavigationService.Navigate(new MainMenuP());
        }

        private void Bregister_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegisterP());
        }
    }
}
