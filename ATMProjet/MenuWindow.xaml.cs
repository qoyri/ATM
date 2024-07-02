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

namespace ATMProjet
{
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();
        }

        private void ViewBalance_Click(object sender, RoutedEventArgs e)
        {
            BalanceWindow balanceWindow = new BalanceWindow();
            balanceWindow.Show();
        }

        private void WithdrawMoney_Click(object sender, RoutedEventArgs e)
        {
            WithdrawWindow withdrawWindow = new WithdrawWindow();
            withdrawWindow.Show();
        }

        private void DepositMoney_Click(object sender, RoutedEventArgs e)
        {
            DepositWindow depositWindow = new DepositWindow();
            depositWindow.Show();
        }

    }
}