using Business2;
using Entidade;
using System;
using System.Windows.Forms;

namespace ControleProblemaForm2
{
    public partial class NivelForm : Form
    {
        public NivelForm()
        {
            InitializeComponent();
            AtualizarGridNiveis();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            var nivel = new Nivel()
            {
                Descricao = txtDescricao.Text
            };
            try
            {
                var controleProblemaBusiness = new ControleProblemaBusiness();
                controleProblemaBusiness.InserirNivel(nivel);
                LimparForm();
                AtualizarGridNiveis();
            }
            catch (Exception ex)
            {
                throw new Exception("erro " + ex);
            }
        }

        private void AtualizarGridNiveis()
        {
            var controleProblemaBusiness = new ControleProblemaBusiness();
            var niveis = controleProblemaBusiness.ListarNivel();
            dgvNivel.Rows.Clear();
            foreach (var n in niveis)
            {
                dgvNivel.Rows.Add(
                    n.Id,
                    n.Descricao
                );
            }
        }

        private void LimparForm()
        {
            txtDescricao.Text = "";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var controleProblemaForm = new ControleProblemaForm();
            controleProblemaForm.Show();
            this.Close();
        }
    }
}
