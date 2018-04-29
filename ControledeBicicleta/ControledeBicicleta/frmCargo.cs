using ControleBanco;
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

namespace ControledeBicicleta
{
    public partial class frmCargo : Form
    {
        public frmCargo()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Cargo cargo = new Cargo();

            cargo.Descricao = txtDescricao.Text;

            //MessageBox.Show("Olá turma!" + tipo);

            if (new CargoDB().insert(cargo))
            {
                MessageBox.Show("Registro inserido!");
                txtDescricao.Text = "";
                CarregarGrid();
            }
            else
            {
                MessageBox.Show("Erro ao inserir registro!");
            }

        }

        private void CarregarGrid()
        {
            dgCargo.DataSource = new CargoDB().ListarCargo();
        }

        private void frmCargo_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }
    }
}
