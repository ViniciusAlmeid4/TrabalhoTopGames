namespace TrabalhoTopGames
{
    partial class FormLocacao
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcluirItem = new System.Windows.Forms.Button();
            this.btnEditarItem = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnFinalizarLocacao = new System.Windows.Forms.Button();
            this.btnAbrirLocacao = new System.Windows.Forms.Button();
            this.btnInserirItem = new System.Windows.Forms.Button();
            this.dgvLocacao = new System.Windows.Forms.DataGridView();
            this.txtDuracao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblValorProd = new System.Windows.Forms.Label();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.cbxProduto = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblIdProd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocacao)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 101;
            this.label1.Text = "VALOR TOTAL:";
            // 
            // btnExcluirItem
            // 
            this.btnExcluirItem.BackColor = System.Drawing.Color.Red;
            this.btnExcluirItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirItem.Location = new System.Drawing.Point(19, 348);
            this.btnExcluirItem.Name = "btnExcluirItem";
            this.btnExcluirItem.Size = new System.Drawing.Size(154, 45);
            this.btnExcluirItem.TabIndex = 100;
            this.btnExcluirItem.Text = "EXCLUIR ITEM";
            this.btnExcluirItem.UseVisualStyleBackColor = false;
            this.btnExcluirItem.Click += new System.EventHandler(this.btnExcluirItem_Click);
            // 
            // btnEditarItem
            // 
            this.btnEditarItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEditarItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarItem.Location = new System.Drawing.Point(19, 286);
            this.btnEditarItem.Name = "btnEditarItem";
            this.btnEditarItem.Size = new System.Drawing.Size(154, 45);
            this.btnEditarItem.TabIndex = 99;
            this.btnEditarItem.Text = "EDITAR ITEM";
            this.btnEditarItem.UseVisualStyleBackColor = false;
            this.btnEditarItem.Click += new System.EventHandler(this.btnEditarItem_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(833, 325);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(142, 68);
            this.btnSair.TabIndex = 98;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnFinalizarLocacao
            // 
            this.btnFinalizarLocacao.BackColor = System.Drawing.Color.Firebrick;
            this.btnFinalizarLocacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarLocacao.Location = new System.Drawing.Point(617, 325);
            this.btnFinalizarLocacao.Name = "btnFinalizarLocacao";
            this.btnFinalizarLocacao.Size = new System.Drawing.Size(142, 68);
            this.btnFinalizarLocacao.TabIndex = 97;
            this.btnFinalizarLocacao.Text = "FINALIZAR LOCAÇÃO ";
            this.btnFinalizarLocacao.UseVisualStyleBackColor = false;
            this.btnFinalizarLocacao.Click += new System.EventHandler(this.btnFinalizarLocacao_Click);
            // 
            // btnAbrirLocacao
            // 
            this.btnAbrirLocacao.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAbrirLocacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirLocacao.Location = new System.Drawing.Point(390, 325);
            this.btnAbrirLocacao.Name = "btnAbrirLocacao";
            this.btnAbrirLocacao.Size = new System.Drawing.Size(142, 68);
            this.btnAbrirLocacao.TabIndex = 96;
            this.btnAbrirLocacao.Text = "ABRIR LOCAÇÃO";
            this.btnAbrirLocacao.UseVisualStyleBackColor = false;
            this.btnAbrirLocacao.Click += new System.EventHandler(this.btnAbrirLocacao_Click);
            // 
            // btnInserirItem
            // 
            this.btnInserirItem.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnInserirItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirItem.Location = new System.Drawing.Point(19, 226);
            this.btnInserirItem.Name = "btnInserirItem";
            this.btnInserirItem.Size = new System.Drawing.Size(154, 45);
            this.btnInserirItem.TabIndex = 95;
            this.btnInserirItem.Text = "INSERIR ITEM";
            this.btnInserirItem.UseVisualStyleBackColor = false;
            this.btnInserirItem.Click += new System.EventHandler(this.btnInserirItem_Click);
            // 
            // dgvLocacao
            // 
            this.dgvLocacao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLocacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocacao.Location = new System.Drawing.Point(390, 18);
            this.dgvLocacao.Name = "dgvLocacao";
            this.dgvLocacao.Size = new System.Drawing.Size(585, 279);
            this.dgvLocacao.TabIndex = 94;
            this.dgvLocacao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLocacao_CellClick);
            // 
            // txtDuracao
            // 
            this.txtDuracao.Location = new System.Drawing.Point(20, 139);
            this.txtDuracao.Name = "txtDuracao";
            this.txtDuracao.Size = new System.Drawing.Size(234, 20);
            this.txtDuracao.TabIndex = 93;
            this.txtDuracao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDuracao_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 92;
            this.label4.Text = "DURAÇÃO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 90;
            this.label3.Text = "NOME DO PRODUTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 88;
            this.label2.Text = "NOME CLIENTE";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(122, 191);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(35, 13);
            this.lblValorTotal.TabIndex = 102;
            this.lblValorTotal.Text = "label5";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(260, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 29);
            this.label5.TabIndex = 103;
            this.label5.Text = "VALOR DO PRODUTO";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValorProd
            // 
            this.lblValorProd.AutoSize = true;
            this.lblValorProd.Location = new System.Drawing.Point(290, 95);
            this.lblValorProd.Name = "lblValorProd";
            this.lblValorProd.Size = new System.Drawing.Size(35, 13);
            this.lblValorProd.TabIndex = 104;
            this.lblValorProd.Text = "label5";
            // 
            // cbxCliente
            // 
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(20, 35);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(121, 21);
            this.cbxCliente.TabIndex = 105;
            this.cbxCliente.SelectedIndexChanged += new System.EventHandler(this.cbxCliente_SelectedIndexChanged);
            // 
            // cbxProduto
            // 
            this.cbxProduto.FormattingEnabled = true;
            this.cbxProduto.Location = new System.Drawing.Point(20, 87);
            this.cbxProduto.Name = "cbxProduto";
            this.cbxProduto.Size = new System.Drawing.Size(121, 21);
            this.cbxProduto.TabIndex = 106;
            this.cbxProduto.SelectedIndexChanged += new System.EventHandler(this.cbxProduto_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(177, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 38);
            this.label6.TabIndex = 107;
            this.label6.Text = "ID DO PRODUTO";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIdProd
            // 
            this.lblIdProd.AutoSize = true;
            this.lblIdProd.Location = new System.Drawing.Point(196, 95);
            this.lblIdProd.Name = "lblIdProd";
            this.lblIdProd.Size = new System.Drawing.Size(35, 13);
            this.lblIdProd.TabIndex = 108;
            this.lblIdProd.Text = "label5";
            // 
            // FormLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 411);
            this.Controls.Add(this.lblIdProd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxProduto);
            this.Controls.Add(this.cbxCliente);
            this.Controls.Add(this.lblValorProd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExcluirItem);
            this.Controls.Add(this.btnEditarItem);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnFinalizarLocacao);
            this.Controls.Add(this.btnAbrirLocacao);
            this.Controls.Add(this.btnInserirItem);
            this.Controls.Add(this.dgvLocacao);
            this.Controls.Add(this.txtDuracao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FormLocacao";
            this.Text = "FormLocacao";
            this.Load += new System.EventHandler(this.FormLocacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcluirItem;
        private System.Windows.Forms.Button btnEditarItem;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnFinalizarLocacao;
        private System.Windows.Forms.Button btnAbrirLocacao;
        private System.Windows.Forms.Button btnInserirItem;
        private System.Windows.Forms.DataGridView dgvLocacao;
        private System.Windows.Forms.TextBox txtDuracao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblValorProd;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.ComboBox cbxProduto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblIdProd;
    }
}