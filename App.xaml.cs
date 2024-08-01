using System.Windows;
using ATM.Data;
using ATM.Services;

namespace ATMProjet
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Créez le contexte de la base de données
            var context = new ATMContext();

            // Créez le service d'authentification
            var authService = new AuthService(context);

            // Créez et montrez la fenêtre principale
            var mainWindow = new MainWindow();
            mainWindow.SetAuthService(authService);
            mainWindow.Show();
        }
    }
}