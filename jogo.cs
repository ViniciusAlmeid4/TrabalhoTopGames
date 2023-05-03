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
    class Jogos
    {

        public int Idjogo { get; set; }
        public string nome_jogo { get; set; }
        public string genero { get; set; }
        public string plataforma { get; set; }
        public decimal preco_venda { get; set; }
        public decimal preco_locacao { get; set; }
        public int estoque_jogo { get; set; }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\usuario\\Documents\\TrabalhosSenai\\TrabalhoTopGames\\DbTopG.mdf;Integrated Security=True");

        public List<Jogos> lista_jogo()
        {
            List<Jogos> list_j = new List<Jogos>();

            string sql = "Select * From jogos";

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
                Jogos jogo = new Jogos();

                jogo.Idjogo = (int)dr["Idjogo"];
                jogo.nome_jogo = dr["nome_jogo"].ToString();
                jogo.genero = dr["genero"].ToString();
                jogo.plataforma = dr["plataforma"].ToString();
                jogo.preco_venda = (decimal)dr["preco_venda"];
                jogo.preco_locacao = (decimal)dr["preco_locacao"];
                jogo.estoque_jogo = (int)dr["estoque_jogo"];

                jogo.preco_venda = Math.Round(jogo.preco_venda, 2);
                jogo.preco_locacao = Math.Round(jogo.preco_locacao, 2);

                list_j.Add(jogo);

            }
            con.Close();

            return list_j;

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

    }
}
