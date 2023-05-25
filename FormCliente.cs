using Revisao;
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
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        public void Listar_cliete()
        {
            Cliente cliente = new Cliente();
            List<Cliente> cli = cliente.lista_cliente();
            dgvClientes.DataSource = cli;
        }

        public string Verifica_dados(string mod)
        {
            mod = mod.Trim();
            
            mod = mod.Replace(",", "");
            mod = mod.Replace(".", "");
            mod = mod.Replace("-", "");
            mod = mod.Replace("(", "");
            mod = mod.Replace(")", "");

            return mod;
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            Listar_cliete();
            btnExcluir.Enabled = false;
            btnEditar.Enabled = false;
            this.txtNome.Focus();
        }

        private void pbxPesquisar_Click(object sender, EventArgs e)
        {
            if(txtCep.Text == "")
            {
                MessageBox.Show("Insira um CEP!!");
                this.txtCep.Focus();
            }
            else
            {
                BuscaCEP busca = new BuscaCEP(txtCep.Text);
                txtComplemento.Text = busca.complemento;
                txtEndereco.Text = busca.endereco;
                txtCidade.Text = busca.cidade;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();

            if(txtNome.Text == "" || txtCep.Text == "" || txtCpf.Text == "" || txtEmail.Text == "" || txtCelular.Text == "" || txtCidade.Text == "" || txtEndereco.Text == "")
            {
                MessageBox.Show("Preencha as informações de forma correta!!");

            }
            else
            {
                if(txtComplemento.Text == "")
                {
                    txtComplemento.Text = "NI";
                }

                if (cli.registro_existe_cli(txtCpf.Text) == true)
                {
                    MessageBox.Show("Cpf " + txtCpf.Text + " já existe!!");
                }
                else
                {
                    string cpf = txtCpf.Text, celular = txtCelular.Text, cep = txtCep.Text;

                    cpf = Verifica_dados(cpf);

                    celular = Verifica_dados(celular);

                    cep = Verifica_dados(cep);

                    cli.inserir_cliente(txtNome.Text, cep, cpf, txtEmail.Text, celular, txtCidade.Text, txtEndereco.Text, txtComplemento.Text);
                }

                MessageBox.Show("Inserido com sucesso!!");

                Listar_cliete();

                txtId.Text = "";
                txtNome.Text = "";
                txtCep.Text = "";
                txtCpf.Text = "";
                txtEmail.Text = "";
                txtCelular.Text = "";
                txtCidade.Text = "";
                txtEndereco.Text = "";
                txtComplemento.Text = "";
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();

            int id = Convert.ToInt32(txtId.Text);

            if (txtNome.Text == "" || txtCep.Text == "" || txtCpf.Text == "" || txtEmail.Text == "" || txtCelular.Text == "" || txtCidade.Text == "" || txtEndereco.Text == "")
            {
                MessageBox.Show("Preencha as informações de forma correta!!");
            }
            else
            {

                if (cli.registro_existe_cli(txtCpf.Text) == true)
                {
                    if (txtComplemento.Text == "")
                    {
                        txtComplemento.Text = "NI";
                    }

                    cli.atualiza_cliente(id, txtNome.Text, txtCep.Text, txtCpf.Text, txtEmail.Text, txtCelular.Text, txtCidade.Text, txtEndereco.Text, txtComplemento.Text);

                    txtId.Text = "";
                    txtNome.Text = "";
                    txtCep.Text = "";
                    txtCpf.Text = "";
                    txtEmail.Text = "";
                    txtCelular.Text = "";
                    txtCidade.Text = "";
                    txtEndereco.Text = "";
                    txtComplemento.Text = "";

                    MessageBox.Show("Atualizado com sucesso!!");

                    Listar_cliete();

                    btnEditar.Enabled = false;
                    btnExcluir.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Id Inválido!!");
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();

            if(txtId.Text == "")
            {
                MessageBox.Show("Digite o ID do cliente a ser deletado!!");
            }
            else
            {
                int id = Convert.ToInt32 (txtId.Text);
                  
                cli.exclui_cliente(id);

                MessageBox.Show("Excluido com sucesso!!");

            }

            Listar_cliete();

            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();

            if (txtId.Text == "")
            {
                MessageBox.Show("Digite o ID do cliente a ser localizado!!");
            }
            else
            {
                int id = Convert.ToInt32(txtId.Text);

                cli.localiza_cliente(id);

                if (cli.nome_cliente == null) 
                {
                    MessageBox.Show("Id Inválido!!");
                }

                txtNome.Text = cli.nome_cliente.ToString();
                txtCep.Text = cli.cep.ToString();
                txtCpf.Text = cli.cpf.ToString();
                txtEmail.Text = cli.email.ToString();
                txtCelular.Text = cli.celular.ToString();
                txtCidade.Text = cli.cidade.ToString();
                txtEndereco.Text = cli.endereco.ToString(); 
                txtComplemento.Text = cli.complemento.ToString();

                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            // Verifica se a tecla pressionada não é maiuscula ou não numerica
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            // Verifica se a tecla pressionada não é maiuscula ou não numerica
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '(') && (e.KeyChar != ')') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            // Verifica se a tecla pressionada não é maiuscula ou não numerica
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
    }
}
