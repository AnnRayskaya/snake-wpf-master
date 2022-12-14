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

namespace snake_wpf
{
    /// <summary>
    /// Logica di interazione per StartMenu.xaml
    /// </summary>
    public partial class StartMenu : Page
    {
        public StartMenu()
        {
            InitializeComponent();
        }

        private void BtnClickNewGame(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SnakeGame());
        }

        private void BtnClickScores(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Scores());
        }
    }
}
