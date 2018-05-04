using ProjControler;
using ProjModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjWeb1
{
    public partial class _default : System.Web.UI.Page
    {
        private object Des;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnImprimir_Click(object sender, EventArgs e)
        {
            string msgDeclaracao = string.Format("Eu, {0} portador do Rg {1} , CPF {2} Adoro estudar {3} porque é uma Linguagem {4} </br> {5} , {6} , {7} </br> Declaro ser {8} de idade</br></br>"
                                                , txtNome.Text
                                                , txtRg.Text
                                                , txtCpf.Text
                                                , txtLing.Text
                                                , txtAdj.Text
                                                , txtCidade.Text
                                                , txtxDia.Text
                                                , txtAno.Text
                                                , txtMaior.Text);
            lblDeclaracao.Text = msgDeclaracao;

            string  declaracao = "C:\\TopicosAvancados\\carta.txt";
            if (!System.IO.File.Exists(declaracao))
            {
                System.IO.File.Create(declaracao).Close();
            }
            System.IO.TextWriter arquivo = System.IO.File.AppendText(declaracao);
            arquivo.WriteLine(msgDeclaracao);
            arquivo.Close();


            InserirBanco(txtNome.Text);


        }

        protected void btnListar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/lista.aspx");
        }

        private void InserirBanco( string valor) {
            new ControllerMensagem().Insert(new Mensagem() { descricao = valor });
                
        }

    }
}