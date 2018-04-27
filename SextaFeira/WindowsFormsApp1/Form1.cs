using Business;
using Entidade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AtualizarGrid();
        }

        private void btnGravar_Click_1(object sender, EventArgs e)
        {
            Linguagem linguagem = new Linguagem();
            linguagem.Nome = txtNome.Text;
            linguagem.Pontuacao = int.Parse(txtPontuacao.Text);

            try
            {
                var linguagemBusiness = new LinguagemBusiness();
                linguagemBusiness.InserirLinguagem(linguagem);
                LimparForm();
                AtualizarGrid();
            }
            catch (Exception)
            {

                MessageBox.Show("Erro! ");
            }
        }

        private void AtualizarGrid()
        {
            var linguagemBusiness = new LinguagemBusiness();
            var linguagens = linguagemBusiness.ListarLinguagem();
            dgvLinguagem.Rows.Clear();
            foreach (var ling in linguagens)
            {
                dgvLinguagem.Rows.Add(
                    ling.Id,
                    ling.Nome,
                    ling.Pontuacao
                );
            }

        }

    private void LimparForm()
    {
        txtNome.Text = "";
        txtPontuacao.Text = "";
    }

    private void dgvLinguagem_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

        private void button1_Click(object sender, EventArgs e)
        {
            var repositorio = new RepositorioForm();
            repositorio.Show();
            this.Hide();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
