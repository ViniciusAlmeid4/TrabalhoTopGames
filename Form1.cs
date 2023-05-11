using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoTopGames
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Artigo j = new Artigo();
            List<Artigo> li = j.lista_artigo();
            dgv1.DataSource = li;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Artigo art = new Artigo();
            if(art.registro_existe_art(textBox1.Text, textBox2.Text) == true)
            {
                MessageBox.Show("Artigo já existe");
            }
            else
            {
                int estoque;
                decimal preco;
                preco = Convert.ToDecimal(textBox3.Text.Trim());
                estoque = Convert.ToInt32(textBox4.Text.Trim());
                art.inserir_artigo(textBox1.Text, textBox2.Text, preco, estoque);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                MessageBox.Show("Cadastrado com sucesso!");
                List<Artigo> li = art.lista_artigo();
                dgv1.DataSource = li;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(textBox5.Text == "")
            {
                MessageBox.Show("Selecione um id!");
            }
            else
            {            
                Artigo art = new Artigo();
                int Id = Convert.ToInt32(textBox5.Text.Trim());
                art.exclui_artigo(Id);
                MessageBox.Show("Deletado com sucesso!");
                List<Artigo> li = art.lista_artigo();
                dgv1.DataSource = li;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(textBox5.Text.Trim());
            Artigo art = new Artigo();
            art.localiza_artigo(Id);
            if(art.nome_artigo == null && art.marca == null)
            {
                MessageBox.Show("Id invalido!");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
            else
            {
            textBox1.Text = art.nome_artigo;
            textBox2.Text = art.marca;
            textBox3.Text = Convert.ToString(art.preco_artigo).Replace(",", ".");
            textBox4.Text = Convert.ToString(art.estoque_artigo);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox5.Text != null)
            {

                // SA PORRA DE DECIMAL TÁ DANDO ERRADO

                Artigo art = new Artigo();
                int estoque, Id;
                decimal preco;
                Id = Convert.ToInt32(textBox5.Text.Trim());
                preco = Convert.ToDecimal(textBox3.Text.Trim().Replace(",","."));
                estoque = Convert.ToInt32(textBox4.Text.Trim());

                art.atualiza_artigo(Id, textBox1.Text, textBox2.Text, preco, estoque);
                MessageBox.Show("Atualizado com sucesso!!", textBox3.Text);
                List<Artigo> li = art.lista_artigo();
                dgv1.DataSource = li;
            }
            else
            {
                MessageBox.Show("Id inválido!");
            }

        }
    }
}
