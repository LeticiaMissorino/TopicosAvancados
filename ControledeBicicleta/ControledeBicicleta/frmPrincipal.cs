using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControledeBicicleta
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void menuCadastroCargo_Click(object sender, EventArgs e)
        {
            new frmCargo().Show();
        }

        private void menuCadastroFabricante_Click(object sender, EventArgs e)
        {
            new frmFabricante().Show();
        }

        private void menuCadastroBicicleta_Click(object sender, EventArgs e)
        {
            new frmBicicleta().Show();
        }

        private void sRAIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipal.ActiveForm.Close();
        }
    }
}
