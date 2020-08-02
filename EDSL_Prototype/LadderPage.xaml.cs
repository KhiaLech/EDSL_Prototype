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
    /// Interaction logic for LadderPage.xaml
    /// </summary>
    public partial class LadderPage : Page
    {
        public LadderPage()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void buttonclickDiv1Ladder(object sender, RoutedEventArgs e)
        {
            LadderHeader.Visibility = Visibility.Visible;
            LadderRoundHeader.Visibility = Visibility.Visible;
            exampleLadder.Visibility = Visibility.Visible;
        }   
    }
}
