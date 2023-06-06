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
    public partial class FormVendas : Form
    {

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\usuario\\Documents\\TrabalhosSenai\\TrabalhoTopGames\\DataCasa.mdf;Integrated Security=True");

        public FormVendas()
        {
            InitializeComponent();
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

        private void Carrega_produto()
        {
            string prod = "SELECT Idproduto,nome_produto FROM produtos";
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

        private void FormVendas_Load(object sender, EventArgs e)
        {

            cbxCliente.Enabled = false;
            cbxProduto.Enabled = false;
            btnFinalizarVenda.Enabled = false;
            btnInserirItem.Enabled = false;
            btnEditarItem.Enabled = false;
            btnExcluirItem.Enabled = false;
            txtQuantidade.Enabled = false;

            lblValor.Text = "";
            lblValorUnit.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAbrirVenda_Click(object sender, EventArgs e)
        {
            Carrega_cliente();
            Carrega_produto();

            cbxCliente.Enabled = true;
            cbxProduto.Enabled = true;
            btnFinalizarVenda.Enabled = true;
            btnInserirItem.Enabled = true;
            btnEditarItem.Enabled = true;
            btnExcluirItem.Enabled = true;
            txtQuantidade.Enabled = true;
            btnAbrirVenda.Enabled = false;

            dgvVenda.Columns.Add("Id_cliente", "Id Cliente");
            dgvVenda.Columns.Add("Cliente", "Cliente");
            dgvVenda.Columns.Add("Id_produto", "Id produto");
            dgvVenda.Columns.Add("Produto", "Produto");
            dgvVenda.Columns.Add("Quantidade", "Quantidade");
            dgvVenda.Columns.Add("Val_unit", "Valor unitário");
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
            string sql = "SELECT preco_venda FROM produtos WHERE Idproduto = " + cbxProduto.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(sql, con);
            lblValorUnit.Text = (cmd.ExecuteScalar()).ToString();
            txtQuantidade.Focus();
            con.Close();
        }

        private void btnInserirItem_Click(object sender, EventArgs e)
        {
            var repetido = false;
            var quant = true;
            if (txtQuantidade.Text == "")
            {
                quant = false;
            }

            foreach (DataGridViewRow dr in dgvVenda.Rows)
            {
                if (cbxProduto.Text == Convert.ToString(dr.Cells[3].Value))
                {
                    repetido = true;
                }
            }

            if (repetido == false && quant == true)
            {
                DataGridViewRow item = new DataGridViewRow();
                item.CreateCells(dgvVenda);
                item.Cells[0].Value = cbxCliente.SelectedValue.ToString();
                item.Cells[1].Value = cbxCliente.Text;
                item.Cells[2].Value = cbxProduto.SelectedValue.ToString();
                item.Cells[3].Value = cbxProduto.Text;
                item.Cells[4].Value = txtQuantidade.Text;
                item.Cells[5].Value = lblValorUnit.Text;
                dgvVenda.Rows.Add(item);
                lblValorUnit.Text = "";
                cbxProduto.Text = "";
                cbxCliente.Text = "";
                txtQuantidade.Text = "";
                decimal soma = 0, valor;
                int quantidade;
                foreach (DataGridViewRow dr in dgvVenda.Rows)
                {
                    quantidade = Convert.ToInt32(dr.Cells[4].Value);
                    valor = Convert.ToDecimal(dr.Cells[5].Value);
                    soma += quantidade*valor;
                }
                lblValor.Text = Convert.ToString(soma);
            }
            else
            {
                if (quant == false)
                {
                    MessageBox.Show("Preencha a Quantidade");
                }
                else
                {
                    MessageBox.Show("Produto já está inserido na Venda!!");
                }
            }
        }

        private void dgvVenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvVenda.Rows[e.RowIndex];
            if (row.Cells[1].Value == null)
            {
                lblValorUnit.Text = "";
                cbxProduto.Text = "";
                cbxCliente.Text = "";
                txtQuantidade.Text = "";
            }
            else
            {
                cbxCliente.Text = row.Cells[1].Value.ToString();
                cbxProduto.Text = row.Cells[3].Value.ToString();
                txtQuantidade.Text = row.Cells[4].Value.ToString();
                lblValorUnit.Text = row.Cells[5].Value.ToString();
            }
        }

        private void btnEditarItem_Click(object sender, EventArgs e)
        {
            int linha = dgvVenda.CurrentRow.Index;
            dgvVenda.Rows[linha].Cells[0].Value = cbxCliente.SelectedValue;
            dgvVenda.Rows[linha].Cells[1].Value = cbxCliente.Text;
            dgvVenda.Rows[linha].Cells[2].Value = cbxProduto.SelectedValue;
            dgvVenda.Rows[linha].Cells[3].Value = cbxProduto.Text;
            dgvVenda.Rows[linha].Cells[4].Value = txtQuantidade.Text;
            dgvVenda.Rows[linha].Cells[5].Value = lblValorUnit.Text;

            decimal soma = 0, valor;
            int quantidade;
            foreach (DataGridViewRow dr in dgvVenda.Rows)
            {
                quantidade = Convert.ToInt32(dr.Cells[4].Value);
                valor = Convert.ToDecimal(dr.Cells[5].Value);
                soma += quantidade * valor;
            }
            lblValor.Text = Convert.ToString(soma);
        }

        private void btnExcluirItem_Click(object sender, EventArgs e)
        {
            int linha = dgvVenda.CurrentRow.Index;
            dgvVenda.Rows.RemoveAt(linha);
            dgvVenda.Refresh();
            lblValorUnit.Text = "";
            cbxProduto.Text = "";
            cbxCliente.Text = "";
            txtQuantidade.Text = "";

            decimal soma = 0, valor;
            int quantidade;
            foreach (DataGridViewRow dr in dgvVenda.Rows)
            {
                quantidade = Convert.ToInt32(dr.Cells[4].Value);
                valor = Convert.ToDecimal(dr.Cells[5].Value);
                soma += quantidade * valor;
            }
            lblValor.Text = Convert.ToString(soma);
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = new SqlCommand("InserirVenda", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@data", SqlDbType.DateTime).Value = DateTime.Now;
            cmd.Parameters.AddWithValue("@total", SqlDbType.Decimal).Value = Convert.ToDecimal(lblValor.Text);
            cmd.ExecuteNonQuery();
            string idvenda = "SELECT IDENT_CURRENT('venda') AS Idvenda";
            SqlCommand cmd2 = new SqlCommand(idvenda, con);
            Int32 idvenda2 = Convert.ToInt32(cmd2.ExecuteScalar());

            foreach (DataGridViewRow dr in dgvVenda.Rows)
            {
                if (dr.Cells[5].Value == null)
                {
                    // Não insere locações sem preço!!
                }
                else
                {
                    SqlCommand cmditens = new SqlCommand("InserirItensVendidos", con);
                    cmditens.CommandType = CommandType.StoredProcedure;
                    cmditens.Parameters.AddWithValue("@Idvenda", SqlDbType.Int).Value = idvenda2;
                    cmditens.Parameters.AddWithValue("@Idcliente", SqlDbType.Int).Value = Convert.ToInt32(dr.Cells[0].Value);
                    cmditens.Parameters.AddWithValue("@Idproduto", SqlDbType.Int).Value = Convert.ToInt32(dr.Cells[2].Value);
                    cmditens.Parameters.AddWithValue("@valorunitario", SqlDbType.Decimal).Value = Convert.ToDecimal(dr.Cells[5].Value);

                    decimal soma = 0, valor = 0;
                    int quantidade = 0;

                    quantidade = Convert.ToInt32(dr.Cells[4].Value);
                    valor = Convert.ToDecimal(dr.Cells[5].Value);
                    soma = quantidade * valor;


                    cmditens.Parameters.AddWithValue("@total", SqlDbType.Decimal).Value = soma;
                    cmditens.ExecuteNonQuery();
                }
            }
            con.Close();

            dgvVenda.Rows.Clear();
            dgvVenda.Refresh();

            MessageBox.Show("Venda realizada com sucesso!");

            cbxCliente.Enabled = false;
            cbxProduto.Enabled = false;
            btnFinalizarVenda.Enabled = false;
            btnInserirItem.Enabled = false;
            btnEditarItem.Enabled = false;
            btnExcluirItem.Enabled = false;
            txtQuantidade.Enabled = false;
            btnAbrirVenda.Enabled = true;

            lblValorUnit.Text = "";
            lblValor.Text = "";
            txtQuantidade.Text = "";
            cbxCliente.Text = "";
            cbxProduto.Text = "";

            con.Close();
        }
    }
}
