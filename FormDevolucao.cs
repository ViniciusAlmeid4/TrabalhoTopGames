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
            string sql = "Select Idlocacao, nome_cliente,nome_produto,data_locacao,duracao,valor from locacao l join cliente c on l.Idcliente=c.Idcliente join produtos p on l.Idproduto=p.Idproduto where pago = 0";

            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();

            da.Fill(ds, "locacao");

            dgvDevolucao.DataSource = ds.Tables["locacao"];

            dgvDevolucao.Columns[0].HeaderText = "Idlocacao";
            dgvDevolucao.Columns[1].HeaderText = "nome_cliente";
            dgvDevolucao.Columns[2].HeaderText = "nome_produto";
            dgvDevolucao.Columns[3].HeaderText = "data_locacao";
            dgvDevolucao.Columns[4].HeaderText = "duracao";
            dgvDevolucao.Columns[5].HeaderText = "valor";

            con.Close();
        }

        private void carrega_nome(string nome)
        {
            string sql = "Select Idlocacao, nome_cliente,nome_produto,data_locacao,duracao,valor from locacao l join cliente c on l.Idcliente=c.Idcliente join produtos p on l.Idproduto=p.Idproduto where nome_cliente like '%" + nome + "%' and pago = 0";

            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();

            da.Fill(ds, "locacao");

            dgvDevolucao.DataSource = ds.Tables["locacao"];

            dgvDevolucao.Columns[0].HeaderText = "Idlocacao";
            dgvDevolucao.Columns[1].HeaderText = "nome_cliente";
            dgvDevolucao.Columns[2].HeaderText = "nome_produto";
            dgvDevolucao.Columns[3].HeaderText = "data_locacao";
            dgvDevolucao.Columns[4].HeaderText = "duracao";
            dgvDevolucao.Columns[5].HeaderText = "valor";

            con.Close();
        }

        private void FormDevolucao_Load(object sender, EventArgs e)
        {
            carrega_geral();

            lblSelected_Id.Text = "";

            lblValor_multa.Text = "";
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

            double valor_multa = 0.00;

            string data_locacao = row.Cells[3].Value.ToString();

            int totalDias = (DateTime.Now).Subtract(DateTime.Parse(data_locacao)).Days, duracao = Convert.ToInt32(row.Cells[4].Value.ToString());

            if (duracao <= totalDias)
            {
                while (duracao <= totalDias)
                {
                    valor_multa += 4.90;
                    totalDias -= 1;
                }
            }

            lblValor_multa.Text = valor_multa.ToString();
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            string multa = lblValor_multa.Text.Replace(",", "."), Id = lblSelected_Id.Text;

            string sql = "Update locacao set data_devolucao = '" + DateTime.Now + "', multa = '" + multa + "', pago = 1 where Idlocacao = " + Id + "";

            con.Open();

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();

            con.Close();

            carrega_geral();
        }
    }
}
