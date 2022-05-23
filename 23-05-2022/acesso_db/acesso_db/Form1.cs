using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace acesso_db {
    public partial class Form1 : Form {

        MySqlConnection connection;
        MySqlDataReader reader;
        MySqlCommand command;
        MySqlDataAdapter adapter;
        string sql;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            gridShow();
        }

        private void btnInserir_Click(object sender, EventArgs e) {
            Cliente cliente = new Cliente();

            cliente.Nome = txtNome.Text;
            cliente.Numero = Convert.ToInt32(txtNumero.Text);

            MessageBox.Show(new controlerDBClient().InsertCliente(cliente));

            gridShow();
        }

        private void btnEditar_Click(object sender, EventArgs e) {
            try {
                connection = new MySqlConnection("Server=localhost;Database=dbcliente;Uid=root;Pwd=;");

                sql = "UPDATE cliente SET nome = @nome, numero = @numero WHERE id = @id";

                command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
                command.Parameters.AddWithValue("@nome", txtNome.Text);
                command.Parameters.AddWithValue("@numero", int.Parse(txtNumero.Text));

                connection.Open();
                command.ExecuteNonQuery();

                gridShow();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                connection.Close();
                connection = null;
                command = null;
            }
        }

        private void btnApagar_Click(object sender, EventArgs e) {
            try {
                connection = new MySqlConnection("Server=localhost;Database=dbcliente;Uid=root;Pwd=;");

                sql = "DELETE FROM cliente WHERE id = @id";

                command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", int.Parse(txtId.Text));

                connection.Open();
                command.ExecuteNonQuery();

                gridShow();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                connection.Close();
                connection = null;
                command = null;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e) {
            try {
                connection = new MySqlConnection("Server=localhost;Database=dbcliente;Uid=root;Pwd=;");

                sql = "SELECT * FROM cliente WHERE id = @id";

                command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", int.Parse(txtId.Text));

                connection.Open();
                reader = command.ExecuteReader();

                while (reader.Read()) {
                    txtNome.Text = Convert.ToString(reader["nome"]);
                    txtNumero.Text = Convert.ToString(reader["numero"]);
                }

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                connection.Close();
                connection = null;
                command = null;
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e) {
            gridShow();
        }

        private void gridShow() {
            try {
                connection = new MySqlConnection("Server=localhost;Database=dbcliente;Uid=root;Pwd=;");

                sql = "SELECT * FROM cliente";

                adapter = new MySqlDataAdapter(sql, connection);

                DataTable dt = new DataTable();

                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                connection.Close();
                connection = null;
                command = null;
            }
        }
    }
}
