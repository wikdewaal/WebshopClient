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

namespace WebshopClient
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

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            //Hier moet eerst nog de methode die login gegevens verifiërd in.
            StoreWindow win2 = new StoreWindow();
            win2.Show();
            this.Close();
        }

        private void usernamePassword_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        
    }
}
