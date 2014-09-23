using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BuscaRangoCode;

namespace BuscaRango
{
    public partial class BuscaPrato : System.Web.UI.Page
    {
        public List<Prato> LstPratos;
        public List<Prato> LstPratosFiltrados;

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
                MudaCorBotao("btnPrato");

                var pratos = PratoService.SelectAll();

                LstPratosFiltrados = new List<Prato>();
                if (pratos.Sucesso)
                {
                    LstPratos = (List<Prato>)pratos.RetObj;
                    LstPratos.ForEach(x => LstPratosFiltrados.Add(x));
                    CarregaPratosFiltrados();
                    Session["Data"] = LstPratos;
                }
                else
                {
                    Response.Write("Erro: " + pratos.MsgErro);
                }
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
        /// Carrega os pratos que foram filtrados
        /// </summary>
        private void CarregaPratosFiltrados()
        {
            rptDados.DataSource = LstPratosFiltrados;
            rptDados.DataBind();
        }

        /// <summary>
        /// Repeater DataBound
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void rptDados_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                Prato prato = (Prato)e.Item.DataItem;
                Label nome = (Label)e.Item.FindControl("lblNome");
                Label descricao = (Label)e.Item.FindControl("lblDescricao");
                Label estabelecimento = (Label)e.Item.FindControl("lblEstabelecimento");
                Label nota = (Label)e.Item.FindControl("lblNota");
                Image img = (Image)e.Item.FindControl("img");

                nome.Text = prato.Nome;
                descricao.Text = prato.Descricao;
                estabelecimento.Text = prato.Estabelecimento.Nome;
                nota.Text = "Nota: " + prato.Nota;
                img.ImageUrl = "~/Img/Prato/" + prato.Imagem;
            }
        }
    }
}