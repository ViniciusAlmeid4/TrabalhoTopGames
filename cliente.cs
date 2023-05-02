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

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\usuario\\Documents\\TrabalhosSenai\\TrabalhoTopGames\\DbTopG.mdf;Integrated Security=True");

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

                list_cli.Add(clientes);

            }
            con.Close();

            return list_cli;

        }

    }
}

