namespace ControleProblemaForm2
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
            this.dgvControleProblema = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCriacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoProblema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCadastraraTipo = new System.Windows.Forms.Button();
            this.cboTipos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboNivel = new System.Windows.Forms.ComboBox();
            this.btnCadastrarNivel = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControleProblema)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPontuacao
            // 
            this.lblPontuacao.AutoSize = true;
            this.lblPontuacao.Location = new System.Drawing.Point(171, 9);
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
            this.btnGravar.Location = new System.Drawing.Point(29, 83);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(132, 23);
            this.btnGravar.TabIndex = 6;
            this.btnGravar.Text = "Gravar Problema";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
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
            this.dgvControleProblema.Size = new System.Drawing.Size(596, 150);
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
            this.DataCriacao.Width = 150;
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
            // btnCadastraraTipo
            // 
            this.btnCadastraraTipo.Location = new System.Drawing.Point(29, 112);
            this.btnCadastraraTipo.Name = "btnCadastraraTipo";
            this.btnCadastraraTipo.Size = new System.Drawing.Size(132, 23);
            this.btnCadastraraTipo.TabIndex = 18;
            this.btnCadastraraTipo.Text = "Cadastrar Tipo";
            this.btnCadastraraTipo.UseVisualStyleBackColor = true;
            this.btnCadastraraTipo.Click += new System.EventHandler(this.btnCadastraraTipo_Click);
            // 
            // cboTipos
            // 
            this.cboTipos.FormattingEnabled = true;
            this.cboTipos.Location = new System.Drawing.Point(322, 25);
            this.cboTipos.Name = "cboTipos";
            this.cboTipos.Size = new System.Drawing.Size(121, 21);
            this.cboTipos.TabIndex = 19;
            this.cboTipos.SelectedIndexChanged += new System.EventHandler(this.cboTipos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tipo do Problema";
            // 
            // cboNivel
            // 
            this.cboNivel.FormattingEnabled = true;
            this.cboNivel.Location = new System.Drawing.Point(162, 25);
            this.cboNivel.Name = "cboNivel";
            this.cboNivel.Size = new System.Drawing.Size(121, 21);
            this.cboNivel.TabIndex = 21;
            // 
            // btnCadastrarNivel
            // 
            this.btnCadastrarNivel.Location = new System.Drawing.Point(29, 141);
            this.btnCadastrarNivel.Name = "btnCadastrarNivel";
            this.btnCadastrarNivel.Size = new System.Drawing.Size(132, 23);
            this.btnCadastrarNivel.TabIndex = 22;
            this.btnCadastrarNivel.Text = "Cadastrar Nivel";
            this.btnCadastrarNivel.UseVisualStyleBackColor = true;
            this.btnCadastrarNivel.Click += new System.EventHandler(this.btnCadastrarNivel_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(29, 170);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(132, 23);
            this.btnFechar.TabIndex = 23;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // ControleProblemaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnCadastrarNivel);
            this.Controls.Add(this.cboNivel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboTipos);
            this.Controls.Add(this.btnCadastraraTipo);
            this.Controls.Add(this.dgvControleProblema);
            this.Controls.Add(this.lblPontuacao);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.btnGravar);
            this.Name = "ControleProblemaForm";
            this.Text = "ControleProblemaForm";
            this.Load += new System.EventHandler(this.ControleProblemaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvControleProblema)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPontuacao;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.DataGridView dgvControleProblema;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCriacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoProblema;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nivel;
        private System.Windows.Forms.Button btnCadastraraTipo;
        private System.Windows.Forms.ComboBox cboTipos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboNivel;
        private System.Windows.Forms.Button btnCadastrarNivel;
        private System.Windows.Forms.Button btnFechar;
    }
}