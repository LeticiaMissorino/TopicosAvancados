using BancoDadosDB;
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

namespace WindowsFormsApp1
{
    public partial class FRMRepositorio : Form
    {
        public FRMRepositorio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Repositorio resp = new Repositorio()
            {
                nome = txtNome.Text,
                dt = Convert.ToDateTime(txtxData.Text),
                ling = new Linguagem(){ id = Convert.ToInt32(cboLing.SelectedValue) },
                
            };
            if (new RepositorioDB().insert(resp))
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

        private void Repositorio_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            CarregaCombo();
        }
        private void CarregaCombo()
        {
            cboLing.DataSource = new LinguagemDB().ListarTipo();
            cboLing.DisplayMember = "nome";
            cboLing.ValueMember = "id";
        }
        private void CarregarGrid()
        {
            dgResp.DataSource = new RepositorioDB().ListarResp();
        }
        private void LimparCampos()
        {
            txtNome.Clear();
            txtxData.Clear();
        }
    }
}
