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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void novaLocaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLocacao frm = new FormLocacao();
            frm.Show();
        }
    }
}
