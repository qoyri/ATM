using System.Collections.Generic;
using System.Windows;

namespace ATMProjet
{
    public partial class LoginWindow : Window
    {
        private readonly Dictionary<string, string> _users = new Dictionary<string, string>
        {
            { "user1", "1234" },  
            { "user2", "5678" }   
        };

        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string userNumber = UserNumberBox.Text;
            string enteredPin = PinBox.Password;

            if (_users.TryGetValue(userNumber, out string correctPin))
            {
                if (enteredPin == correctPin)
                {
                    MessageBox.Show("Bienvenue !");
                    MenuWindow menuWindow = new MenuWindow();
                    menuWindow.Show();
                    this.Close();
                }
                else
                {
                    StatusTextBlock.Text = "Code PIN erroné";
                }
            }
            else
            {
                StatusTextBlock.Text = "Numéro d'utilisateur invalide";
            }
        }
    }
}
