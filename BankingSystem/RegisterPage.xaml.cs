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

namespace BankingSystem
{
    /// <summary>
    /// Логика взаимодействия для RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : Page
    {
        public Window window;
        public RegisterPage(Window window)
        {
            InitializeComponent();
            this.window = window;
        }

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new UserContext())
            {
                User user = new User()
                {
                    Login = loginBox.Text,
                    Password = passwordBox.Password,
                    FullName = fullNameBox.Text,
                    CreationDate = DateTime.Now
                };
                Purse purse = new Purse()
                {
                    Count = 0,
                    TypeCurrency = "P",
                    UserId = user.Id
                };
                user.PurseId = purse.Id;

                context.Purse.Add(purse);
                context.Users.Add(user);
                

                context.SaveChanges();
            }
            window.Content = new LoginPage(window);
        }
    }
}
