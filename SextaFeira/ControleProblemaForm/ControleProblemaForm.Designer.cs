namespace ControleProblemaForm
{
    partial class ControleProblemaForm
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
            this.lblPontuacao = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.txtNivel = new System.Windows.Forms.TextBox();
            this.txtTipoProblema = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvControleProblema = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCriacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoProblema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControleProblema)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPontuacao
            // 
            this.lblPontuacao.AutoSize = true;
            this.lblPontuacao.Location = new System.Drawing.Point(26, 63);
            this.lblPontuacao.Name = "lblPontuacao";
            this.lblPontuacao.Size = new System.Drawing.Size(31, 13);
            this.lblPontuacao.TabIndex = 10;
            this.lblPontuacao.Text = "Nivel";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(26, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(55, 13);
            this.lblNome.TabIndex = 9;
            this.lblNome.Text = "Descricao";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(29, 25);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(100, 20);
            this.txtDescricao.TabIndex = 7;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(29, 181);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 6;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // txtNivel
            // 
            this.txtNivel.Location = new System.Drawing.Point(29, 79);
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.Size = new System.Drawing.Size(100, 20);
            this.txtNivel.TabIndex = 12;
            // 
            // txtTipoProblema
            // 
            this.txtTipoProblema.Location = new System.Drawing.Point(29, 136);
            this.txtTipoProblema.Name = "txtTipoProblema";
            this.txtTipoProblema.Size = new System.Drawing.Size(100, 20);
            this.txtTipoProblema.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tipo do Problema";
            // 
            // dgvControleProblema
            // 
            this.dgvControleProblema.AllowUserToAddRows = false;
            this.dgvControleProblema.AllowUserToDeleteRows = false;
            this.dgvControleProblema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvControleProblema.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Descricao,
            this.DataCriacao,
            this.TipoProblema,
            this.Nivel});
            this.dgvControleProblema.Location = new System.Drawing.Point(29, 236);
            this.dgvControleProblema.Name = "dgvControleProblema";
            this.dgvControleProblema.ReadOnly = true;
            this.dgvControleProblema.Size = new System.Drawing.Size(546, 150);
            this.dgvControleProblema.TabIndex = 17;
            this.dgvControleProblema.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descricao";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // DataCriacao
            // 
            this.DataCriacao.HeaderText = "DataCriacao";
            this.DataCriacao.Name = "DataCriacao";
            this.DataCriacao.ReadOnly = true;
            // 
            // TipoProblema
            // 
            this.TipoProblema.HeaderText = "Tipo Problema";
            this.TipoProblema.Name = "TipoProblema";
            this.TipoProblema.ReadOnly = true;
            // 
            // Nivel
            // 
            this.Nivel.HeaderText = "Nivel";
            this.Nivel.Name = "Nivel";
            this.Nivel.ReadOnly = true;
            // 
            // ControleProblemaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvControleProblema);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTipoProblema);
            this.Controls.Add(this.txtNivel);
            this.Controls.Add(this.lblPontuacao);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.btnGravar);
            this.Name = "ControleProblemaForm";
            this.Text = "ControleProblemaForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvControleProblema)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPontuacao;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.TextBox txtNivel;
        private System.Windows.Forms.TextBox txtTipoProblema;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvControleProblema;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCriacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoProblema;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nivel;
    }
}