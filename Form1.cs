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
            Produtos j = new Produtos();
            List<Produtos> li = j.lista_produto();
            dgv1.DataSource = li;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Produtos art = new Produtos();
            if(art.registro_existe_produto(textBox1.Text, textBox2.Text) == true)
            {
                MessageBox.Show("Produto já existe");
            }
            else
            {
                int estoque;
                decimal preco;
                preco = Convert.ToDecimal(##.Trim());
                estoque = Convert.ToInt32(##.Trim());
                art.inserir_produto(textBox1.Text, textBox2.Text, preco, estoque);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                MessageBox.Show("Cadastrado com sucesso!");
                List<Produtos> li = art.lista_produto();
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
                Produtos art = new Produtos();
                int Id = Convert.ToInt32(##.Trim());
                art.exclui_produto(Id);
                MessageBox.Show("Deletado com sucesso!");
                List<Produtos> li = art.lista_produto();
                dgv1.DataSource = li;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(textBox5.Text.Trim());
            Produtos art = new Produtos();
            art.localiza_produto(Id);
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

                Produtos prod = new Produtos();
                int estoque, Id;
                decimal preco_venda, preco_locacao;
                Id = Convert.ToInt32(##.Trim());
                preco_venda = Convert.ToDecimal(##.Trim().Replace(",","."));
                preco_locacao = Convert.ToDecimal(##.Trim().Replace(",", "."));
                estoque = Convert.ToInt32(##.Text.Trim());

                prod.atualiza_produto(Id, textBox1.Text, textBox2.Text, preco, estoque);
                MessageBox.Show("Atualizado com sucesso!!");
                List<Produtos> li = prod.lista_produto();
                dgv1.DataSource = li;
            }
            else
            {
                MessageBox.Show("Id inválido!");
            }

        }

    }
}
