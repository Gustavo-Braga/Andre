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
    public partial class RepositorioForm : Form
    {
        public RepositorioForm()
        {
            InitializeComponent();
            AtualizarGrid();
            CarregarCombos();
        }

        private void CarregarCombos()
        {
            CarregarLinguagens();
        }

        private void CarregarLinguagens()
        {
            var business = new LinguagemBusiness();
            var linguagens = business.ListarLinguagem();
            cboLinguagem.DataSource = linguagens;
            cboLinguagem.DisplayMember = "Nome";
            cboLinguagem.ValueMember = "Id";
        }

        private void AtualizarGrid()
        {
            var linguagemBusiness = new LinguagemBusiness();
            var repositorios = linguagemBusiness.ListarRepositorio();
            var linguagem = linguagemBusiness.ListarLinguagem();
            dgvRepositorio.Rows.Clear();
            foreach (var repo in repositorios)
            {
                var ling = linguagem.Where(x => x.Id == repo.IdLinguagem).SingleOrDefault();
                dgvRepositorio.Rows.Add(
                    repo.Id,
                    repo.Nome,
                    ling.Nome,
                    repo.DataCriacao
                );
            }
        }

        private void lblNome_Click(object sender, EventArgs e)
        {
        }

        private void LimparForm()
        {
            txtNome.Text = "";
            cboLinguagem.SelectedIndex = 0;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            var linguagem = (Linguagem)cboLinguagem.SelectedItem;
            var repositorio = new Repositorio();
            repositorio.Nome = txtNome.Text;
            repositorio.DataCriacao = DateTime.Now;
            repositorio.IdLinguagem = linguagem.Id;

            try
            {
                var linguagemBusiness = new LinguagemBusiness();
                linguagemBusiness.InserirRepositorio(repositorio);
                LimparForm();
                AtualizarGrid();
            }
            catch (Exception)
            {

                MessageBox.Show("Erro! ");
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            var linguagem = new Form1();
            linguagem.Show();
            this.Close();
        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
           
        }
    }
}
