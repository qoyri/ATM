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
    public partial class DepositWindow : Window
    {
        public DepositWindow()
        {
            InitializeComponent();
        }

        private void Deposit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Montant déposé avec succès !");
            this.Close();
        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}