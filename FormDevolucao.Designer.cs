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
            this.lblValor = new System.Windows.Forms.Label();
            this.dgvDevolucao = new System.Windows.Forms.DataGridView();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnFecha = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPago = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblSelected_Id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolucao)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(761, 26);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(108, 50);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(768, 157);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(57, 20);
            this.lblValor.TabIndex = 1;
            this.lblValor.Text = "label1";
            // 
            // dgvDevolucao
            // 
            this.dgvDevolucao.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvDevolucao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevolucao.Location = new System.Drawing.Point(12, 12);
            this.dgvDevolucao.Name = "dgvDevolucao";
            this.dgvDevolucao.Size = new System.Drawing.Size(510, 387);
            this.dgvDevolucao.TabIndex = 2;
            this.dgvDevolucao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDevolucao_CellContentClick);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(541, 42);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(214, 20);
            this.txtNome.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(618, 143);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(108, 50);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnFecha
            // 
            this.btnFecha.Location = new System.Drawing.Point(871, 349);
            this.btnFecha.Name = "btnFecha";
            this.btnFecha.Size = new System.Drawing.Size(108, 50);
            this.btnFecha.TabIndex = 5;
            this.btnFecha.Text = "Sair";
            this.btnFecha.UseVisualStyleBackColor = true;
            this.btnFecha.Click += new System.EventHandler(this.btnFecha_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(875, 26);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(108, 50);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Resetar";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPago
            // 
            this.btnPago.Location = new System.Drawing.Point(796, 257);
            this.btnPago.Name = "btnPago";
            this.btnPago.Size = new System.Drawing.Size(183, 47);
            this.btnPago.TabIndex = 7;
            this.btnPago.Text = "Pagar";
            this.btnPago.UseVisualStyleBackColor = true;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.Black;
            this.lbl1.Location = new System.Drawing.Point(657, 239);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(22, 16);
            this.lbl1.TabIndex = 8;
            this.lbl1.Text = "ID";
            // 
            // lblSelected_Id
            // 
            this.lblSelected_Id.AutoSize = true;
            this.lblSelected_Id.BackColor = System.Drawing.Color.Transparent;
            this.lblSelected_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelected_Id.ForeColor = System.Drawing.Color.Black;
            this.lblSelected_Id.Location = new System.Drawing.Point(658, 272);
            this.lblSelected_Id.Name = "lblSelected_Id";
            this.lblSelected_Id.Size = new System.Drawing.Size(21, 16);
            this.lblSelected_Id.TabIndex = 9;
            this.lblSelected_Id.Text = "lbl";
            // 
            // FormDevolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(991, 411);
            this.Controls.Add(this.lblSelected_Id);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnPago);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnFecha);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.dgvDevolucao);
            this.Controls.Add(this.lblValor);
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
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.DataGridView dgvDevolucao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnFecha;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPago;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblSelected_Id;
    }
}