using System.Windows;

namespace ATMProjet
{
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bienvenue !");
        }
    }
}