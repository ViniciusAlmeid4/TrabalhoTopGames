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
    class Produtos
    {

        public int Idproduto { get; set; }
        public string nome_produto { get; set; }
        public string tipo_produto { get; set; }
        public string status { get; set; }
        public string plataforma { get; set; }
        public decimal preco_venda { get; set; }
        public decimal preco_locacao { get; set; }
        public int estoque_produto { get; set; }

        SqlConnection con = new SqlConnection("C:\\Users\\usuario\\Documents\\TrabalhosSenai\\TrabalhoTopGames\\DBTop.mdf");

        public List<Produtos> lista_produto()
        {
            List<Produtos> list_p = new List<Produtos>();

            string sql = "Select * From produtos";

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
                Produtos prod = new Produtos();

                prod.Idproduto = (int)dr["Idproduto"];
                prod.nome_produto = dr["nome_produto"].ToString();
                prod.tipo_produto = dr["tipo_produto"].ToString();
                prod.status = dr["status"].ToString();
                prod.plataforma = dr["plataforma"].ToString();
                prod.preco_venda = (decimal)dr["preco_venda"];
                prod.preco_locacao = (decimal)dr["preco_locacao"];
                prod.estoque_produto = (int)dr["estoque_produto"];

                prod.preco_venda = Math.Round(prod.preco_venda, 2);
                prod.preco_locacao = Math.Round(prod.preco_locacao, 2);

                list_p.Add(prod);

            }
            con.Close();

            return list_p;

        }

        public void inserir_produto(string nome_produto, string tipo_produto, string status, string plataforma, decimal preco_venda, decimal preco_locacao, int estoque_jogo)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            string sql = "Insert Into produtos Values ('" + nome_produto + "','" + tipo_produto + "','" + status + "','"+plataforma+"'," + preco_venda + ", " + preco_locacao + " , " + estoque_jogo + ")";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
        }

        public bool registro_existe_produto(string nome_produto, string tipo_produto)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            string sql = "Select * From produtos where nome_produto = '" + nome_produto + "' and tipo_produto = '" + tipo_produto + "'";
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

        public void atualiza_produto(int Idproduto, string nome_produto, string tipo_produto, string status, string plataforma, decimal preco_venda, decimal preco_locacao, int estoque_jogo)
        {
            string sql = "Update produtos Set nome_produto = '" + nome_produto + "', tipo_produto = '" + tipo_produto + "', status = '"+ status + "', plataforma = '" + plataforma + "', preco_venda = '" + preco_venda + "', preco_locacao = '" + preco_locacao + "', estoque_jogo = '" + estoque_jogo + "' where Idproduto = '" + Idproduto + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void localiza_produto(int Idproduto)
        {
            string sql = "Select * From produtos where Idproduto = '" + Idproduto + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                nome_produto = reader["nome_produto"].ToString();
                tipo_produto = reader["tipo_produto"].ToString();
                status = reader["status"].ToString();
                plataforma = reader["plataforma"].ToString();
                preco_venda = Math.Round((decimal)reader["preco_venda"], 2);
                preco_locacao = Math.Round((decimal)reader["preco_locacao"], 2);
                estoque_produto = (int)reader["estoque_jogo"];
            }
            con.Close();
        }

        public void exclui_produto(int Idproduto)
        {
            string sql = "Delete From produtos where Idproduto = '" + Idproduto + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
