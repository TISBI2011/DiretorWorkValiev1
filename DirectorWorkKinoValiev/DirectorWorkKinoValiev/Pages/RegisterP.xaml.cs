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
    /// Логика взаимодействия для RegisterP.xaml
    /// </summary>
    public partial class RegisterP : Page
    {
        public RegisterP()
        {
            InitializeComponent();
        }
        public User ContUser;
        public RegisterP(User selUser)
        {
            InitializeComponent();
            ContUser = selUser;
            this.DataContext = ContUser;
        }


        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            {
                if (ContUser.Id == 0)
                {
                    App.DB.User.Add(ContUser);
                }
                App.DB.SaveChanges();
                NavigationService.Navigate(new LoginP());
            }
        }
    }
}
