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
    /// Логика взаимодействия для Galer.xaml
    /// </summary>
    public partial class Galer : Window
    {
        public Galer()
        {
            InitializeComponent();
        }

        private void BtnНазад_Click(object sender, RoutedEventArgs e)
        {
            menu menu = new menu();
            menu.Show();
            Close();
        }
    }
}
