namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGravar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtPontuacao = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblPontuacao = new System.Windows.Forms.Label();
            this.dgvLinguagem = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pontuacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRepositorio = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinguagem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(358, 55);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 0;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click_1);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(65, 55);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtPontuacao
            // 
            this.txtPontuacao.Location = new System.Drawing.Point(231, 55);
            this.txtPontuacao.Name = "txtPontuacao";
            this.txtPontuacao.Size = new System.Drawing.Size(100, 20);
            this.txtPontuacao.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(62, 29);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome";
            // 
            // lblPontuacao
            // 
            this.lblPontuacao.AutoSize = true;
            this.lblPontuacao.Location = new System.Drawing.Point(239, 29);
            this.lblPontuacao.Name = "lblPontuacao";
            this.lblPontuacao.Size = new System.Drawing.Size(59, 13);
            this.lblPontuacao.TabIndex = 4;
            this.lblPontuacao.Text = "Pontuacao";
            // 
            // dgvLinguagem
            // 
            this.dgvLinguagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLinguagem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.Pontuacao});
            this.dgvLinguagem.Location = new System.Drawing.Point(65, 142);
            this.dgvLinguagem.Name = "dgvLinguagem";
            this.dgvLinguagem.Size = new System.Drawing.Size(344, 150);
            this.dgvLinguagem.TabIndex = 5;
            this.dgvLinguagem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLinguagem_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Pontuacao
            // 
            this.Pontuacao.HeaderText = "Pontuacao";
            this.Pontuacao.Name = "Pontuacao";
            // 
            // btnRepositorio
            // 
            this.btnRepositorio.Location = new System.Drawing.Point(358, 98);
            this.btnRepositorio.Name = "btnRepositorio";
            this.btnRepositorio.Size = new System.Drawing.Size(75, 23);
            this.btnRepositorio.TabIndex = 6;
            this.btnRepositorio.Text = "Repositorio";
            this.btnRepositorio.UseVisualStyleBackColor = true;
            this.btnRepositorio.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(489, 71);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 8;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRepositorio);
            this.Controls.Add(this.dgvLinguagem);
            this.Controls.Add(this.lblPontuacao);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtPontuacao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnGravar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinguagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtPontuacao;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblPontuacao;
        private System.Windows.Forms.DataGridView dgvLinguagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pontuacao;
        private System.Windows.Forms.Button btnRepositorio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnFechar;
    }
}

