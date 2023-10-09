<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="Articulos.aspx.cs" Inherits="ArticleManager_Web.Articulos1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Cartitasssss...</h1>

    <div class="row row-cols-1 row-cols-md-3 g-4">
        <asp:Repeater ID="rpRepetidor" runat="server">
          <ItemTemplate>    
            <div class="col">
                <div class="card">
                    <img src="<%#Eval("URLImagen.URL") %>" class="card-img-top" alt="...">
                    <div class="card-body">
                        <h5 class="card-title"><%#Eval("NombreArticulo") %></h5>
                        <p class="card-text"><%#Eval("Descripcion")%></p>
                    </div>
                </div>
            </div>
          </ItemTemplate>
        </asp:Repeater>
</asp:Content>
