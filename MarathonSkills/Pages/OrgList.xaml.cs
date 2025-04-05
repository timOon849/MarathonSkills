using MarathonSkills.DataBase;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using MarathonSkills.DataBase;
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
    /// Логика взаимодействия для OrgList.xaml
    /// </summary>
    public partial class OrgList : Page
    {
        public OrgList()
        {
            InitializeComponent();
            LvCharity.ItemsSource = ConnectionString.connection.Charity.ToList();
        }

        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
        public void LoadPhoto()
        {
            
        }
    }
}
