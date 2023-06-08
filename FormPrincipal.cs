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

    public partial class FormPrincipal : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\usuario\\Documents\\TrabalhosSenai\\TrabalhoTopGames\\DataCasa.mdf;Integrated Security=True");

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void locaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLocacao frm = new FormLocacao();
            frm.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCliente frm = new FormCliente();
            frm.Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProdutos frm = new FormProdutos();
            frm.Show();
        }

        private void btnCarregaProduto_Click(object sender, EventArgs e)
        {
            string sql = "Select nome_produto, tipo_produto, status, plataforma from produtos";

            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();

            da.Fill(ds, "produto");

            dgvPagIni.DataSource = ds.Tables["produto"];

            dgvPagIni.Columns[0].HeaderText = "Produto";
            dgvPagIni.Columns[1].HeaderText = "Tipo";
            dgvPagIni.Columns[2].HeaderText = "Status";
            dgvPagIni.Columns[3].HeaderText = "Plataforma";

            con.Close();
        }

        private void btnCarregaCliente_Click(object sender, EventArgs e)
        {
            string sql = "Select nome_cliente, cpf, email, celular from cliente";

            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();

            da.Fill(ds, "cliente");

            dgvPagIni.DataSource = ds.Tables["cliente"];

            dgvPagIni.Columns[0].HeaderText = "Cliente";
            dgvPagIni.Columns[1].HeaderText = "CPF";
            dgvPagIni.Columns[2].HeaderText = "E-mail";
            dgvPagIni.Columns[3].HeaderText = "Celular";

            con.Close();
        }

        private void carrega_pedidos()
        {
            string sql = "Select v.Idvenda, nome_cliente, nome_produto, data_venda, total_venda from pedido p join venda v on p.Idvenda = v.Idvenda join cliente c on p.Idcliente = c.Idcliente join produtos pr on pr.Idproduto = p.Idproduto";

            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();

            da.Fill(ds, "venda");

            dgvPagIni.DataSource = ds.Tables["venda"];

            dgvPagIni.Columns[0].HeaderText = "Idvenda";
            dgvPagIni.Columns[1].HeaderText = "Nome Cliente";
            dgvPagIni.Columns[2].HeaderText = "Nome Produto";
            dgvPagIni.Columns[3].HeaderText = "Data Venda";
            dgvPagIni.Columns[4].HeaderText = "Total Venda";

            con.Close();
        }

        private void carrega_locacao()
        {
            string sql = "Select nome_cliente, nome_produto, data_locacao, duracao from locacao l join cliente c on l.Idcliente = c.Idcliente join produtos pr on pr.Idproduto = l.Idproduto where pago = 0";

            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();

            da.Fill(ds, "locacao");

            dgvPagIni.DataSource = ds.Tables["locacao"];

            dgvPagIni.Columns[0].HeaderText = "Nome Cliente";
            dgvPagIni.Columns[1].HeaderText = "Nome Produto";
            dgvPagIni.Columns[2].HeaderText = "Data Locação";
            dgvPagIni.Columns[3].HeaderText = "Duração";

            con.Close();
        }

        private void novaLocaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLocacao frm = new FormLocacao();
            frm.Show();
        }

        private void devoluçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDevolucao frm = new FormDevolucao();
            frm.Show();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVendas frm = new FormVendas();
            frm.Show();
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            carrega_pedidos();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormCliente frm = new FormCliente();
            frm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormProdutos frm = new FormProdutos();
            frm.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FormLocacao frm = new FormLocacao();
            frm.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormVendas frm = new FormVendas();
            frm.Show();
        }

        private void btnLocacao_Click(object sender, EventArgs e)
        {
            carrega_locacao();
        }
    }
}
