using System;
using Entidade;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BancoDadosDB;

namespace WindowsFormsApp1
{
    public partial class FrmLinguagem : Form
    {
        public FrmLinguagem()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Entidade.Linguagem linguagem = new Entidade.Linguagem();
            linguagem.pontuacao = Convert.ToInt32(txtPontuacao.Text);
            linguagem.nome = txtNome.Text;

            //MessageBox.Show("Olá Turma...!" + tipo);

            if (new LinguagemDB().Insert(linguagem))
            {
                MessageBox.Show("Registo Inserido");
                CarregarGrid();
            }
            else
            {
                MessageBox.Show("Erro ao inserir Registro");
            }
        }

        private void dgLinguagem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void CarregarGrid ()
        {
            dgLinguagem.DataSource = new LinguagemDB().ListarTipo();
        }
    }
}
