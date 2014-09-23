<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BuscaRango.Default" %>
<asp:Content ID="cntHead" ContentPlaceHolderID="cphHead" runat="server">
    <title>Busca Rango | Página inicial</title>
</asp:Content>
<asp:Content ID="cntConteudo" ContentPlaceHolderID="cphConteudo" runat="server">
    <asp:LinkButton ID="lnkPratos" runat="server" OnClick="lnkPratos_Click">Busca Pratos</asp:LinkButton>
    <br />
    <asp:LinkButton ID="lnkEstabelecimentos" runat="server" OnClick="lnkEstabelecimentos_Click">Busca Estabelecimentos</asp:LinkButton>
</asp:Content>
