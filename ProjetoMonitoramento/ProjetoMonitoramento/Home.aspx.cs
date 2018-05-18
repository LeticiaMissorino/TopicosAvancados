using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoMonitoramento
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Inserir();
            gvMonitoramento.DataBind();
        }

        protected void Inserir()
        {

            ControllerMonitoramento cm = new ControllerMonitoramento();
            RegraNegocio regra = new RegraNegocio();
            Monitoramento objMonitoramento = new Monitoramento();

            objMonitoramento.descricao = txtDescricao.Text;
            objMonitoramento.qtdeCamera = Convert.ToInt32(txtQtde.Text);
            objMonitoramento.nomeCliente = txtNomeCliente.Text;
            objMonitoramento.isFidelidade = rbtnSim.Checked == true ? true : false;
            objMonitoramento.valorPacote = regra.CalculoValor(Convert.ToDecimal(txtValor.Text), Convert.ToInt32(txtQtde.Text), objMonitoramento.isFidelidade);
            objMonitoramento.pacote = regra.Pacote(Convert.ToInt32(txtQtde.Text), objMonitoramento.isFidelidade);

            if (cm.Insert(objMonitoramento))
            {
                Response.Write("<script>alert('Registro inserido com sucesso');</script>");
                LimparCampos();
            }
            else
                Response.Write("<script>alert('Erro ao inserir registro');</script>");
            gvMonitoramento.DataBind();
        }

        protected void LimparCampos()
        {
            txtDescricao.Text = string.Empty;
            txtQtde.Text = string.Empty;
            txtNomeCliente.Text = string.Empty;
            txtValor.Text = string.Empty;
            rbtnNao.Checked = false;
            rbtnSim.Checked = false;
            txtDescricao.Focus();

        }
    }
}