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
            // inserir
            Produtos art = new Produtos();
            if(art.registro_existe_produto(textBox1.Text, textBox2.Text) == true)
            {
                MessageBox.Show("Produto já existe");
            }
            else
            {
                art.inserir_produto(textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text.Replace(',', '.'), textBox7.Text.Replace(',', '.'), textBox8.Text);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                MessageBox.Show("Cadastrado com sucesso!");
                List<Produtos> li = art.lista_produto();
                dgv1.DataSource = li;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {   
            // excluir
            if(textBox1.Text == "")
            {
                MessageBox.Show("Selecione um id!");
            }
            else
            {
                Produtos art = new Produtos();
                int Id = Convert.ToInt32(textBox1.Text.Trim());
                art.exclui_produto(Id);
                MessageBox.Show("Deletado com sucesso!");
                List<Produtos> li = art.lista_produto();
                dgv1.DataSource = li;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // localiza
            int Id = Convert.ToInt32(textBox1.Text.Trim());
            Produtos art = new Produtos();
            art.localiza_produto(Id);
            if(art.nome_produto == null && art.tipo_produto == null)
            {
                MessageBox.Show("Id invalido!");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
            }
            else
            {
                textBox1.Text = art.Idproduto.ToString();
                textBox2.Text = art.nome_produto;
                textBox3.Text = art.tipo_produto;
                textBox4.Text = art.status;
                textBox5.Text = art.plataforma;
                textBox6.Text = art.preco_venda.ToString();
                textBox7.Text = art.preco_locacao.ToString();
                textBox8.Text = art.estoque_produto.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // atualiza
            if(textBox1.Text != null)
            {
                Produtos prod = new Produtos();
                int estoque, Id;
                decimal precov, precol;
                Id = Convert.ToInt32(textBox1.Text.Trim());
                precov = Convert.ToDecimal(textBox6.Text.Replace(",","."));
                precol = Convert.ToDecimal(textBox7.Text.Replace(",", "."));
                estoque = Convert.ToInt32(textBox8.Text.Trim());

                prod.atualiza_produto(Id, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, precov, precol, estoque);
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
