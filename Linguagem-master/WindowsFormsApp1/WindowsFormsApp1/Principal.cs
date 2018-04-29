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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void linguagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLinguagem linguagem = new FrmLinguagem();
            linguagem.Show();
        }

        private void repositorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMRepositorio respositorio = new FRMRepositorio();
            respositorio.Show();
        }
    }
}
