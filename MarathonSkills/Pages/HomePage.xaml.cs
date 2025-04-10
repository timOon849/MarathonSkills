﻿using System;
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
    /// Логика взаимодействия для HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
        }
        
        private void RunnerButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ToBeRunner());
        }

        private void SponsorButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RunnerSponsor());
        }

        private void MoreInfoButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ToKnewMoreAboutEvent());
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthorizationPage());
        }
    }
}
