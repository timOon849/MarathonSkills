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
    /// Логика взаимодействия для ToKnewMoreAboutEvent.xaml
    /// </summary>
    public partial class ToKnewMoreAboutEvent : Page
    {
        public ToKnewMoreAboutEvent()
        {
            InitializeComponent();
        }
        
        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void MarathonSkillsButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void HowLongButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LastResultsButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BMIButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BMRButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OrgListButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new OrgList());
        }
    }
}
