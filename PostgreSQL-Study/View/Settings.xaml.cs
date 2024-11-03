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

namespace PostgreSQL_Study.View
{
    /// <summary>
    /// Логика взаимодействия для Settings.xaml
    /// </summary>
    public partial class Settings : Page
    {
        public Settings()
        {
            InitializeComponent();

            if (!string.IsNullOrEmpty(((MainWindow)Application.Current.MainWindow).ServerName))
                ServerName.Text = ((MainWindow)Application.Current.MainWindow).ServerName;

            if (!string.IsNullOrEmpty(((MainWindow)Application.Current.MainWindow).ServerPort))
                ServerPort.Text = ((MainWindow)Application.Current.MainWindow).ServerPort;

            if (!string.IsNullOrEmpty(((MainWindow)Application.Current.MainWindow).DatabaseName))
                DatabaseName.Text = ((MainWindow)Application.Current.MainWindow).DatabaseName;

            if (!string.IsNullOrEmpty(((MainWindow)Application.Current.MainWindow).UserName))
                UserName.Text = ((MainWindow)Application.Current.MainWindow).UserName;

            if (!string.IsNullOrEmpty(((MainWindow)Application.Current.MainWindow).UserPassword))
                UserPassword.Text = ((MainWindow)Application.Current.MainWindow).UserPassword;
        }

        private void SaveSettingButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(ServerName.Text))
                ((MainWindow)Application.Current.MainWindow).ServerName = ServerName.Text;

            if (!string.IsNullOrEmpty(ServerPort.Text))
                ((MainWindow)Application.Current.MainWindow).ServerPort = ServerPort.Text;

            if (!string.IsNullOrEmpty(DatabaseName.Text))
                ((MainWindow)Application.Current.MainWindow).DatabaseName = DatabaseName.Text;

            if (!string.IsNullOrEmpty(UserName.Text))
                ((MainWindow)Application.Current.MainWindow).UserName = UserName.Text;

            if (!string.IsNullOrEmpty(UserPassword.Text))
                ((MainWindow)Application.Current.MainWindow).UserPassword = UserPassword.Text;
        }

        private void ResetSettingButton_Click(object sender, RoutedEventArgs e)
        {
            ServerName.Text = "localhost";
            ServerPort.Text = "5432";
            DatabaseName.Text = "";
            UserName.Text = "";
            UserPassword.Text = "";

        }
    }
}
