<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerEstabelecimento.aspx.cs" Inherits="BuscaRango.VerEstabelecimento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="server">
    <script type="text/javascript">
        var JQ = jQuery.noConflict();

        function EsconderDiv() {
            JQ("#divEstabelecimento").attr("disable", true);
        }
    </script>
    <link href="../Style/VerEstabelecimento.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphConteudo" runat="server">
    <!-- Dados -->
    <asp:Repeater ID="rptDados" runat="server" OnItemDataBound="rptDados_ItemDataBound">
        <ItemTemplate>
            <div class="row com-borda">
                <div class="col-xs-4 col-img">
                    <asp:Image ID="img" runat="server" Width="300" Height="200" />
                </div>
                <div class="col-xs-8">
                    <div class="row row-info">
                        <asp:Label ID="lblNome" runat="server" Text=""></asp:Label>
                        <div>
                            <asp:Label ID="lblDescCompleta" runat="server"></asp:Label>
                            <%# DataBinder.Eval(Container.DataItem,"Descricao") %>
                        </div>
                    </div>
                    <div class="row row-info">
                        <asp:Label ID="lblCNPJ" runat="server" Text="CEP:"></asp:Label>
                        <%# DataBinder.Eval(Container.DataItem,"CEP") %>
                    </div>
                    <div class="row row-info" style="float: left">
                        <asp:Label ID="lblCapacidade" runat="server" Text="Capacidade:"></asp:Label>
                        <img src="../Icones/Pessoas.png" alt="" />
                        <%# DataBinder.Eval(Container.DataItem,"Capacidade_Max")%> <span>Pessoas</span>
                    </div>
                    <div class="row row-info" style="float: left; margin-left: 10px">
                        <%# ((bool)Eval("Tem_Musica")) ? "<img style='margin-right: 10px;' title='Música ao vivo' src='../Icones/Musica3.png' />" : "" %>
                    </div>
                    <div class="row row-info" style="float: left; margin-left: 10px">
                        <%# ((bool)Eval("Tem_Wifi")) ? "<img title='Possui WiFi' id='imgWiFi' src='../Icones/wiFi.png' />" : "" %>
                    </div>
                    <div class="row row-info" id="divEstacionamento" style="float: left; margin-left: 10px">
                        <%# ((bool)Eval("Tem_Estacionamento")) ? "<img onchange='EsconderDiv()' title='Possui Estacionamento' src='../Icones/Estacionamento2.png' />|" : "" %>
                    </div>
                    <br style="clear: both" />
                    <div class="row row-info" id="divPratosDaCasa" runat="server">
                        <asp:Label runat="server" CssClass="" Text="Lista de Pratos da casa" ID="lblPrato"></asp:Label>
                    </div>

                    <div class="row row-info" id="div1" runat="server">
                        <asp:Label runat="server" ID="lblPreco"></asp:Label>
                    </div>
                </div>
            </div>

        </ItemTemplate>
    </asp:Repeater>
    <!-- Dados -->
            <asp:Repeater ID="rptPrato" runat="server" OnItemDataBound="rptPratos_ItemDataBound">
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
                                <asp:Label ID="lblDescricao" runat="server" Text=""></asp:Label>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
</asp:Content>
