using System.Threading.Tasks;
using System.Windows;
using ATM.Services;
using ATM.ViewModels;

namespace ATMProjet
{
    public partial class MainWindow : Window
    {
        private AuthService _authService;

        public MainWindow()
        {
            InitializeComponent();
        }

        public void SetAuthService(AuthService authService)
        {
            _authService = authService;
            StartLoading();
        }

        private async void StartLoading()
        {
            for (int i = 0; i <= 100; i++)
            {
                LoadingProgressBar.Value = i;
                LoadingText.Text = $"{i}%";
                await Task.Delay(30);

                Dispatcher.Invoke(() => { }, System.Windows.Threading.DispatcherPriority.ContextIdle);
            }

            // Créez une instance de LoginViewModel en passant AuthService
            var loginViewModel = new LoginViewModel(_authService);
            Application.Current.Dispatcher.Invoke(() => {
                var loginWindow = new LoginWindow(loginViewModel);
                loginWindow.Show();
                this.Close();
            });
        }
    }
}