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
using System.Windows.Shapes;

namespace Ресторан
{
    /// <summary>
    /// Логика взаимодействия для login.xaml
    /// </summary>
    public partial class login : Window
    {
        public login()
        {
            InitializeComponent();
        }

        private void enterGos_Click(object sender, RoutedEventArgs e)
        {
            MenuGost MenuGost = new MenuGost();
            MenuGost.Show();
            Close();
        }

        private void regis1_Click(object sender, RoutedEventArgs e)
        {
            regis regis = new regis();
            regis.Show();
            Close();
        }

        private void enter_Click(object sender, RoutedEventArgs e)
        {
            menu menu = new menu();
            menu.Show();
            Close();
        }
    }
}
