using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace acesso_db {
    internal class controlerDBClient {
        MySqlConnection connection;
        MySqlDataReader reader;
        MySqlCommand command;
        MySqlDataAdapter adapter;
        string sql;

        private MySqlConnection DBConn() {
            connection = new MySqlConnection("Server=localhost;Database=dbcliente;Uid=root;Pwd=;");
            return connection;
        }

        public string InsertCliente(Cliente cliente) {
            string msg = "";

            try {
                connection = DBConn();

                sql = "INSERT INTO cliente(nome, numero) VALUES(@nome, @numero)";

                command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@nome", cliente.Nome);
                command.Parameters.AddWithValue("@numero", cliente.Numero);

                connection.Open();

                command.ExecuteNonQuery();

                msg = "Sucesso";
            } catch (Exception ex) {
                msg = ex.Message;
            } finally {
                connection.Close();
                connection = null;
                command = null;
            }

            return msg;
        }
    }
}
