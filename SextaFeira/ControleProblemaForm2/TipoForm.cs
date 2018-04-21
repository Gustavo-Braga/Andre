using Business2;
using Entidade;
using System;
using System.Windows.Forms;

namespace ControleProblemaForm2
{
    public partial class TipoForm : Form
    {
        public TipoForm()
        {
            InitializeComponent();
            AtualizarGridTipo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tipo = new Tipo()
            {
                Descricao = txtDescricao.Text
            };
            try
            {
                var controleProblemaBusiness = new ControleProblemaBusiness();
                controleProblemaBusiness.InserirTipo(tipo);
                LimparForm();
                AtualizarGridTipo();

            }
            catch (Exception ex)
            {
                throw new Exception("erro " + ex);
            }
        }

        private void AtualizarGridTipo()
        {
            var controleProblemaBusiness = new ControleProblemaBusiness();
            var tipos = controleProblemaBusiness.ListarTipo();
            dgvTipo.Rows.Clear();
            foreach (var t in tipos)
            {
                dgvTipo.Rows.Add(
                    t.Id,
                    t.Descricao
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

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvTipo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}