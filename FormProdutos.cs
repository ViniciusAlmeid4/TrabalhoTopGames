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
    public partial class FormProdutos : Form
    {
        public FormProdutos()
        {
            InitializeComponent();
        }

        public void Listar_produto()
        {
            Produtos produto = new Produtos();
            List<Produtos> prod = produto.lista_produto();
            dgvProdutos.DataSource = prod;
        }

        private void FormProdutos_Load(object sender, EventArgs e)
        {
            Produtos prod = new Produtos();
            List<Produtos> list_prod = prod.lista_produto();
            dgvProdutos.DataSource = list_prod;
            btnExcluir.Enabled = false;
            btnEditar.Enabled = false;
            this.txtNome.Focus();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Produtos prod = new Produtos();

            if (txtNome.Text == "" || txtTipo.Text == "" || txtStatus.Text == "" || txtPlataforma.Text == "" || txtPrev.Text == "" || txtEstoque.Text == "")
            {

                MessageBox.Show("Preencha as informações de forma correta!!");

            }
            else
            {
                if (txtPrel.Text == "")
                {
                    txtPrel.Text = "0.00";
                }

                if (prod.registro_existe_produto(txtNome.Text,txtTipo.Text) == true)
                {
                    MessageBox.Show("Produto " + txtNome.Text + " do tipo " + txtTipo.Text + " já existe!!");
                }
                else
                {

                    prod.inserir_produto(txtNome.Text, txtTipo.Text, txtStatus.Text, txtPlataforma.Text, txtPrev.Text, txtPrel.Text, txtEstoque.Text);
                
                }

                MessageBox.Show("Inserido com sucesso!!");

                Listar_produto();

                txtId.Text = "";
                txtNome.Text = "";
                txtTipo.Text = "";
                txtStatus.Text = "";
                txtPlataforma.Text = "";
                txtPrev.Text = "";
                txtPrel.Text = "";
                txtEstoque.Text = "";
            }
        }

        private void txtPrev_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            // Verifica se a tecla pressionada não é maiuscula ou não numerica
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Apenas um ponto
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtPrel_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            // Verifica se a tecla pressionada não é maiuscula ou não numerica
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Apenas um ponto
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEstoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            // Verifica se a tecla pressionada não é maiuscula ou não numerica
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Produtos prod = new Produtos();

            int id = Convert.ToInt32(txtId.Text);

            if (txtNome.Text == "" || txtTipo.Text == "" || txtStatus.Text == "" || txtPlataforma.Text == "" || txtPrev.Text == "" || txtEstoque.Text == "")
            {
                MessageBox.Show("Preencha as informações de forma correta!!");
            }
            else
            {

                if (prod.registro_existe_produto(txtNome.Text,txtTipo.Text) == true)
                {
                    if (txtPrel.Text == "")
                    {
                        txtPrel.Text = "0.00";
                    }

                    prod.atualiza_produto(id, txtNome.Text, txtTipo.Text, txtStatus.Text, txtPlataforma.Text, txtPrev.Text, txtPrel.Text, txtEstoque.Text);

                    txtId.Text = "";
                    txtNome.Text = "";
                    txtTipo.Text = "";
                    txtStatus.Text = "";
                    txtPlataforma.Text = "";
                    txtPrev.Text = "";
                    txtPrel.Text = "";
                    txtEstoque.Text = "";

                    MessageBox.Show("Atualizado com sucesso!!");

                    Listar_produto();

                    btnEditar.Enabled = false;
                    btnExcluir.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Id Inválido!!");
                }


            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            Produtos prod = new Produtos();

            if (txtId.Text == "")
            {
                MessageBox.Show("Digite o ID do cliente a ser localizado!!");
            }
            else
            {
                int id = Convert.ToInt32(txtId.Text);

                prod.localiza_produto(id);

                if (prod.nome_produto == null)
                {
                    MessageBox.Show("Id Inválido!!");
                }

                txtId.Text = prod.Idproduto.ToString();
                txtNome.Text = prod.nome_produto.ToString();
                txtTipo.Text = prod.tipo_produto.ToString();
                txtStatus.Text = prod.status.ToString();
                txtPlataforma.Text = prod.plataforma.ToString();
                txtPrev.Text = (prod.preco_venda.ToString()).Replace(",",".");
                txtPrel.Text = (prod.preco_locacao.ToString()).Replace(",",".");
                txtEstoque.Text = prod.estoque_produto.ToString();

                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Produtos prod = new Produtos();

            if (txtId.Text == "")
            {
                MessageBox.Show("Digite o ID do cliente a ser deletado!!");
            }
            else
            {
                int id = Convert.ToInt32(txtId.Text);

                prod.exclui_produto(id);

                MessageBox.Show("Excluido com sucesso!!");

            }

            Listar_produto();

            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }
    }
}
