using BuscaRangoCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BuscaRango
{
    public partial class VerEstabelecimento : System.Web.UI.Page
    {
        List<BR_Estabelecimento> lstEstabelecimentos;
        List<BR_Estabelecimento> lstEstabelecimentosFiltrados;
        public List<BR_Prato> lstPratosFiltrados;

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
                MudaCorBotao("btnLugar");

                if (Page.RouteData.Values["IdEstabelecimento"].ToString() == null)
                {
                    Response.Write("Erro: Estabelecimento não encontreado!!!!");
                }
                else
                {
                    string id = Page.RouteData.Values["IdEstabelecimento"].ToString();

                    lstEstabelecimentosFiltrados = new List<BR_Estabelecimento>();
                    lstEstabelecimentosFiltrados = ((List<BR_Estabelecimento>)
                    Session["DataE"]).Where(x => x.Id == Convert.ToInt16(id)).ToList();
                    CarregaEstabelecimentos();

                    lstPratosFiltrados = ((BR_Estabelecimento)EstabelecimentoService.SelectById(Int32.Parse(id)).RetObj).BR_Prato.ToList();
                    CarregaPratosFiltrados();
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
        /// Repeater DataBound
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void rptDados_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                BR_Estabelecimento estab = (BR_Estabelecimento)e.Item.DataItem;
                Label nome = (Label)e.Item.FindControl("lblNome");
                Label descricao = (Label)e.Item.FindControl("lblDescricao");
                Label categoria = (Label)e.Item.FindControl("lblCategoria");
                Label endereco = (Label)e.Item.FindControl("lblEndereco");
                Label nota = (Label)e.Item.FindControl("lblNota");
                Image img = (Image)e.Item.FindControl("img");

                if (estab.BR_Fotos_Estabelecimento.Count > 0)
                {
                    img.ImageUrl = "~/Img/Estabelecimento/" + estab.BR_Fotos_Estabelecimento.FirstOrDefault().Imagem.ToUpper().Replace(".JPG", "_T.JPG").Replace(".PNG", "_T.PNG");
                }

                // BR_Lista_Prato pratos = (BR_Lista_Prato)e.Item.DataItem;
                // Label prato = (Label)e.Item.FindControl("lblPrato");
                // Label preco = (Label)e.Item.FindControl("lblPreco");

                /*
                nome.Text = estab.Nome;
                descricao.Text = estab.DescricaoCurta;
                categoria.Text = estab.Categoria;
                nota.Text = "Nota: " + estab.Nota;
                img.ImageUrl = "~/Img/Estabelecimento/" + estab.Imagem;
                */
            }
        }

        /// <summary>
        /// Carrega os estabelecimentos
        /// </summary>
        private void CarregaEstabelecimentos()
        {
            rptDados.DataSource = lstEstabelecimentosFiltrados;
            rptDados.DataBind();
        }

        /// <summary>
        /// Carrega os pratos que foram filtrados
        /// </summary>
        private void CarregaPratosFiltrados()
        {
            rptPrato.DataSource = lstPratosFiltrados;
            rptPrato.DataBind();
        }

        /// <summary>
        /// Repeater DataBound
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void rptPratos_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                BR_Prato prato = (BR_Prato)e.Item.DataItem;
                LinkButton nome = (LinkButton)e.Item.FindControl("lnkNome");
                LinkButton estabelecimento = (LinkButton)e.Item.FindControl("lnkEstabelecimento");
                Label descricao = (Label)e.Item.FindControl("lblDescricao");
                Label nota = (Label)e.Item.FindControl("lblNota");
                Image img = (Image)e.Item.FindControl("img");

                nome.Text = prato.Nome;
                nome.PostBackUrl = "~/VerPrato/" + prato.Id;
                descricao.Text = prato.Descricao;
                img.ImageUrl = "~/Img/Prato/" + prato.Imagem.ToUpper().Replace(".JPG", "_T.JPG").Replace(".PNG", "_T.PNG");

            }
        }
    }
}