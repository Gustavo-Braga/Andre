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
            CarregarCombos();
        }

        private void CarregarCombos()
        {
            CarregarComboTipo();
            CarregarComboNivel();
        }

        private void CarregarComboNivel()
        {
            var business = new ControleProblemaBusiness();
            var niveis = business.ListarNivel();
            cboNivel.DataSource = niveis;
            cboNivel.DisplayMember = "Descricao";
            cboNivel.ValueMember = "Id";
        }

        private void CarregarComboTipo()
        {
            var business = new ControleProblemaBusiness();
            var tipos = business.ListarTipo();
            cboTipos.DataSource = tipos;
            cboTipos.DisplayMember = "Descricao";
            cboTipos.ValueMember = "Id";
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            var tipo = (Tipo)cboTipos.SelectedItem;
            var nivel = (Nivel)cboNivel.SelectedItem;
            var problema = new ControleProblema()
            {
                Descricao = txtDescricao.Text,
                NivelProblema = nivel.Id,
                TipoProblema = tipo.Id
            };
            try
            {
                var controleProblemaBusiness = new ControleProblemaBusiness();
                controleProblemaBusiness.InserirProblema(problema);
                AtualizarGridControleProblema();
                LimparForm();

            }
            catch (Exception ex)
            {
                throw new Exception("erro " + ex);
            }
        }
    
        private void AtualizarGridControleProblema()
        {
            var controleProblemaBusiness = new ControleProblemaBusiness();
            var controleProblemas = controleProblemaBusiness.ListarProblema();
            dgvControleProblema.Rows.Clear();
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

        private void LimparForm()
        {
            txtDescricao.Text = "";
            cboNivel.SelectedIndex = 0;
            cboTipos.SelectedIndex = 0;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCadastraraTipo_Click(object sender, EventArgs e)
        {
            var cadastrarTipoForm = new TipoForm();
            cadastrarTipoForm.Show();
            this.Hide();
        }

        private void cboTipos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrarNivel_Click(object sender, EventArgs e)
        {
            var cadastrarNivelForm = new NivelForm();
            cadastrarNivelForm.Show();
            this.Hide();
        }

        private void ControleProblemaForm_Load(object sender, EventArgs e)
        {
            AtualizarGridControleProblema();
            CarregarCombos();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
