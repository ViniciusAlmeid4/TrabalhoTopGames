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
            dgvLocacao.Columns.Add("Id_cliente", "Id Cliente");
            dgvLocacao.Columns.Add("Cliente", "Cliente");
            dgvLocacao.Columns.Add("Id_produto", "Id produto");
            dgvLocacao.Columns.Add("Produto", "Produto");
            dgvLocacao.Columns.Add("Duracao", "Duração");
            dgvLocacao.Columns.Add("Valor_Prod", "Valor Produto");

            Carrega_cliente();
            Carrega_produto();

            btnAbrirLocacao.Enabled = false;
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
            con.Open();
            string sql = "SELECT preco_locacao FROM produtos WHERE Idproduto = "+ cbxProduto.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(sql, con);
            lblValorProd.Text = (cmd.ExecuteScalar()).ToString();
            lblIdProd.Text = cbxProduto.SelectedValue.ToString();
            txtDuracao.Focus();
            con.Close();
        }

        private void btnInserirItem_Click(object sender, EventArgs e)
        {
            var repetido = false;
            var duracao = true;
            if(txtDuracao.Text == "")
            {
                duracao = false;
            }

            foreach (DataGridViewRow dr in dgvLocacao.Rows)
            {
                if (cbxProduto.Text == Convert.ToString(dr.Cells[3].Value))
                {
                    repetido = true;
                }
            }

            if (repetido == false && duracao == true)
            {

                DataGridViewRow item = new DataGridViewRow();
                item.CreateCells(dgvLocacao);
                item.Cells[0].Value = cbxCliente.SelectedValue.ToString();
                item.Cells[1].Value = cbxCliente.Text;
                item.Cells[2].Value = cbxProduto.SelectedValue.ToString();
                item.Cells[3].Value = cbxProduto.Text;
                item.Cells[4].Value = txtDuracao.Text;
                item.Cells[5].Value = lblValorProd.Text;
                dgvLocacao.Rows.Add(item);
                lblValorProd.Text = "";
                cbxProduto.Text = "";
                cbxCliente.Text = "";
                txtDuracao.Text = "";
                lblIdProd.Text = "";
                decimal soma = 0;
                foreach (DataGridViewRow dr in dgvLocacao.Rows)
                {
                    soma += Convert.ToDecimal(dr.Cells[5].Value);
                }

                lblValorTotal.Text = Convert.ToString(soma);

            }
            else
            {
                if (duracao == false)
                {
                    MessageBox.Show("Preencha a duração");
                }
                else
                {
                    MessageBox.Show("Produto já está inserido na Locacao!!");
                }
            }
        }

        private void dgvLocacao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvLocacao.Rows[e.RowIndex];
            if (row.Cells[1].Value == null)
            {
                lblValorProd.Text = "";
                cbxProduto.Text = "";
                cbxCliente.Text = "";
                txtDuracao.Text = "";
                lblIdProd.Text = "";
            }
            else
            {
                cbxCliente.Text = row.Cells[1].Value.ToString();
                cbxProduto.Text = row.Cells[3].Value.ToString();
                txtDuracao.Text = row.Cells[4].Value.ToString();
                lblValorProd.Text = row.Cells[5].Value.ToString();
                lblIdProd.Text = cbxProduto.SelectedValue.ToString();
            }
        }

        private void btnEditarItem_Click(object sender, EventArgs e)
        {
            int linha = dgvLocacao.CurrentRow.Index;
            dgvLocacao.Rows[linha].Cells[0].Value = cbxCliente.SelectedValue;
            dgvLocacao.Rows[linha].Cells[1].Value = cbxCliente.Text;
            dgvLocacao.Rows[linha].Cells[2].Value = cbxProduto.SelectedValue;
            dgvLocacao.Rows[linha].Cells[3].Value = cbxProduto.Text;
            dgvLocacao.Rows[linha].Cells[4].Value = txtDuracao.Text;
            dgvLocacao.Rows[linha].Cells[5].Value = lblValorProd.Text;

            decimal soma = 0;
            foreach (DataGridViewRow dr in dgvLocacao.Rows)
            {
                soma += Convert.ToDecimal(dr.Cells[5].Value);
            }

            lblValorTotal.Text = Convert.ToString(soma);
        }

        private void btnExcluirItem_Click(object sender, EventArgs e)
        {
            int linha = dgvLocacao.CurrentRow.Index;
            dgvLocacao.Rows.RemoveAt(linha);
            dgvLocacao.Refresh();
            lblValorProd.Text = "";
            cbxProduto.Text = "";
            cbxCliente.Text = "";
            txtDuracao.Text = "";
            lblIdProd.Text = "";

            decimal soma = 0;
            foreach (DataGridViewRow dr in dgvLocacao.Rows)
            {
                soma += Convert.ToDecimal(dr.Cells[5].Value);
                lblValorTotal.Text = Convert.ToString(soma);
            }
        }

        private void txtDuracao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnFinalizarLocacao_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            foreach (DataGridViewRow dr in dgvLocacao.Rows)
            {
                if (dr.Cells[5].Value == null)
                {
                    // Não insere locações sem preço!!
                }
                else
                {
                    SqlCommand cmditens = new SqlCommand("InserirLocacao", con);

                    cmditens.CommandType = CommandType.StoredProcedure;
                    cmditens.Parameters.AddWithValue("@Idproduto", SqlDbType.Int).Value = Convert.ToInt32(dr.Cells[2].Value);
                    cmditens.Parameters.AddWithValue("@Idcliente", SqlDbType.Int).Value = Convert.ToInt32(dr.Cells[0].Value);
                    cmditens.Parameters.AddWithValue("@duracao", SqlDbType.Int).Value = Convert.ToInt32(dr.Cells[4].Value);
                    cmditens.Parameters.AddWithValue("@valor", SqlDbType.Decimal).Value = Convert.ToDecimal(dr.Cells[5].Value);
                    cmditens.Parameters.AddWithValue("@data_locacao", SqlDbType.NChar).Value = DateTime.Now;
                    cmditens.ExecuteNonQuery();
                }
            }

            cbxCliente.Enabled = false;
            cbxProduto.Enabled = false;
            btnFinalizarLocacao.Enabled = false;
            btnInserirItem.Enabled = false;
            btnEditarItem.Enabled = false;
            btnExcluirItem.Enabled = false;
            txtDuracao.Enabled = false;
            btnAbrirLocacao.Enabled = true;

            dgvLocacao.Refresh();

            lblIdProd.Text = "";
            lblValorProd.Text = "";
            lblValorTotal.Text = "";
            txtDuracao.Text = "";
            cbxCliente.Text = "";
            cbxProduto.Text = "";

            con.Close();
        }

        private void btnDevolucao_Click(object sender, EventArgs e)
        {
            FormDevolucao frm = new FormDevolucao();
            frm.Show();
        }
    }
}
