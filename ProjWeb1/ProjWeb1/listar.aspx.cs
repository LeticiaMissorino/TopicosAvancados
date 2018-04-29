using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjWeb1
{
    public partial class listar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        public void ListarLog()
        {
           string  nomeArquivo = @"C:\\TopicosAvancados\\carta.txt";
            
            string[] msgOld;
            try
            {
                msgOld = System.IO.File.ReadAllLines(nomeArquivo);
            }
            catch (Exception)
            {

                msgOld = null;
            }

            
            if (msgOld == null)
                lblLista.Text = "Registro não encontrado!";
            else
            {
                string list = "";

                foreach (var item in msgOld)
                {
                    list = list + item + "<br>";
                }
                lblLista.Text = list;
            }
        }
    }
}