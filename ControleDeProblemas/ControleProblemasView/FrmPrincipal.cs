using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleProblemasView
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmTipo().Show();
        }

        private void menuCadastroNivel_Click(object sender, EventArgs e)
        {
            new FrmNivel().Show();
        }

        private void menuCadastroProblema_Click(object sender, EventArgs e)
        {
            new frmProblema().Show();
        }

        private void menuSair_Click(object sender, EventArgs e)
        {
            FrmPrincipal.ActiveForm.Close();
        }
    }
}
