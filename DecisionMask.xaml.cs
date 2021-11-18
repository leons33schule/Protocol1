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
    /// Interaktionslogik für DecisionMask.xaml
    /// </summary>
    public partial class DecisionMask : Page
    {
        public DecisionMask()
        {
            InitializeComponent();
            yesVotes.Text = "0";
            noVotes.Text = "0";
            abstentationVotes.Text = "0";
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
