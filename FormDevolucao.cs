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
    public partial class FormDevolucao : Form
    {

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\usuario\\Documents\\TrabalhosSenai\\TrabalhoTopGames\\DataCasa.mdf;Integrated Security=True");

        public FormDevolucao()
        {
            InitializeComponent();
        }

        private void carrega_geral()
        {
            string sql = "Select Idlocacao, nome_cliente,nome_produto,data_locacao,valor from locacao l join cliente c on l.Idcliente=c.Idcliente join produtos p on l.Idproduto=p.Idproduto";

            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();

            da.Fill(ds, "locacao");

            dgvDevolucao.DataSource = ds.Tables["locacao"];

            dgvDevolucao.Columns[0].HeaderText = "Idlocacao";
            dgvDevolucao.Columns[1].HeaderText = "nome_cliente";
            dgvDevolucao.Columns[2].HeaderText = "nome_produto";
            dgvDevolucao.Columns[3].HeaderText = "data_locacao";
            dgvDevolucao.Columns[4].HeaderText = "valor";

            con.Close();
        }

        private void carrega_nome(string nome)
        {
            string sql = "Select Idlocacao, nome_cliente,nome_produto,data_locacao,valor from locacao l join cliente c on l.Idcliente=c.Idcliente join produtos p on l.Idproduto=p.Idproduto where nome_cliente = '"+nome+"'";

            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();

            da.Fill(ds, "locacao");

            dgvDevolucao.DataSource = ds.Tables["locacao"];

            dgvDevolucao.Columns[0].HeaderText = "Idlocacao";
            dgvDevolucao.Columns[1].HeaderText = "nome_cliente";
            dgvDevolucao.Columns[2].HeaderText = "nome_produto";
            dgvDevolucao.Columns[3].HeaderText = "data_locacao";
            dgvDevolucao.Columns[4].HeaderText = "valor";

            con.Close();
        }

        private void FormDevolucao_Load(object sender, EventArgs e)
        {
            carrega_geral();

            lblSelected_Id.Text = "";

            lblValor.Text = "";
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            carrega_nome(txtNome.Text.ToString());
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            carrega_geral();
        }

        private void btnFecha_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDevolucao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvDevolucao.Rows[e.RowIndex];

            lblSelected_Id.Text = row.Cells[0].Value.ToString();
        }
    }
}
