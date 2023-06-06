namespace TrabalhoTopGames
{
    partial class FormVendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVendas));
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcluirItem = new System.Windows.Forms.Button();
            this.btnEditarItem = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnFinalizarVenda = new System.Windows.Forms.Button();
            this.btnAbrirVenda = new System.Windows.Forms.Button();
            this.btnInserirItem = new System.Windows.Forms.Button();
            this.dgvVenda = new System.Windows.Forms.DataGridView();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.cbxProduto = new System.Windows.Forms.ComboBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblValorUnit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(171, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 86;
            this.label1.Text = "VALOR TOTAL";
            // 
            // btnExcluirItem
            // 
            this.btnExcluirItem.BackColor = System.Drawing.Color.Red;
            this.btnExcluirItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirItem.Location = new System.Drawing.Point(19, 348);
            this.btnExcluirItem.Name = "btnExcluirItem";
            this.btnExcluirItem.Size = new System.Drawing.Size(154, 45);
            this.btnExcluirItem.TabIndex = 85;
            this.btnExcluirItem.Text = "EXCLUIR ITEM";
            this.btnExcluirItem.UseVisualStyleBackColor = false;
            this.btnExcluirItem.Click += new System.EventHandler(this.btnExcluirItem_Click);
            // 
            // btnEditarItem
            // 
            this.btnEditarItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEditarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarItem.Location = new System.Drawing.Point(19, 286);
            this.btnEditarItem.Name = "btnEditarItem";
            this.btnEditarItem.Size = new System.Drawing.Size(154, 45);
            this.btnEditarItem.TabIndex = 84;
            this.btnEditarItem.Text = "EDITAR ITEM";
            this.btnEditarItem.UseVisualStyleBackColor = false;
            this.btnEditarItem.Click += new System.EventHandler(this.btnEditarItem_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(833, 325);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(142, 68);
            this.btnSair.TabIndex = 83;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnFinalizarVenda
            // 
            this.btnFinalizarVenda.BackColor = System.Drawing.Color.Firebrick;
            this.btnFinalizarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarVenda.Location = new System.Drawing.Point(617, 325);
            this.btnFinalizarVenda.Name = "btnFinalizarVenda";
            this.btnFinalizarVenda.Size = new System.Drawing.Size(142, 68);
            this.btnFinalizarVenda.TabIndex = 82;
            this.btnFinalizarVenda.Text = "FINALIZAR VENDA ";
            this.btnFinalizarVenda.UseVisualStyleBackColor = false;
            this.btnFinalizarVenda.Click += new System.EventHandler(this.btnFinalizarVenda_Click);
            // 
            // btnAbrirVenda
            // 
            this.btnAbrirVenda.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAbrirVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirVenda.Location = new System.Drawing.Point(390, 325);
            this.btnAbrirVenda.Name = "btnAbrirVenda";
            this.btnAbrirVenda.Size = new System.Drawing.Size(142, 68);
            this.btnAbrirVenda.TabIndex = 81;
            this.btnAbrirVenda.Text = "ABRIR VENDA";
            this.btnAbrirVenda.UseVisualStyleBackColor = false;
            this.btnAbrirVenda.Click += new System.EventHandler(this.btnAbrirVenda_Click);
            // 
            // btnInserirItem
            // 
            this.btnInserirItem.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnInserirItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserirItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirItem.Location = new System.Drawing.Point(19, 226);
            this.btnInserirItem.Name = "btnInserirItem";
            this.btnInserirItem.Size = new System.Drawing.Size(154, 45);
            this.btnInserirItem.TabIndex = 80;
            this.btnInserirItem.Text = "INSERIR ITEM";
            this.btnInserirItem.UseVisualStyleBackColor = false;
            this.btnInserirItem.Click += new System.EventHandler(this.btnInserirItem_Click);
            // 
            // dgvVenda
            // 
            this.dgvVenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenda.Location = new System.Drawing.Point(289, 18);
            this.dgvVenda.Name = "dgvVenda";
            this.dgvVenda.Size = new System.Drawing.Size(686, 279);
            this.dgvVenda.TabIndex = 79;
            this.dgvVenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVenda_CellContentClick);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(16, 139);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(234, 20);
            this.txtQuantidade.TabIndex = 78;
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 77;
            this.label4.Text = "QUANTIDADE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 75;
            this.label3.Text = "NOME DO PRODUTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "NOME CLIENTE";
            // 
            // cbxCliente
            // 
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(16, 34);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(234, 21);
            this.cbxCliente.TabIndex = 88;
            this.cbxCliente.SelectedIndexChanged += new System.EventHandler(this.cbxCliente_SelectedIndexChanged);
            // 
            // cbxProduto
            // 
            this.cbxProduto.FormattingEnabled = true;
            this.cbxProduto.Location = new System.Drawing.Point(16, 82);
            this.cbxProduto.Name = "cbxProduto";
            this.cbxProduto.Size = new System.Drawing.Size(234, 21);
            this.cbxProduto.TabIndex = 89;
            this.cbxProduto.SelectedIndexChanged += new System.EventHandler(this.cbxProduto_SelectedIndexChanged);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.BackColor = System.Drawing.Color.Transparent;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.Color.White;
            this.lblValor.Location = new System.Drawing.Point(191, 196);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(50, 16);
            this.lblValor.TabIndex = 90;
            this.lblValor.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 91;
            this.label5.Text = "VALOR UNITÁRIO";
            // 
            // lblValorUnit
            // 
            this.lblValorUnit.AutoSize = true;
            this.lblValorUnit.BackColor = System.Drawing.Color.Transparent;
            this.lblValorUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorUnit.ForeColor = System.Drawing.Color.White;
            this.lblValorUnit.Location = new System.Drawing.Point(47, 196);
            this.lblValorUnit.Name = "lblValorUnit";
            this.lblValorUnit.Size = new System.Drawing.Size(31, 13);
            this.lblValorUnit.TabIndex = 92;
            this.lblValorUnit.Text = "VLR";
            // 
            // FormVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::TrabalhoTopGames.Properties.Resources.Fundo_Forms;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(991, 411);
            this.Controls.Add(this.lblValorUnit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.cbxProduto);
            this.Controls.Add(this.cbxCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExcluirItem);
            this.Controls.Add(this.btnEditarItem);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnFinalizarVenda);
            this.Controls.Add(this.btnAbrirVenda);
            this.Controls.Add(this.btnInserirItem);
            this.Controls.Add(this.dgvVenda);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormVendas";
            this.Text = "FormVendas";
            this.Load += new System.EventHandler(this.FormVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcluirItem;
        private System.Windows.Forms.Button btnEditarItem;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnFinalizarVenda;
        private System.Windows.Forms.Button btnAbrirVenda;
        private System.Windows.Forms.Button btnInserirItem;
        private System.Windows.Forms.DataGridView dgvVenda;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.ComboBox cbxProduto;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblValorUnit;
    }
}