using Npgsql;
using System.Data;
using System.Windows.Controls;

namespace PostgreSQL_Study.Utils
{
    public class TableManager
    {
        public void RunSqlQuery(NpgsqlConnection? connection, string query, DataTable table)
        {
            if (connection == null) return;
            if (connection.State != ConnectionState.Open) return;

            NpgsqlCommand command = new NpgsqlCommand(query, connection);

            NpgsqlDataReader Reader = command.ExecuteReader();

            if (!Reader.HasRows) return;

            table.Clear();
            table.Load(Reader);

            return;
        }

        public void FillDataGridView(DataGrid view, DataTable table)
        {
            // Очистка существующих данных
            view.ItemsSource = null;
            view.Items.Clear();

            if (table != null)
            {
                // Установка источника данных
                view.ItemsSource = table.DefaultView;
            }
        }
    }
}
