﻿using System;
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
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        private Window window;
        private User user;
        public MainPage(Window window, User user)
        {
            InitializeComponent();
            this.window = window;
            this.user = user;

            userNameBlock.Text = user.FullName;
            countMoneyBox.Text = string.Concat(user.Purse.Count);
        }
    }
}
