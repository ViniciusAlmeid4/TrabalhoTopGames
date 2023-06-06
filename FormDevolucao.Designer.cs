namespace TrabalhoTopGames
{
    partial class FormDevolucao
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
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblValor_multa = new System.Windows.Forms.Label();
            this.dgvDevolucao = new System.Windows.Forms.DataGridView();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnFecha = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPago = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblSelected_Id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolucao)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Location = new System.Drawing.Point(972, 13);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(108, 31);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblValor_multa
            // 
            this.lblValor_multa.AutoSize = true;
            this.lblValor_multa.BackColor = System.Drawing.Color.Transparent;
            this.lblValor_multa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor_multa.ForeColor = System.Drawing.SystemColors.Control;
            this.lblValor_multa.Location = new System.Drawing.Point(695, 150);
            this.lblValor_multa.Name = "lblValor_multa";
            this.lblValor_multa.Size = new System.Drawing.Size(71, 20);
            this.lblValor_multa.TabIndex = 1;
            this.lblValor_multa.Text = "lblMulta";
            this.lblValor_multa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvDevolucao
            // 
            this.dgvDevolucao.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.dgvDevolucao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevolucao.Location = new System.Drawing.Point(12, 12);
            this.dgvDevolucao.Name = "dgvDevolucao";
            this.dgvDevolucao.Size = new System.Drawing.Size(632, 387);
            this.dgvDevolucao.TabIndex = 2;
            this.dgvDevolucao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDevolucao_CellContentClick);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(663, 17);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(303, 22);
            this.txtNome.TabIndex = 3;
            // 
            // btnFecha
            // 
            this.btnFecha.BackColor = System.Drawing.Color.Firebrick;
            this.btnFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnFecha.Location = new System.Drawing.Point(972, 350);
            this.btnFecha.Name = "btnFecha";
            this.btnFecha.Size = new System.Drawing.Size(108, 50);
            this.btnFecha.TabIndex = 5;
            this.btnFecha.Text = "Sair";
            this.btnFecha.UseVisualStyleBackColor = false;
            this.btnFecha.Click += new System.EventHandler(this.btnFecha_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(972, 50);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(108, 31);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Resetar";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPago
            // 
            this.btnPago.BackColor = System.Drawing.Color.Gold;
            this.btnPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnPago.Location = new System.Drawing.Point(663, 249);
            this.btnPago.Name = "btnPago";
            this.btnPago.Size = new System.Drawing.Size(417, 47);
            this.btnPago.TabIndex = 7;
            this.btnPago.Text = "Pagar";
            this.btnPago.UseVisualStyleBackColor = false;
            this.btnPago.Click += new System.EventHandler(this.btnPago_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl1.Location = new System.Drawing.Point(687, 109);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(62, 16);
            this.lbl1.TabIndex = 8;
            this.lbl1.Text = "MULTA:";
            // 
            // lblSelected_Id
            // 
            this.lblSelected_Id.AutoSize = true;
            this.lblSelected_Id.BackColor = System.Drawing.Color.Transparent;
            this.lblSelected_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblSelected_Id.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSelected_Id.Location = new System.Drawing.Point(875, 150);
            this.lblSelected_Id.Name = "lblSelected_Id";
            this.lblSelected_Id.Size = new System.Drawing.Size(27, 20);
            this.lblSelected_Id.TabIndex = 9;
            this.lblSelected_Id.Text = "lbl";
            this.lblSelected_Id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(839, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID LOCAÇÃO:";
            // 
            // FormDevolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = global::TrabalhoTopGames.Properties.Resources.Fundo_Forms;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1092, 411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSelected_Id);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnPago);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnFecha);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.dgvDevolucao);
            this.Controls.Add(this.lblValor_multa);
            this.Controls.Add(this.btnPesquisar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormDevolucao";
            this.Text = "Devolução";
            this.Load += new System.EventHandler(this.FormDevolucao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolucao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblValor_multa;
        private System.Windows.Forms.DataGridView dgvDevolucao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnFecha;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPago;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblSelected_Id;
        private System.Windows.Forms.Label label1;
    }
}