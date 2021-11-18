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
    /// Interaktionslogik für NewProtocol.xaml
    /// </summary>
    public partial class NewProtocol : Page
    {
        public NewProtocol()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (NewAttendee.Text.Length > 0) {
            string attendeeToAdd = NewAttendee.Text;
            attendees.Items.Add(attendeeToAdd);
        }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (attendees.SelectedItem != null)
            {
                string attendeeToDelete = attendees.SelectedItem.ToString();
                attendees.Items.Remove(attendeeToDelete);
            }
            
        }

        int i = 0;
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (i == 0) { 
            Frame1.Navigate(new System.Uri("DecisionMask.xaml", UriKind.RelativeOrAbsolute));
            }
        }

        private void DecisionPanel_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }
    }
}
