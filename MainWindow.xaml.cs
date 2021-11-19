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

namespace testwpf
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {            
            CenterFrame.Navigate(new System.Uri("NewProtocol.xaml", UriKind.RelativeOrAbsolute));
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CenterFrame.Navigate(new System.Uri("Settings.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            CenterFrame.Navigate(new System.Uri("ProtocolOverview.xaml", UriKind.RelativeOrAbsolute));
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            CenterFrame.Navigate(new System.Uri("Search.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
