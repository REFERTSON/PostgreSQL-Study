using Microsoft.Win32;
using PostgreSQL_Study.View;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace PostgreSQL_Study
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string ServerName { get; set; } = "localhost";
        public string ServerPort { get; set; } = "5432";
        public string DatabaseName { get; set; } = "";
        public string UserName { get; set; } = "";
        public string UserPassword { get; set; } = "";

        public string ConnectionString { get; set; }


        public MainWindow()
        {
            InitializeComponent();
            if (File.Exists("Settings.json")) 
            {
                var data = JsonSerializer.Deserialize<Dictionary<string, string>>(File.ReadAllText("Settings.json"));

                ServerName = data["ServerName"];
                ServerPort = data["ServerPort"];
                DatabaseName = data["DatabaseName"];
                UserName = data["UserName"];
                UserPassword = data["UserPassword"];
            }
            ConnectionString = $"Server={ServerName};Port={ServerPort};Database={DatabaseName}; User Id={UserName}; Password={UserPassword};";
        }

        private void Expander_Expanded(object sender, RoutedEventArgs e)
    {
            var openedExpander = sender as Expander;

            // Перебираем всех детей визуального дерева
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(openedExpander.Parent); i++)
            {
                var child = VisualTreeHelper.GetChild(openedExpander.Parent, i);

                // Проверяем, является ли элемент Expander'ом 
                if (child is Expander expander && expander != openedExpander)
                {
                    expander.IsExpanded = false;
                }
            }
        }

        private void AboutProgram_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AboutProgram());
        }

        private void Inquirer_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Inquirer());
        }

        private void DatabaseDiagramButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new DatabaseDiagram());
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Settings());
        }

        private void OpenFileButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;

            if (fileDialog.ShowDialog() == true)
            {
                MainFrame.Navigate(new Inquirer(fileDialog.FileName));
            }
        }

        private void SaveFileButton_Click(object sender, RoutedEventArgs e)
        {
            object currentPage = MainFrame.Content;

            if (currentPage is Inquirer)
            {
                ((Inquirer)currentPage).SaveFile();
            }
        }

        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {
            object currentPage = MainFrame.Content;

            if (currentPage is Inquirer)
            {
                ConnectionString = $"Server={ServerName};Port={ServerPort};Database={DatabaseName}; User Id={UserName}; Password={UserPassword};";

                Inquirer_Start.IsEnabled = true;
                Inquirer_Clear.IsEnabled = true;
                Inquirer_Export.IsEnabled = true;
                
                SaveFileButton.IsEnabled = true;
            }

            else
            {
                Inquirer_Start.IsEnabled = false;
                Inquirer_Clear.IsEnabled = false;
                Inquirer_Export.IsEnabled = false;

                SaveFileButton.IsEnabled = false;
            }
        }

        private void OpenHTMLDocument_Click(object sender, RoutedEventArgs e) 
        {
            if (sender is Button || sender is MenuItem)
            {
                object tag = (sender is Button) ? ((Button)sender).Tag : ((MenuItem)sender).Tag;

                if (tag != null)
                    MainFrame.Navigate(new CourseItemViewer($"{Directory.GetCurrentDirectory()}\\{tag.ToString()}"));
                    
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            var data = new Dictionary<string, string>()
            {
                { "ServerName", ServerName },
                { "ServerPort", ServerPort },
                { "DatabaseName", DatabaseName },
                { "UserName", UserName },
                { "UserPassword", UserPassword }
            };

            File.WriteAllText("Settings.json", JsonSerializer.Serialize(data));
        }

        private void MainFrame_Navigating(object sender, NavigatingCancelEventArgs e)
        {
            object currentPage = MainFrame.Content;

            if (currentPage is Inquirer)
            {
                var dialog = MessageBox.Show($"Желаете сохранить файл: {Path.GetFileName(((Inquirer)currentPage).openFilePath)}", "Сохранение файла", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);

                if (dialog == MessageBoxResult.Yes)
                {
                    ((Inquirer)currentPage).SaveFile();
                }
                else if (dialog == MessageBoxResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
