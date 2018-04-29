using Controle2;
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

namespace ControleProblemasView
{
    public partial class frmProblema : Form
    {
        public frmProblema()
        {
            InitializeComponent();
        }

        private void frmProblema_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            CarregaCombos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int idTipo = Convert.ToInt32(cbTipo.SelectedValue);
            int idNivel = Convert.ToInt32(cbNivel.SelectedValue);
            Problema prob = new Problema()
            {
                Descricao = txtDescricao.Text,
                DataCriacao = Convert.ToDateTime(txtDt.Text),
                Tipo = new Tipo() { Id = idTipo},
                NivelDificuldade = new Nivel() { Id =  idNivel}
            };
            if (new ProblemaDB().insert(prob))
            {
                MessageBox.Show("Registro inserido!");
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Erro ao inserir registro!");
            }

        }
        private void CarregarGrid()
        {
            dgProblema.DataSource = new ProblemaDB().ListarProblema();
        }

        private void CarregaCombos()
        {
            cbTipo.DataSource = new TipoDB().ListarTipo();
            cbTipo.DisplayMember = "descricao";
            cbTipo.ValueMember = "id";
            cbNivel.DataSource = new NivelDB().ListarNivel();
            cbNivel.DisplayMember = "descricao";
            cbNivel.ValueMember = "id";
        }

        private void LimparCampos() {
            txtDescricao.Text = "";
            txtDt.Text = "";
            cbTipo.SelectedItem = 0;
            cbNivel.SelectedItem = 0;
            CarregarGrid();

        }
    }
}
