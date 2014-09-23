using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BuscaRangoCode;

namespace BuscaRango
{
    public partial class BuscaEstabelecimento : System.Web.UI.Page
    {
        List<Estabelecimento> lstEstabelecimentos;
        List<Estabelecimento> lstEstabelecimentosFiltrados;

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

                var estabelecimantos = EstabelecimentoService.SelectIn();
                lstEstabelecimentosFiltrados = new List<Estabelecimento>();
                if (estabelecimantos.Sucesso)
                {
                    lstEstabelecimentos = (List<Estabelecimento>)estabelecimantos.RetObj;
                    lstEstabelecimentos.ForEach(x => lstEstabelecimentosFiltrados.Add(x));
                    CarregaEstabelecimentos();
                    Session["Data"] = lstEstabelecimentos;
                }
                else
                {
                    Response.Write("Erro: " + estabelecimantos.MsgErro);
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
                Estabelecimento estab = (Estabelecimento)e.Item.DataItem;
                Label nome = (Label)e.Item.FindControl("lblNome");
                Label descricao = (Label)e.Item.FindControl("lblDescricao");
                Label categoria = (Label)e.Item.FindControl("lblCategoria");
                Label endereco = (Label)e.Item.FindControl("lblEndereco");
                Label nota = (Label)e.Item.FindControl("lblNota");
                Image img = (Image)e.Item.FindControl("img");

                nome.Text = estab.Nome;
                descricao.Text = estab.DescricaoCurta;
                categoria.Text = estab.Categoria;
                nota.Text = "Nota: " + estab.Nota;
                img.ImageUrl = "~/Img/Estabelecimento/" + estab.Imagem;
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
    }
}