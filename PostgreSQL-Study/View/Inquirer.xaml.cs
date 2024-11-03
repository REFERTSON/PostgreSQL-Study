using Microsoft.Win32;
using MiniExcelLibs;
using PostgreSQL_Study.Utils;
using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace PostgreSQL_Study.View
{
    /// <summary>
    /// Логика взаимодействия для Inquirer.xaml
    /// </summary>
    public partial class Inquirer : Page
    {
        public string openFilePath { get; set; } = "";
        private bool isFileCreated { get; set; } = false;

        // Регулярное выражение для поиска ключевых слов SQL
        string pattern = @"(INSERT|UPDATE|DELETE|DROP)\b";

        private TableManager _tableManager { get; set; }
        private DatabaseManager _databaseManager { get; set; }
        private DataTable _table { get; set; }
        private SaveFileDialog dialog { get; set; }

        public Inquirer(string file = "")
        {
            InitializeComponent();

            OpenFile(file);
            _tableManager = new TableManager();
            _databaseManager = new DatabaseManager();
            dialog = new SaveFileDialog();
            _table = new DataTable();
        }

        public void OpenFile(string file)
        {
            if (!string.IsNullOrEmpty(file))
            {
                if (File.Exists(file))
                    QueryTextBox.Text = File.ReadAllText(file);

                openFilePath = file;
                isFileCreated = true;
            }
            else
            {
                openFilePath = "Untitled";
            }

            FileName.Text = Path.GetFileName(openFilePath);
        }

        public void SaveFile()
        {
            if (!isFileCreated) 
            {
                dialog.FileName = openFilePath;
                dialog.DefaultExt = ".sql";
                dialog.Filter = "SQL-файлы (.sql)|*.sql|Все файлы |*.*|Текстовые файлы (.txt)|*.txt";

                if (dialog.ShowDialog() == true)
                    openFilePath = dialog.FileName;
            }

            File.WriteAllText(openFilePath, QueryTextBox.Text);
            FileName.Text = Path.GetFileName(openFilePath);
        }

        private void RunQueryButton_Click(object sender, RoutedEventArgs e)
        {
            InquirerItemTable.ItemsSource = null;
            MessageResult.Text = "";
            TabResult.SelectedIndex = 0;

            Match match = Regex.Match(QueryTextBox.Text, pattern, RegexOptions.IgnoreCase);

            if (!match.Success) 
            {
                try
                {
                    _databaseManager.CreateConnection(((MainWindow)Application.Current.MainWindow).ConnectionString);
                    _tableManager.RunSqlQuery(_databaseManager.GetSqlConnection(), QueryTextBox.Text, _table);
                    _tableManager.FillDataGridView(InquirerItemTable, _table);
                }
                catch (Exception ex)
                {
                    TabResult.SelectedIndex = 1;
                    MessageResult.Text = ex.Message;
                }
            }
            else
            {
                TabResult.SelectedIndex = 1;
                MessageResult.Text = "Запрещено использовать INSERT, UPDATE, DELETE и DROP в SQL-запросе!!!";
            }
        }

        private void ClearQueryButton_Click(object sender, RoutedEventArgs e)
        {
            QueryTextBox.Text = "";
            InquirerItemTable.ItemsSource = null;
            TabResult.SelectedIndex = 0;
            MessageResult.Text = "";
        }

        private void ExportResultButton_Click(object sender, RoutedEventArgs e)
        {
            dialog.FileName = "Отчет";
            dialog.DefaultExt = ".xlsx";
            dialog.Filter = "Книга Excel (.xlsx)|*.xlsx";

            if (dialog.ShowDialog() == true && InquirerItemTable.ItemsSource != null)
            {
                try
                {
                    MiniExcel.SaveAs(dialog.FileName, ((DataView)InquirerItemTable.ItemsSource).ToTable(), overwriteFile: true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не удалось экспортировать таблицу в Excel! Текст ошибки: {ex.Message}", "Ошибка экспорта в Excel", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

            else
            {
                MessageBox.Show("Не удалось экспортировать таблицу в Excel!", "Ошибка экспорта в Excel", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void QueryTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            isFileCreated = false;
        }
    }
}
