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
using System.Windows.Shapes;

namespace testwpf
{
    /// <summary>
    /// Interaktionslogik für loginScreen.xaml
    /// </summary>
    public partial class loginScreen : Window
    {
        public loginScreen()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {

            if (txtUsername.Text != "" && txtPassword.Password != "")
            {
                MainWindow home = new MainWindow();
                home.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Bitte geben Sie einen Benutzernamen und ein Passwort ein.");
            }


        }
    }
}
