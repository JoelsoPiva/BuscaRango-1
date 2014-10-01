<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="BuscaEstabelecimento.aspx.cs" Inherits="BuscaRango.BuscaEstabelecimento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">
    <title>Busca Rango | Busca de estabelecimento</title>
    <link href="Style/BuscaEstabelecimento.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphConteudo" runat="server">
    <asp:UpdatePanel ID="upContent" runat="server">
        <ContentTemplate>
            <!-- Filtros -->
            <div class="row com-borda sem-borda-top">
                <div class="col-xs-8 no-margin no-padding">
                    <asp:TextBox ID="txtBusca" runat="server" CssClass="form-control btn-100" placeholder="Pesquisar"></asp:TextBox>
                </div>
                <div class="col-xs-2 no-margin no-padding">
                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" CssClass="btn btn-default btn-100" />
                </div>
                <div class="col-xs-2 no-margin no-padding">
                    <asp:Button ID="btnFiltrar" runat="server" Text="+ Filtros" CssClass="btn btn-default btn-100" />
                </div>
            </div>
            <!-- Dados -->
            <asp:Repeater ID="rptDados" runat="server" OnItemDataBound="rptDados_ItemDataBound">
                <ItemTemplate>
                    <div class="row com-borda">
                        <div class="col-xs-2 col-img">
                            <asp:Image ID="img" runat="server" Height="100" />
                        </div>
                        <div class="col-xs-10">
                            <div class="row row-info">
                                <asp:Label ID="lblNome" runat="server" Text=""></asp:Label>
                                <div>
                                    <asp:HyperLink ID="HyperLink1" Text='<%# string.Format(DataBinder.Eval(Container.DataItem, "Razao_Social").ToString()) %>'
                                        NavigateUrl='<%# string.Format("~/VerEstabelecimento/{0}", DataBinder.Eval(Container.DataItem, "ID").ToString()) %>'
                                        runat="server" />
                                </div>
                            </div>
                            <div class="row row-info">
                                <asp:Label ID="lblDescricao" runat="server" Text="Email:"></asp:Label>
                                <%# DataBinder.Eval(Container.DataItem,"Email") %>
                            </div>
                            <div class="row row-info">
                                <asp:Label ID="lblCategoria" runat="server" Text="Telefone:"></asp:Label>
                                <%# DataBinder.Eval(Container.DataItem, "Tel_Contato")%>
                            </div>
                            <div class="row row-info">
                                <asp:Label ID="lblEndereco" runat="server" Text="Endereço:"></asp:Label>
                                <%# DataBinder.Eval(Container.DataItem,"Endereco") %>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
