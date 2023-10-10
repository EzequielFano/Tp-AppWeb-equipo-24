<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="Detalles.aspx.cs" Inherits="ArticleManager_Web.Detalles" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Detalle del articulo</h1>
    <asp:Repeater ID="rpDetalles" runat="server">
        <ItemTemplate>
            <div class="card mb-3">           
                <div class="card-body">
                    <h5 class="card-title"><%#Eval("NombreArticulo") %></h5>
                    <h4>$ <%#Eval("Precio") %></h4>
                    <p class="card-text">Descripcion: <%#Eval("Descripcion")%></p>
                    <p class="card-text"><medium class="text-body-secondary">Marca: <%#Eval("Marca")%></medium></p>
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>

    <%-- <asp:GridView ID="dgvDetalles" runat="server" CssClass="table" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField HeaderText="Codigo Articulo" DataField="CodigoArticulo" />
                <asp:BoundField HeaderText="Nombre" DataField="NombreArticulo" />
                <asp:BoundField HeaderText="Categoria" DataField="Categoria.Descripcion" />
                <asp:BoundField HeaderText="Marca" DataField="Marca.Descripcion" />
            </Columns>
        </asp:GridView>--%>
</asp:Content>
