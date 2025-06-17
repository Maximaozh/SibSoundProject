using Microsoft.Data.Sqlite;
using SQLitePCL;

namespace Logger
{
    class Program
    {

        static void Main(string[] args)
        {
            string documentPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string dbFilePath = documentPath + "\\\\LogData.db";

            string Summar = string.Join(" ",args);
            args = Summar.Split('%');

            using (var connection = new SqliteConnection("Data Source="+ dbFilePath))
            {
                connection.Open();

                SqliteCommand command = new SqliteCommand();
                command.Connection = connection;
                command.CommandText = "INSERT INTO " +
                                            "WorkData (Date, Info, Params) " +
                                            "VALUES (@when, @what, @params);";

                var whenParam = new SqliteParameter("@when", args[0]);
                command.Parameters.Add(whenParam);

                var operationParam = new SqliteParameter("@what", args[1]);
                command.Parameters.Add(operationParam);

                var timeParam = new SqliteParameter("@params", args[2]);
                command.Parameters.Add(timeParam);

                command.ExecuteNonQuery();
            }
        }


    }
}