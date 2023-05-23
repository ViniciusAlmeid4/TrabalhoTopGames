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

        private void FormProdutos_Load(object sender, EventArgs e)
        {
            Produtos prod = new Produtos();
            List<Produtos> list_prod = prod.lista_produto();
            dgvProdutos.DataSource = list_prod;
            btnExcluir.Enabled = false;
            btnEditar.Enabled = false;
            this.txtNome.Focus();
        }
    }
}
