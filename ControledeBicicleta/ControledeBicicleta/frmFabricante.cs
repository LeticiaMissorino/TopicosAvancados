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
    public partial class frmFabricante : Form
    {
        public frmFabricante()
        {
            InitializeComponent();
        }

        private void cbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void frmFabricante_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            CarregarCombo();
            LimparCampos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Fabricante fabr = new Fabricante() {
                Descricao = txtNome.Text,
                cargo = new Cargo() { Id = Convert.ToInt32(cbCargo.SelectedItem) }
            };
            if (new FabricanteDB().insert(fabr))
            {
                MessageBox.Show("Registro inserido!");
                LimparCampos();
                CarregarGrid();
            }
            else
            {
                MessageBox.Show("Erro ao inserir registro!");
            }

        }
        private void CarregarGrid()
        {
            dgFabricante.DataSource = new FabricanteDB().ListarFabricante();
        }

        private void CarregarCombo() {
            cbCargo.DataSource = new CargoDB().ListarCargo();
            cbCargo.DisplayMember = "descricao";
            cbCargo.ValueMember = "id";
        }
        private void LimparCampos() {
            txtNome.Text = "";
            cbCargo.SelectedItem = 0;
        }
    }
}
