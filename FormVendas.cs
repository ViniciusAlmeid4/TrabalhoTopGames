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
    }
}
