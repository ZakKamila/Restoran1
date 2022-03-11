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

namespace Ресторан
{
    /// <summary>
    /// Логика взаимодействия для menuBlud.xaml
    /// </summary>
    public partial class menuBlud : Window
    {
        public menuBlud()
        {
            InitializeComponent();

            var currenBludo = Ресторан1Entities.GetContext().Блюдо.ToList();
            LViewMenu.ItemsSource = currenBludo;
        }

        private void UpdateBludo()
        {
            var currentBludo = Ресторан1Entities.GetContext().Блюдо.ToList();
        }
        private void BtnНазад_Click(object sender, RoutedEventArgs e)
        {
            menu menu = new menu();
            menu.Show();
            Close();
        }

        private void LViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
