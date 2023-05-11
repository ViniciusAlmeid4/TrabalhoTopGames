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

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Aluno\\source\\repos\\ViniciusAlmeid4\\TrabalhoTopGames\\DBT.mdf;Integrated Security=True");

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

                prod.preco_venda = Math.Round(jogo.preco_venda, 2);
                prod.preco_locacao = Math.Round(jogo.preco_locacao, 2);

                list_p.Add(prod);

            }
            con.Close();

            return list_p;

        }

        public void inserir_jogo(string nome_jogo, string genero, string plataforma, decimal preco_venda, decimal preco_locacao, int estoque_jogo)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            string sql = "Insert Into cliente Values ('" + nome_jogo + "','" + genero + "','" + plataforma + "'," + preco_venda + ", " + preco_locacao + " , " + estoque_jogo + ")";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
        }

        public bool registro_existe_jogo(string nome_jogo, string plataforma)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            string sql = "Select * From jogos where cpf = '" + nome_jogo + "' and plataforma = '"+ plataforma + "'";
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

        public void atualiza_jogo(int Idjogo, string nome_jogo, string genero, string plataforma, decimal preco_venda, decimal preco_locacao, int estoque_jogo)
        {
            string sql = "Update jogos Set nome_jogo = '" + nome_jogo + "', genero = '" + genero + "', plataforma = '" + plataforma + "', preco_venda = '" + preco_venda + "', preco_locacao = '" + preco_locacao + "', estoque_jogo = '" + estoque_jogo + "' where Idjogo = '" + Idjogo + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void localiza_jogo(int Idjogo)
        {
            string sql = "Select * From jogo where Idjogo = '" + Idjogo + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                nome_jogo = reader["nome_jogo"].ToString();
                genero = reader["genero"].ToString();
                plataforma = reader["plataforma"].ToString();
                preco_venda = Math.Round((decimal)reader["preco_venda"], 2);
                preco_locacao = Math.Round((decimal)reader["preco_locacao"], 2);
                estoque_jogo = (int)reader["estoque_jogo"];
            }
            con.Close();
        }

        public void exclui_jogo(int Idjogo)
        {
            string sql = "Delete From jogos where Idjogo = '" + Idjogo + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
