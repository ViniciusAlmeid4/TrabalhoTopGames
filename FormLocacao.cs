using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoTopGames
{
    public partial class FormLocacao : Form
    {

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\usuario\\Documents\\TrabalhosSenai\\TrabalhoTopGames\\DataCasa.mdf;Integrated Security=True");

        public FormLocacao()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Carrega_produto()
        {
            string prod = "SELECT Idproduto,nome_produto FROM produtos WHERE preco_locacao <> 0";
            // SqlCommand cmd = new SqlCommand(cli, con);
            // cmd.CommandType = CommandType.Text;
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(prod, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "produtos");
            cbxProduto.ValueMember = "Idproduto";
            cbxProduto.DisplayMember = "nome_produto";
            cbxProduto.DataSource = ds.Tables["produtos"];
            con.Close();
        } 

        private void Carrega_cliente()
        {
            string cli = "SELECT Idcliente,nome_cliente FROM cliente";
            // SqlCommand cmd = new SqlCommand(cli, con);
            // cmd.CommandType = CommandType.Text;
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cli, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "cliente");
            cbxCliente.ValueMember = "Idcliente";
            cbxCliente.DisplayMember = "nome_cliente";
            cbxCliente.DataSource = ds.Tables["cliente"];
            con.Close();
        }

        private void FormLocacao_Load(object sender, EventArgs e)
        {
            cbxCliente.Enabled = false;
            cbxProduto.Enabled = false;
            btnFinalizarLocacao.Enabled = false;
            btnInserirItem.Enabled = false;
            btnEditarItem.Enabled = false;
            btnExcluirItem.Enabled = false;
            txtDuracao.Enabled = false;

            lblIdProd.Text = "";
            lblValorProd.Text = "";
            lblValorTotal.Text = "";
        }

        private void btnAbrirLocacao_Click(object sender, EventArgs e)
        {
            dgvLocacao.Columns.Add("Cliente", "Cliente");
            dgvLocacao.Columns.Add("Produto", "Produto");
            dgvLocacao.Columns.Add("Duracao", "Duração");
            dgvLocacao.Columns.Add("Valor_Prod", "Valor Produto");

            Carrega_cliente();
            Carrega_produto();

            cbxCliente.Enabled = true;
            cbxProduto.Enabled = true;
            btnFinalizarLocacao.Enabled = true;
            btnInserirItem.Enabled = true;
            btnEditarItem.Enabled = true;
            btnExcluirItem.Enabled = true;
            txtDuracao.Enabled = true;
        }

        private void cbxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxProduto.Focus();
        }

        private void cbxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            string sql = "SELECT preco_locacao FROM produtos WHERE Idproduto = "+cbxProduto.SelectedValue.ToString()+"";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            decimal Preco = cmd.ExecuteNonQuery();
            lblValorProd.Text = Preco.ToString();
            lblIdProd.Text = cbxProduto.SelectedValue.ToString();
            txtDuracao.Focus();
            con.Close();
        }

        private void btnInserirItem_Click(object sender, EventArgs e)
        {
            var repetido = false;
            foreach (DataGridViewRow dr in dgvLocacao.Rows)
            {
                if (cbxProduto.Text == Convert.ToString(dr.Cells[1].Value))
                {
                    repetido = true;
                }
            }
            if (repetido == false)
            {
                DataGridViewRow item = new DataGridViewRow();
                item.CreateCells(dgvLocacao);
                item.Cells[0].Value = cbxProduto.SelectedValue;
                item.Cells[1].Value = cbxProduto.Text;
                item.Cells[2].Value = txtDuracao.Text;
                item.Cells[3].Value = lblValorProd.Text;
                dgvLocacao.Rows.Add(item);
                lblValorProd.Text = "";
                cbxProduto.Text = "";
                cbxCliente.Text = "";
                txtDuracao.Text = "";
                lblIdProd.Text = "";
                decimal soma = 0;
                foreach (DataGridViewRow dr in dgvLocacao.Rows)
                {
                    soma += Convert.ToDecimal(dr.Cells[3].Value);
                    lblValorTotal.Text = Convert.ToString(soma);
                }
            }
            else
            {
                MessageBox.Show("Produto já está inserido na venda!!");
            }
        }
    }
}
