using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Forms_Demo
{
    class Database
    {
        public string connectionString { get; set; }

        public Database()
        {
            this.connectionString = @"Data Source=(local)\MSSQLSERVER01;Initial Catalog=WinFormsDemo;Integrated Security=True";
        }

        public DataTable pesquisaCliente(string tipoFiltro, string valor)
        {
            SqlConnection connection = new SqlConnection(this.connectionString);
            string commandString;

            switch (tipoFiltro)
            {
                case "CPF":
                    commandString = $"SELECT id, codigo, cpf, rg, nome, nomeAbreviado, email, telefone, inclusao, alteracao FROM ClientePessoaFisica WHERE bloqueado = 0 AND cpf = '{valor}'";
                    break;
                case "CNPJ":
                    commandString = $"SELECT id, codigo, cnpj, ie, razaoSocial, nomeFantasia, email, telefone, inclusao, alteracao FROM ClientePessoaJuridica WHERE bloqueado = 0 AND cnpj = '{valor}'";
                    break;
                case "Nome":
                    commandString = $"SELECT id, codigo, cpf, rg, nome, nomeAbreviado, email, telefone, inclusao, alteracao FROM ClientePessoaFisica WHERE bloqueado = 0 AND nome = '{valor}'";
                    break;
                case "Razão Social":
                    commandString = $"SELECT id, codigo, cnpj, ie, razaoSocial, nomeFantasia, email, telefone, inclusao, alteracao FROM ClientePessoaJuridica WHERE bloqueado = 0 AND razaoSocial = '{valor}'";
                    break;
                default:
                    commandString = $"SELECT id, codigo, cpf, rg, nome, nomeAbreviado, email, telefone, inclusao, alteracao FROM ClientePessoaFisica WHERE bloqueado = 0";
                    break;
            }

            SqlCommand command = new SqlCommand(commandString, connection);

            try
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();

                adapter.SelectCommand = command;
                adapter.Fill(table);

                connection.Close();

                return table;
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception.Message);
                return new DataTable();
            }
        }

        public void cadastraClientePessoaFisica(
            string codigo, string cpf, string rg, string nomeComp, string nomeAbv, string email, string telefone)
        {
            SqlConnection connection = new SqlConnection(this.connectionString);

            string commandString =
                "INSERT INTO ClientePessoaFisica " +
                $"VALUES ('{codigo}', '{cpf}', '{rg}', '{nomeComp}', '{nomeAbv}', '{email}', '{telefone}', GETDATE(), GETDATE(), 0, {getIdEndereco()});";

            SqlCommand command = new SqlCommand(commandString, connection);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception.Message);
            }
        }

        public void editaClientePessoaFisica(
            int id, string codigo, string cpf, string rg, string nomeComp, string nomeAbv, string email, string telefone)
        {
            SqlConnection connection = new SqlConnection(this.connectionString);

            string commandString =
                "UPDATE ClientePessoaFisica " +
                $"SET codigo = '{codigo}', cpf = '{cpf}', rg = '{rg}', nome = '{nomeComp}', nomeAbreviado = '{nomeAbv}', email = '{email}', telefone = '{telefone}', alteracao = GETDATE()" +
                $"WHERE id = {id};";

            SqlCommand command = new SqlCommand(commandString, connection);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception.Message);
            }
        }

        public void cadastraClientePessoaJuridica(
            string codigo, string cnpj, string ie, string razSocial, string nomeFant, string email, string telefone)
        {
            SqlConnection connection = new SqlConnection(this.connectionString);

            string commandString =
                "INSERT INTO ClientePessoaJuridica " +
                $"VALUES ('{codigo}', '{cnpj}', '{ie}', '{razSocial}', '{nomeFant}', '{email}', '{telefone}', GETDATE(), GETDATE(), 0, {getIdEndereco()});";

            SqlCommand command = new SqlCommand(commandString, connection);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception.Message);
            }
        }

        public void editaClientePessoaJuridica(
            int id, string codigo, string cnpj, string ie, string razSoc, string nomeFan, string email, string telefone)
        {
            SqlConnection connection = new SqlConnection(this.connectionString);

            string commandString =
                "UPDATE ClientePessoaJuridica " +
                $"SET codigo = '{codigo}', cnpj = '{cnpj}', ie = '{ie}', razaoSocial = '{razSoc}', nomeFantasia = '{nomeFan}', email = '{email}', telefone = '{telefone}', alteracao = GETDATE()" +
                $"WHERE id = {id};";

            SqlCommand command = new SqlCommand(commandString, connection);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception.Message);
            }
        }

        public void cadastraEndereco(
            string cep, string logradouro, string numero, string complemento, string bairro, string municipio, string uf)
        {
            SqlConnection connection = new SqlConnection(this.connectionString);

            string commandString =
                "INSERT INTO Endereco " +
                $"VALUES ('{cep}', '{logradouro}', '{numero}', '{complemento}', '{bairro}', '{municipio}', '{uf}');";

            SqlCommand command = new SqlCommand(commandString, connection);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception.Message);
            }
        }

        public void removeCliente(string tipo, int id)
        {
            SqlConnection connection = new SqlConnection(this.connectionString);

            string tabela;

            switch (tipo)
            {
                case "CPF":
                    tabela = "ClientePessoaFisica";
                    break;
                case "CNPJ":
                    tabela = "ClientePessoaJuridica";
                    break;
                default:
                    tabela = "ClientePessoaFisica";
                    break;
            }

            string commandString =
                $"UPDATE {tabela} " +
                "SET bloqueado = 1, alteracao = GETDATE()" +
                $"WHERE id = {id};";

            SqlCommand command = new SqlCommand(commandString, connection);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception.Message);
            }
        }

        private int getIdEndereco()
        {
            SqlConnection connection = new SqlConnection(this.connectionString);
            string commandString = "SELECT MAX(id) FROM Endereco";

            SqlCommand command = new SqlCommand(commandString, connection);

            try
            {
                connection.Open();
                int id = (int)(command.ExecuteScalar());
                connection.Close();

                return id;
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception.Message);
                return 0;
            }
        }

        public bool contemDuplicata(string tipo, string valor)
        {
            SqlConnection connection = new SqlConnection(this.connectionString);

            string pessoa;
            if (tipo == "cpf")
                pessoa = "ClientePessoaFisica";
            else
                pessoa = "ClientePessoaJuridica";

            string commandString = $"SELECT COUNT({tipo}) FROM {pessoa} WHERE {tipo} = '{valor}';";

            SqlCommand command = new SqlCommand(commandString, connection);

            try
            {
                connection.Open();

                if ((int)(command.ExecuteScalar()) > 0)
                {
                    connection.Close();
                    return true;
                }

                connection.Close();
                return false;
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception.Message);
                return true;
            }
        }
    }
}
