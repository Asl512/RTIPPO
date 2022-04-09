using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace RTIPPO
{
    class DataBase
    {
        public DataTable data =  new DataTable();

        public DataBase(string request)
        {
            NpgsqlConnection connector = new NpgsqlConnection("Server=localhost;Port=5432;Database=rtippo;User Id=postgres;Password=1122;");
            connector.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connector;
            command.CommandType = CommandType.Text;
            command.CommandText = request;

            NpgsqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                data = dataTable;
            }
            command.Dispose();
            connector.Close();
        }
    }
}
