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
    /// Interaction logic for SeasonPage.xaml
    /// </summary>
    /// 

    public partial class SeasonPage : Page
    {
        public SeasonPage()
        {
            InitializeComponent();

        }

        private void genDateList(object sender, RoutedEventArgs e)
        {

            DateList.Visibility = Visibility.Visible;
            roundnum.Visibility = Visibility.Visible;
            deletebutton.Visibility = Visibility.Visible;
            confirmbutton.Visibility = Visibility.Visible;

        }

        private void Direct2DrawScreen(object sender, RoutedEventArgs e)
        {
           
            drawmessage.Visibility = Visibility.Visible;

        }

        private void buttonclickRemoveDate(object sender, RoutedEventArgs e)
        {
            DateList.Items.Remove(DateList.SelectedItem);
        }

        private void showDates(object sender, RoutedEventArgs e)
        {
            roundnum.Visibility = Visibility.Visible;
            datelistFixed.Visibility = Visibility.Visible;
        }
    }
}
