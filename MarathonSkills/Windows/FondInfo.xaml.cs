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
using MarathonSkills.DataBase;
using System.Reflection;

namespace MarathonSkills.Windows
{
    /// <summary>
    /// Логика взаимодействия для FondInfo.xaml
    /// </summary>
    public partial class FondInfo : Window
    {
        Charity _fund;
        public FondInfo(Charity fund)
        {
            InitializeComponent();
            _fund = fund;
            FundNameTxt.Text = _fund.CharityName;
            string executablePath = Assembly.GetExecutingAssembly().Location;
            FundInfoTxt.Text = executablePath;
            string resourcePath = $"MarathonSkills;component/Materials/{_fund.CharityLogo}"; // Путь к ресурсу
            BitmapImage logoImage = new BitmapImage(new Uri($"pack://application:,,,/{resourcePath}", UriKind.Absolute));
            LogoEllipse.Fill = new ImageBrush(logoImage);
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
