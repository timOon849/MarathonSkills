using MarathonSkills.DataBase;
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

namespace MarathonSkills.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {

        public User user;
        public AuthorizationPage()
        {
            InitializeComponent();
        }
        
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string login = EmailTxt.Text;
            string password = PassTxt.Password;

            var loginObj = ConnectionString.connection.User.FirstOrDefault(log => log.Email == login && log.Password == password);

            if (loginObj == null)
            {
                MessageBox.Show("Пользователь не найден");
                return;
            }
            else if (loginObj != null)
            {
                if (loginObj.RoleId == "R")
                {
                    NavigationService.Navigate(new RunnerMenu());
                }
                else if (loginObj.RoleId == "A")
                {
                    NavigationService.Navigate(new AdminMenu());
                }
                else if(loginObj.RoleId == "C")
                {
                    NavigationService.Navigate(new CoordinatorMenu());
                }
            }
            EmailTxt.Text = "";
            PassTxt.Password = "";
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new HomePage());
        }

        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new HomePage());
        }

        private void EmailTxt_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox emailText = sender as TextBox;
            if (emailText != null && emailText.Text == "Enter your email address")
            {
                emailText.Text = "";
                emailText.FontStyle = default;
                emailText.Foreground = System.Windows.Media.Brushes.Black;
            }
        }

        private void EmailTxt_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox emailText = sender as TextBox;
            if (emailText != null && string.IsNullOrWhiteSpace(emailText.Text))
            {
                emailText.Text = "Enter your email address";
                emailText.FontStyle = default;
                emailText.Foreground = System.Windows.Media.Brushes.Gray;
            }
        }

        private void PassTxt_GotFocus(object sender, RoutedEventArgs e)
        {
            PasEnterLabel.Visibility = Visibility.Hidden;
        }

        private void PassTxt_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PassTxt.Password))
            {
                PasEnterLabel.Visibility = Visibility.Visible;
            }
        }
    }
}
