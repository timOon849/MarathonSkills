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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using MarathonSkills.DataBase;

namespace MarathonSkills.Pages
{
    /// <summary>
    /// Логика взаимодействия для RunnerSponsor.xaml
    /// </summary>
    public partial class RunnerSponsor : Page
    {

        public RunnerSponsor()
        {
            InitializeComponent();
            CmbxRunners.ItemsSource = ConnectionString.connection.Registration.ToList();
        }
        
        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void BtnPay_Click(object sender, RoutedEventArgs e)
        {
            Sponsorship sp = new Sponsorship();
            sp.SponsorName = SponsorName.Text;
            sp.Amount = int.Parse(MoneyTextBox.Text);
            Registration rg = CmbxRunners.SelectedItem as Registration;
            sp.RegistrationId = rg.RegistrationId;
            ConnectionString.connection.Sponsorship.Add(sp);
            ConnectionString.connection.SaveChanges();
            
            NavigationService.Navigate(new ConfirmSponsor(sp));
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new HomePage());
        }

        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {
            int money = int.Parse(MoneyTextBox.Text);
            money += 10;
            MoneyTextBox.Text = money.ToString();
        }

        private void BtnMinus_Click(object sender, RoutedEventArgs e)
        {
            int money = int.Parse(MoneyTextBox.Text);
            if (money >= 10)
            {
                money -= 10;
                MoneyTextBox.Text = money.ToString();
            }
        }

        private void MoneyTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string money = MoneyTextBox.Text;
            LabelMoney.Content = $"${money}";
        }
    }
}
