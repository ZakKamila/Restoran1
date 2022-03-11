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

namespace Ресторан
{
    /// <summary>
    /// Логика взаимодействия для Bron.xaml
    /// </summary>
    public partial class Bron : Window
    {
        public Bron()
        {
            InitializeComponent();
        }

        private void BtnБронь_Click(object sender, RoutedEventArgs e)
        {
            string message = "Стол забронирован. С Вами свяжутся!";
            MessageBox.Show(message);
        }

        private void BtnНазад_Click(object sender, RoutedEventArgs e)
        {
            menu menu = new menu();
            menu.Show();
            Close();
        }

        private void _1stol_Click(object sender, RoutedEventArgs e)
        {
            string message = "Выбрать данный стол?";
            MessageBox.Show(message);
        }

        private void _3stol_Click(object sender, RoutedEventArgs e)
        {
            string message = "Выбрать данный стол?";
            MessageBox.Show(message);
        }

        private void _6stol_Click(object sender, RoutedEventArgs e)
        {
            string message = "Выбрать данный стол?";
            MessageBox.Show(message);
        }

        private void _7stol_Click(object sender, RoutedEventArgs e)
        {
            string message = "Выбрать данный стол?";
            MessageBox.Show(message);
        }

        private void _8stol_Click(object sender, RoutedEventArgs e)
        {
            string message = "Выбрать данный стол?";
            MessageBox.Show(message);
        }

        private void _9stol_Click(object sender, RoutedEventArgs e)
        {
            string message = "Выбрать данный стол?";
            MessageBox.Show(message);
        }

        private void _10stol_Click(object sender, RoutedEventArgs e)
        {
            string message = "Выбрать данный стол?";
            MessageBox.Show(message);
        }

        private void _2stol_Click(object sender, RoutedEventArgs e)
        {
            string message = "Выбрать данный стол?";
            MessageBox.Show(message);
        }

        private void _4stol_Click(object sender, RoutedEventArgs e)
        {
            string message = "Выбрать данный стол?";
            MessageBox.Show(message);
        }

        private void _5stol_Click(object sender, RoutedEventArgs e)
        {
            string message = "Выбрать данный стол?";
            MessageBox.Show(message);
        }
    }
}
