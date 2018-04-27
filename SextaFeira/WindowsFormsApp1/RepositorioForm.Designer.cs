namespace WindowsFormsApp1
{
    partial class RepositorioForm
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.cboLinguagem = new System.Windows.Forms.ComboBox();
            this.dgvRepositorio = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Linguagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCriacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPontuacao = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepositorio)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(326, 111);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(132, 23);
            this.btnVoltar.TabIndex = 34;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // cboLinguagem
            // 
            this.cboLinguagem.FormattingEnabled = true;
            this.cboLinguagem.Location = new System.Drawing.Point(237, 53);
            this.cboLinguagem.Name = "cboLinguagem";
            this.cboLinguagem.Size = new System.Drawing.Size(121, 21);
            this.cboLinguagem.TabIndex = 32;
            // 
            // dgvRepositorio
            // 
            this.dgvRepositorio.AllowUserToAddRows = false;
            this.dgvRepositorio.AllowUserToDeleteRows = false;
            this.dgvRepositorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepositorio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.Linguagem,
            this.DataCriacao});
            this.dgvRepositorio.Location = new System.Drawing.Point(104, 264);
            this.dgvRepositorio.Name = "dgvRepositorio";
            this.dgvRepositorio.ReadOnly = true;
            this.dgvRepositorio.Size = new System.Drawing.Size(495, 150);
            this.dgvRepositorio.TabIndex = 28;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Linguagem
            // 
            this.Linguagem.HeaderText = "Linguagem";
            this.Linguagem.Name = "Linguagem";
            this.Linguagem.ReadOnly = true;
            // 
            // DataCriacao
            // 
            this.DataCriacao.HeaderText = "DataCriacao";
            this.DataCriacao.Name = "DataCriacao";
            this.DataCriacao.ReadOnly = true;
            this.DataCriacao.Width = 150;
            // 
            // lblPontuacao
            // 
            this.lblPontuacao.AutoSize = true;
            this.lblPontuacao.Location = new System.Drawing.Point(246, 37);
            this.lblPontuacao.Name = "lblPontuacao";
            this.lblPontuacao.Size = new System.Drawing.Size(59, 13);
            this.lblPontuacao.TabIndex = 27;
            this.lblPontuacao.Text = "Linguagem";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(101, 37);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 26;
            this.lblNome.Text = "Nome";
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(104, 53);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 25;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(104, 111);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(132, 23);
            this.btnGravar.TabIndex = 24;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // RepositorioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.cboLinguagem);
            this.Controls.Add(this.dgvRepositorio);
            this.Controls.Add(this.lblPontuacao);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnGravar);
            this.Name = "RepositorioForm";
            this.Text = "RepositorioForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepositorio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ComboBox cboLinguagem;
        private System.Windows.Forms.DataGridView dgvRepositorio;
        private System.Windows.Forms.Label lblPontuacao;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Linguagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCriacao;
    }
}