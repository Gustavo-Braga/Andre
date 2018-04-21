using Business2;
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

namespace ControleProblemaForm
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
                        cont.Nivel
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
