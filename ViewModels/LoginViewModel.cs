using System.ComponentModel;
using System.Windows.Input;
using ATM.Services;
using ATMProjet.ViewModels;

namespace ATM.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private readonly AuthService _authService;
        private string _pin;
        private string _cardNumber;
        private string _loginStatus;

        public string Pin
        {
            get => _pin;
            set
            {
                if (_pin != value)
                {
                    _pin = value;
                    OnPropertyChanged(nameof(Pin));
                }
            }
        }

        public string CardNumber
        {
            get => _cardNumber;
            set
            {
                if (_cardNumber != value)
                {
                    _cardNumber = value;
                    OnPropertyChanged(nameof(CardNumber));
                }
            }
        }

        public string LoginStatus
        {
            get => _loginStatus;
            private set
            {
                if (_loginStatus != value)
                {
                    _loginStatus = value;
                    OnPropertyChanged(nameof(LoginStatus));
                }
            }
        }

        public ICommand LoginCommand { get; }

        public LoginViewModel(AuthService authService)
        {
            _authService = authService;
            LoginCommand = new RelayCommand(Login, CanLogin);
        }

        private void Login(object parameter)
        {
            if (_authService.Authenticate(CardNumber, Pin))
            {
                LoginStatus = "Bienvenue !";
                // Naviguer vers une autre vue ou effectuer d'autres actions
            }
            else
            {
                LoginStatus = "Échec de la connexion !";
            }
        }

        private bool CanLogin(object parameter)
        {
            return !string.IsNullOrWhiteSpace(Pin) && !string.IsNullOrWhiteSpace(CardNumber);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
