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
    class Artigo
    {

        public int Idartigo { get; set; }
        public string nome_artigo { get; set; }
        public string marca { get; set; }
        public decimal preco_artigo { get; set; }
        public int estoque_artigo { get; set; }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\usuario\\Documents\\TrabalhosSenai\\TrabalhoTopGames\\DbTopG.mdf;Integrated Security=True");

        public List<Artigo> lista_artigo()
        {
            List<Artigo> list_art = new List<Artigo>();

            string sql = "Select * From artigos";

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
                Artigo artigos = new Artigo();

                artigos.Idartigo = (int)dr["Idartigo"];
                artigos.nome_artigo = dr["nome_artigo"].ToString();
                artigos.marca = dr["marca"].ToString();
                artigos.preco_artigo = (decimal)dr["preco_artigo"];
                artigos.estoque_artigo = (int)dr["estoque_artigo"];

                artigos.preco_artigo = Math.Round(artigos.preco_artigo, 2);

                list_art.Add(artigos);

            }
            con.Close();

            return list_art;

        }

    }
}
