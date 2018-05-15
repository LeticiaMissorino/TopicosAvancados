using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjController;
using ProjModel;

namespace ProjMonitoramento
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Inserir();
        }

        protected void Inserir() {

            ControllerMonitoramento cm = new ControllerMonitoramento();
            Monitoramento m = new Monitoramento();
            m.descricao = txtDescricao.Text;
            m.qtdeCamera = Convert.ToInt32(txtQtde.Text);
            m.nomeCliente = txtNomeCliente.Text;
            m.valorPacote = CalculoValor(Convert.ToDecimal(txtValor.Text));
            m.isFidelidade = rbtnSim.Checked == true ? true : false;
            if (cm.Insert(m))
            { 
               Response.Write("<script>alert('Registro inserido com sucesso');</script>");
               LimparCampos();
            }
            else
                Response.Write("<script>alert('Erro ao inserir registro');</script>");
        }

        protected void LimparCampos() {
            txtDescricao.Text = string.Empty;
            txtQtde.Text = string.Empty;
            txtNomeCliente.Text = string.Empty;
            txtValor.Text = string.Empty;
            rbtnNao.Checked = false;
            rbtnSim.Checked = false;
            txtDescricao.Focus();

        }
        protected decimal CalculoValor(decimal valor) {
            int qtde = Convert.ToInt32(txtQtde.Text);
            bool fidelidade=rbtnSim.Checked == true ? true : false;
            if (qtde >= 1 && qtde <= 2)
                if (fidelidade == true)
                    valor = valor - ((10* 100) / 100);
                 else
                    valor = valor - ((5 * 100) / 100);
            else if(qtde >=3 && qtde <=4)
                if(fidelidade == true)
                    valor = valor - ((20 * 100) / 100);
                else
                    valor = valor - ((10 * 100) / 100);
            else if(qtde >=5) 
              if(fidelidade == true )
                valor = valor - ((30 * 100) / 100);
            else
                valor = valor - ((15 * 100) / 100);
            return valor;
     
        }

        protected void btnListar_Click(object sender, EventArgs e)
        {

        }
    }
}