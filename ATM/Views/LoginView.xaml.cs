// Views/LoginView.xaml.cs
using System.Windows;
using ATM.Data;
using ATM.Services;

namespace ATMApp.Views
{
    public partial class LoginView : Window
    {
        private readonly AuthService _authService;

        public LoginView()
        {
            InitializeComponent();
            var context = new ATMContext();
            _authService = new AuthService(context);
        }

        private void OnLoginClick(object sender, RoutedEventArgs e)
        {
            var cardNumber = CardNumberTextBox.Text;
            var pinCode = PinCodeBox.Password;

            if (_authService.Authenticate(cardNumber, pinCode))
            {
                MessageBox.Show("Login successful!");
                // Naviguer vers l'écran suivant
            }
            else
            {
                MessageBox.Show("Numéro de carte ou code PIN incorrect.");
            }
        }
    }
}