using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Xml.Serialization;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Linq;


namespace library_management_system.THE_DATABASE
{
    internal class MYDB
    {

        private MySqlConnection connection = new MySqlConnection("server=localhost; port=3310; username=root; password=;database=csharp_lms_db");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed) {
            connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }

        public DataTable getData(string query, MySqlParameter[] parameters)
        {
            MySqlCommand command = new MySqlCommand(query, connection);
            if(parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }

        public int setData(string query, MySqlParameter[] parameters)
        {
            MySqlCommand command = new MySqlCommand(query, connection);
            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            openConnection();

            int commandState = command.ExecuteNonQuery();

            closeConnection();

            return commandState;
        }
    }
}
