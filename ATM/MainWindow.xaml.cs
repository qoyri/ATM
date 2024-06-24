using System.Threading.Tasks;
using System.Windows;

namespace ATMProjet
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
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

            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            this.Close();
        }
    }
}
