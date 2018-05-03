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
    /// Логика взаимодействия для OutputPage.xaml
    /// </summary>
    public partial class OutputPage : Page
    {
        public delegate void AccountStateHandler(string message);
        AccountStateHandler _del;
        public void RegisterHandler(AccountStateHandler del)
        {
            _del = del;
        }
        private Window window;
        private User user;
        public OutputPage(Window window,User user)
        {
            InitializeComponent();
            this.window = window;
            this.user = user;
        }

        private void ReplenishButton_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new UserContext())
            {
                if (int.Parse(countMoneyBox.Text) <= user.Purse.Count)
                {
                    user.Purse.Count -= int.Parse(countMoneyBox.Text);

                    if (_del != null)
                        _del($"Сумма {countMoneyBox.Text} снята со счета");

                    context.Purse.Add(user.Purse);
                    context.SaveChanges();
                }
                else
                {
                    if (_del != null)
                        _del("Недостаточно денег на счете");
                }
            }
        }
    }
}
