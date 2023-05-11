﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Windows.Forms;

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

        public void inserir_artigo(string nome_artigo, string marca, decimal preco_artigo, int estoque_artigo)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            string sql = "Insert Into artigos Values ('" + nome_artigo + "','" + marca + "'," + preco_artigo + "," + estoque_artigo + ")";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public bool registro_existe_art(string nome_artigo, string marca)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            string sql = "Select * From artigos where nome_artigo = '" + nome_artigo + "' and marca = '" + marca + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql ,con);
            cmd.ExecuteNonQuery();
            var result = cmd.ExecuteScalar();
            if (result != null)
            {
                return true;
            }
            return false;
        }

        public void atualiza_artigo(int Idartigo, string nome_artigo, string marca, decimal preco_artigo, int estoque_artigo)
        {
            string sql = "Update artigos Set nome_artigo = '" + nome_artigo + "', marca = '" + marca + "', preco_artigo = " + preco_artigo + ", estoque_artigo = '" + estoque_artigo + "' Where Idartigo = '" + Idartigo + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void localiza_artigo(int Idartigo)
        {
            string sql = "Select * From artigos where Idartigo = '" + Idartigo + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                nome_artigo = reader["nome_artigo"].ToString();
                marca = reader["marca"].ToString();
                preco_artigo = Math.Round((decimal)reader["preco_artigo"], 2);
                estoque_artigo = (int)reader["estoque_artigo"];
            }
            con.Close();
        }

        public void exclui_artigo(int Idartigo)
        {
            string sql = "Delete From artigos where Idartigo = '" + Idartigo + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}