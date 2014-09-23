using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BuscaRango
{
    public partial class Default : System.Web.UI.Page
    {
        /// <summary>
        /// Page Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                // Deixa o botão Home com Danger
                MudaCorBotao("btnHome");
            }
        }

        /// <summary>
        /// Muda a cor do botão da página atual
        /// </summary>
        /// <param name="btn"></param>
        private void MudaCorBotao(string btn)
        {
            MasterPage master = this.Master;
            Button home = (Button)master.FindControl(btn);
            home.CssClass = home.CssClass + " btn-danger";
        }

        /// <summary>
        /// Click botão Busca Pratos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lnkPratos_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/BuscaPrato");
        }

        /// <summary>
        /// Click botão Busca Estabelecimentos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lnkEstabelecimentos_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/BuscaEstabelecimento");
        }
    }
}