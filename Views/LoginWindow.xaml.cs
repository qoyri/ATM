using System.Windows;
using System.Windows.Controls;
using ATM.ViewModels;

namespace ATMProjet
{
    public partial class LoginWindow : Window
    {
        public LoginWindow(LoginViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }

        private void OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            if (DataContext is LoginViewModel viewModel)
            {
                viewModel.Pin = ((PasswordBox)sender).Password;
            }
        }
    }
}