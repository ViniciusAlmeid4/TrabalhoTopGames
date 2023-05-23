using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace TrabalhoTopGames
{
    class Cliente
    {

        public int Idcliente { get; set; }
        public string nome_cliente { get; set; }
        public string cep { get; set; }
        public string cpf { get; set; }
        public string email { get; set; }
        public string celular { get; set; }
        public string cidade { get; set; }
        public string endereco { get; set; }
        public string complemento { get; set; }


        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Aluno\\Source\\Repos\\ViniciusAlmeid4\\TrabalhoTopGames\\Db1.mdf;Integrated Security=True");

        public List<Cliente> lista_cliente()
        {
            List<Cliente> list_cli = new List<Cliente>();

            string sql = "Select * From cliente";

            // verificação de conexão, garante que não aconteçam conflitos entre conexões.

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Cliente clientes = new Cliente();

                clientes.Idcliente = (int)dr["Idcliente"];
                clientes.nome_cliente = dr["nome_cliente"].ToString();
                clientes.cep = dr["cep"].ToString();
                clientes.cpf = dr["cpf"].ToString();
                clientes.email = dr["email"].ToString();
                clientes.celular = dr["celular"].ToString();
                clientes.cidade = dr["celular"].ToString();
                clientes.endereco = dr["endereco"].ToString();
                clientes.complemento = dr["complemento"].ToString();

                list_cli.Add(clientes);

            }
            con.Close();

            return list_cli;

        }

        public void inserir_cliente(string nome_cliente, string cep, string cpf, string email, string celular, string cidade, string endereco, string complemento)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

            con.Open();
            string sql = "Insert Into cliente Values ('" + nome_cliente + "','" + cep + "','" + cpf + "','" + email + "', '"+ celular + "', '"+cidade+"', '"+endereco+"','"+complemento+"')";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
        }

        public bool registro_existe_cli(string cpf)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

            string sql = "Select * From cliente where cpf = '" + cpf + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            var result = cmd.ExecuteScalar();
            if (result != null)
            {
                return true;
            }
            return false;
        }

        public void atualiza_cliente(int Idcliente, string nome_cliente, string cep, string cpf, string email, string celular, string cidade, string endereco, string complemento)
        {
            string sql = "Update cliente Set nome_cliente = '" + nome_cliente + "', cep = '" + cep + "', cpf = '" + cpf + "', email = '" + email + "', celular = '" + celular + "', cidade = '"+cidade+"', endereco = '"+endereco+"', complemento = '"+complemento+"' where Idcliente = '"+Idcliente+"'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void localiza_cliente(int Idcliente)
        {
            string sql = "Select * From cliente where Idcliente = '"+Idcliente+"'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                nome_cliente = reader["nome_cliente"].ToString();
                cep = reader["cep"].ToString();
                cpf = reader["cpf"].ToString();
                email = reader["email"].ToString();
                celular = reader["celular"].ToString();
                cidade = reader["cidade"].ToString();
                endereco = reader["endereco"].ToString();
                complemento = reader["complemento"].ToString();
            }
            con.Close();
        }

        public void exclui_cliente(int Idcliente)
        {
            string sql = "Delete From cliente where Idcliente = '" + Idcliente + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}

