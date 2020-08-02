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
    /// Interaction logic for DrawPage.xaml
    /// </summary>
    public partial class DrawPage : Page
    {
        public DrawPage()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void buttonclickDiv1Draw(object sender, RoutedEventArgs e)
        {
            exampleDraw.Visibility = Visibility.Visible;
            exampleGrounds.Visibility = Visibility.Visible;
            DrawHeader.Visibility = Visibility.Visible;
        }
    }
}
