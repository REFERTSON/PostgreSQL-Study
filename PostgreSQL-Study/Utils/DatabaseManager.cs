using Npgsql;
using System;
using System.Windows;

namespace PostgreSQL_Study.Utils
{
    public class DatabaseManager
    {
        private NpgsqlConnection? sqlConnection { get; set; }

        public DatabaseManager() { }

        public void CreateConnection(string connectionString)
        {
            try
            {
                sqlConnection = new NpgsqlConnection(connectionString);

                OpenConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Подключение не создано или не может быть создано.\n{e.Message.Normalize()}", "Подключение к базе данных", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
        public void OpenConnection()
        {
            try
            {
                if (sqlConnection?.State == System.Data.ConnectionState.Closed) sqlConnection.Open();
            }

            catch (Exception e)
            {
                MessageBox.Show($"Не удалось открыть соединение к базе данных!\n{e.Message}", "Соединение базы данных", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
        public void CloseConnection()
        {
            try
            {
                if (sqlConnection?.State == System.Data.ConnectionState.Open) sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Не удалось закрыть соединение к базе данных!\n{e.Message}", "Соединение базы данных", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        public bool CheckSqlConnection()
        {
            if (sqlConnection == null || sqlConnection.State != System.Data.ConnectionState.Open) return false;
            else return true;
        }
        public NpgsqlConnection? GetSqlConnection() { return sqlConnection; }
    }
}
