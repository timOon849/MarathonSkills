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
        Charity fund;
        Registration rg;
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

        private void CmbxRunners_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            rg = CmbxRunners.SelectedItem as Registration;
            fund = rg.Charity;
            FundNameLabel.Text = fund.CharityName;
        }

        private void SponsorName_GotFocus(object sender, RoutedEventArgs e)
        {
            if (SponsorName.Text == "Ваше имя")
            {
                SponsorName.Text = "";
                SponsorName.Foreground = System.Windows.Media.Brushes.Black;
            }
        }

        private void SponsorName_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SponsorName.Text))
            {
                SponsorName.Text = "Ваше имя";
                SponsorName.Foreground = System.Windows.Media.Brushes.Gray;
            }
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (CardHolderName.Text == "Владелец карты")
            {
                CardHolderName.Text = "";
                CardHolderName.Foreground = System.Windows.Media.Brushes.Black;
            }
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CardHolderName.Text))
            {
                CardHolderName.Text = "Владелец карты";
                CardHolderName.Foreground = System.Windows.Media.Brushes.Gray;
            }
        }

        private void TextBox_GotFocus_2(object sender, RoutedEventArgs e)
        {
            if (CardMonth.Text == "01" && CardMonth.Foreground != System.Windows.Media.Brushes.Black)
            {
                CardMonth.Text = "";
                CardMonth.Foreground = System.Windows.Media.Brushes.Black;
            }
        }

        private void TextBox_LostFocus_2(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CardMonth.Text))
            {
                CardMonth.Text = "01";
                CardMonth.Foreground = System.Windows.Media.Brushes.Gray;
            }
        }

        private void TextBox_GotFocus_3(object sender, RoutedEventArgs e)
        {
            if (CardYear.Text == "2017" && CardYear.Foreground != System.Windows.Media.Brushes.Black)
            {
                CardYear.Text = "";
                CardYear.Foreground = System.Windows.Media.Brushes.Black;
            }
        }

        private void TextBox_LostFocus_3(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CardYear.Text))
            {
                CardYear.Text = "2017";
                CardYear.Foreground = System.Windows.Media.Brushes.Gray;
            }
        }

        private void TextBox_GotFocus_4(object sender, RoutedEventArgs e)
        {
            if (CVCTxt.Text == "123" && CVCTxt.Foreground != System.Windows.Media.Brushes.Black)
            {
                CVCTxt.Text = "";
                CVCTxt.Foreground = System.Windows.Media.Brushes.Black;
            }
        }

        private void TextBox_LostFocus_4(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CVCTxt.Text))
            {
                CVCTxt.Text = "123";
                CVCTxt.Foreground = System.Windows.Media.Brushes.Gray;
            }
        }

        private void TextBox_GotFocus_1(object sender, RoutedEventArgs e)
        {
            if (CardNumTxt.Text == "1234 1234 1234 1234")
            {
                CardNumTxt.Text = "";
                CardNumTxt.Foreground = System.Windows.Media.Brushes.Black;
            }
        }

        private void TextBox_LostFocus_1(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(CardNumTxt.Text))
            {
                CardNumTxt.Text = "1234 1234 1234 1234";
                CardNumTxt.Foreground = System.Windows.Media.Brushes.Gray;
            }
        }
    }
}
