using MySql.Data.MySqlClient;
using System;
using System.Data;


namespace Kursach_2._0
{
    class FUNC
    {
        My_DB connection = new My_DB();

        public Boolean ExecQuery(MySqlCommand command)
        {
            command.Connection = connection.getConnection;

            connection.openConnection();

            if(command.ExecuteNonQuery() == 1)
            {
                connection.closeConnection();
                return true;
            }
            else
            {
                connection.closeConnection();
                return false;
            }
        }
        // Отримати дані
        public DataTable getData(MySqlCommand command)
        {
            command.Connection = connection.getConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
