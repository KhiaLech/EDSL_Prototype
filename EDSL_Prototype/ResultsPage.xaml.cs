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

namespace EDSL_Prototype
{
    /// <summary>
    /// Interaction logic for ResultsPage.xaml
    /// </summary>
    public partial class ResultsPage : Page
    {
        public ResultsPage()
        {
            InitializeComponent();
        }

        private void roundresults(object sender, RoutedEventArgs e)
        {
            hometeams.Visibility = Visibility.Visible;
            awayteams.Visibility = Visibility.Visible;
            gamescores.Visibility = Visibility.Visible;
            home.Visibility = Visibility.Visible;
            away.Visibility = Visibility.Visible;
            score.Visibility = Visibility.Visible;
            resultspopupheader.Visibility = Visibility.Visible;
            go2ladder.Visibility = Visibility.Visible;
        }

    
    }
}
