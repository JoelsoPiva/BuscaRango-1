<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerPrato.aspx.cs" Inherits="BuscaRango.VerPrato" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphConteudo" runat="server">
    <div class="row com-borda">
        <div class="col-xs-4 col-img" style="padding-left: 0">
            <asp:Image ID="img" runat="server" Height="250" Width="292" />
        </div>
        <div class="col-xs-8">
            <div class="row row-info">
                <strong>
                    <asp:Label ID="lblNome" runat="server" Text=""></asp:Label>
                </strong>
            </div>
            <div class="row row-info">
                <asp:LinkButton ID="lnkEstabelecimento" runat="server" Text=""></asp:LinkButton>
            </div>
            <div class="row row-info">
                <asp:Label ID="lblDescricao" runat="server" Text=""></asp:Label>
            </div>
            <div class="row row-info">
                <asp:Label ID="lblDescricaoCurta" runat="server" Text=""></asp:Label>
            </div>
            <div class="row row-info">
                <asp:Label ID="lblPreco" runat="server" Text=""></asp:Label>
            </div>
            <div class="row row-info">
                <asp:Label ID="lblTeleEntrega" runat="server" Text=""></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>
