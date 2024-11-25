using PostgreSQL_Study.Utils;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для DatabaseContent.xaml
    /// </summary>
    public partial class DatabaseContent : Page
    {
        private TableManager _tableManager { get; set; }
        private DatabaseManager _databaseManager { get; set; }
        private DataTable _table { get; set; }

        public DatabaseContent()
        {
            InitializeComponent();

            _tableManager = new TableManager();
            _databaseManager = new DatabaseManager();
            _table = new DataTable();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RunSqlQuery("SELECT * FROM public.\"Movies\"\r\nORDER BY \"ID_Movie\" ASC");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            RunSqlQuery("SELECT * FROM public.\"Showtimes\"\r\nORDER BY \"ID_Showtime\" ASC");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            RunSqlQuery("SELECT * FROM public.\"Halls\"\r\nORDER BY \"ID_Hall\" ASC");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            RunSqlQuery("SELECT * FROM public.\"Tickets\"\r\nORDER BY \"ID_Ticket\" ASC");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            RunSqlQuery("SELECT * FROM public.\"Customers\"\r\nORDER BY \"ID_Customer\" ASC");
        }

        private void RunSqlQuery(string query)
        {
            try
            {
                _table = new DataTable();
                _databaseManager.CreateConnection(((MainWindow)Application.Current.MainWindow).ConnectionString);
                _tableManager.RunSqlQuery(_databaseManager.GetSqlConnection(), query, _table);
                _tableManager.FillDataGridView(ItemsTable, _table);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось получить содержимое таблицы по причине: {ex.Message}", "Ошибка получения содержимого БД", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
