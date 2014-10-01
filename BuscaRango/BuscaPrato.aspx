<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="BuscaPrato.aspx.cs" Inherits="BuscaRango.BuscaPrato" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">
    <title>Busca Rango | Busca de prato</title>
    <link href="Style/BuscaPrato.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphConteudo" runat="server">
    <asp:UpdatePanel ID="upContent" runat="server">
        <ContentTemplate>
            <!-- Filtros -->
            <div class="row com-borda sem-borda-top">
                <div class="col-xs-8 no-margin no-padding">
                    <asp:TextBox ID="txtBusca" runat="server" CssClass="form-control btn-100" placeholder="Buscar"></asp:TextBox>
                </div>
                <div class="col-xs-2 no-margin no-padding">
                    <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_OnClick" Text="Buscar" CssClass="btn btn-default btn-100" />
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
                            <asp:Image ID="img" runat="server" Height="100" Width="150" />
                        </div>
                        <div class="col-xs-10">
                            <div class="row row-info">
                                <h4>
                                    <asp:LinkButton ID="lnkNome" runat="server" Text=""></asp:LinkButton>
                                </h4>
                            </div>
                            <div class="row row-info">
                                <h5>
                                    <asp:LinkButton ID="lnkEstabelecimento" runat="server" Text=""></asp:LinkButton>
                                </h5>
                            </div>
                            <div class="row row-info">
                                <asp:Label ID="lblEstabelecimento" runat="server" Text=""></asp:Label>
                            </div>
                            <div class="row row-info">
                                <asp:Label ID="lblDescricao" runat="server" Text=""></asp:Label>
                            </div>
                            <div class="row row-info">
                                <asp:Label ID="lblNota" runat="server" Text=""></asp:Label>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
