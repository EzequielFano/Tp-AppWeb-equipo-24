<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="ArticleManager_Web.Carrito" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="color: white">Carrito</h1>
    <%if (borroCarrito == false)
        { %>
    <asp:Repeater ID="rpRepetidor" runat="server">
        <ItemTemplate>
            <div class="card mb-3" style="max-width: 540px;">
                <div class="row g-0">
                    <div class="col-md-4">
                        <img src="<%#Eval("URLImagen.URL")%>" class="img-fluid rounded-start" alt="...">
                    </div>
                    <div class="col-md-8">
                        <div class="card-body">
                            <h5 class="card-title"><%#Eval("NombreArticulo") %></h5>
                            <h4 class="card-title"><%#Eval("Precio") %></h4>
                            <p class="card-text">Marca: <%#Eval("Marca")%></p>
                            <p class="card-text"><small class="text-body-secondary">Descripcion: <%#Eval("Descripcion")%></small></p>
                            <asp:Button ID="btnEliminarCarrito" runat="server" CssClass="btn btn-success" Text="Eliminar del carrito" CommandArgument='<%#Eval("IdArticulo")%>' CommandName="IdArticulo" OnClick="btnEliminarCarrito_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
    <%} %>
    ----------------
    <%--<asp:Repeater ID="rpRepetidorImg" runat="server">
        <ItemTemplate>
            <img src="<%#Eval("URL") %>" class="img-thumbnail" alt="...">
        </ItemTemplate>
    </asp:Repeater>
    <%//Detalles %>
    <asp:Repeater ID="rpCarrito" runat="server">
        <ItemTemplate>
            <div class="card mb-3">
                <div class="card-body">
                    <h5 class="card-title"><%#Eval("NombreArticulo") %></h5>
                    <h4>$ <%#Eval("Precio") %></h4>
                    <p class="card-text">Descripcion: <%#Eval("Descripcion")%></p>
                    <p class="card-text">
                        <medium class="text-body-secondary">Marca: <%#Eval("Marca")%></medium>
                    </p>
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>--%>
</asp:Content>
