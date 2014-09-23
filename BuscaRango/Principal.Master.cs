using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BuscaRango
{
    public partial class Principal : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region Click
        /// <summary>
        /// Button Home
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Home");
        }

        /// <summary>
        /// Button Prato
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnPrato_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Prato");
        }

        /// <summary>
        /// Button Lugar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnLugar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Lugar");
        }

        /// <summary>
        /// Button Configuração
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnConfig_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Configuracao");
        }
        #endregion
    }
}