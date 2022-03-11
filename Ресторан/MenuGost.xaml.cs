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
    /// Логика взаимодействия для MenuGost.xaml
    /// </summary>
    public partial class MenuGost : Window
    {
        public MenuGost()
        {
            InitializeComponent();
        }

        private void MENU_Click(object sender, RoutedEventArgs e)
        {
            menuBlud menuBlud = new menuBlud();
            menuBlud.Show();
            Close();
        }

        private void Galery_Click(object sender, RoutedEventArgs e)
        {
            Galer Galer = new Galer();
            Galer.Show();
            Close();
        }

        private void info_Click(object sender, RoutedEventArgs e)
        {
            infor info = new infor();
            info.Show();
            Close();
        }
    }
}
