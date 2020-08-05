using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace EDSL_Prototype
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

     
        public MainWindow()
        {
            InitializeComponent();

 
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void buttonclickResults(object sender, RoutedEventArgs e)
        {
            Main.Content = new ResultsPage();
        }

        private void buttonclickSeason(object sender, RoutedEventArgs e)
        {
            Main.Content = new SeasonPage();
        }

        private void buttonclickLadder(object sender, RoutedEventArgs e)
        {
            Main.Content = new LadderPage();
        }

        private void buttonclickDraw(object sender, RoutedEventArgs e)
        {
            Main.Content = new DrawPage();
        }

        private void buttonclickClub(object sender, RoutedEventArgs e)
        {
            Main.Content = new ClubPage();
        }

        private void buttonclickPlayers(object sender, RoutedEventArgs e)
        {
            Main.Content = new PlayersPage();
        }
    }
}


