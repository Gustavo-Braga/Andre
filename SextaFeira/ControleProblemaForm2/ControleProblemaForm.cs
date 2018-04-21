using Business2;
using Entidade;
using System;
using System.Windows.Forms;

namespace ControleProblemaForm2
{
    public partial class ControleProblemaForm : Form
    {
        public ControleProblemaForm()
        {
            InitializeComponent();
            AtualizarGridControleProblema();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            var problema = new ControleProblema()
            {
                Descricao = txtDescricao.Text,
                NivelProblema = int.Parse(txtNivel.Text),
                TipoProblema = int.Parse(txtTipoProblema.Text)
            };
            try
            {
                var controleProblemaBusiness = new ControleProblemaBusiness();
                controleProblemaBusiness.Inserir(problema);
                AtualizarGridControleProblema();

            }
            catch(Exception ex)
            {
                throw new Exception("erro "+ex);
            }
            

        }

        private void AtualizarGridControleProblema(ControleProblema controleProblema = null)
        {
            if (controleProblema == null)
            {
                var controleProblemaBusiness = new ControleProblemaBusiness();
                var controleProblemas = controleProblemaBusiness.Listar();

                foreach (var cont in controleProblemas)
                {
                    dgvControleProblema.Rows.Add(
                        cont.Id,
                        cont.Descricao,
                        cont.DataCriacao,
                        cont.TipoProblema,
                        cont.NivelProblema
                    );
                }

            }

        }

        private void LimparForm()
        {
            txtDescricao.Text = "";
            txtNivel.Text = "";
            txtTipoProblema.Text = "";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
