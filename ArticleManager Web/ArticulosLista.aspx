﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="ArticulosLista.aspx.cs" Inherits="ArticleManager_Web.ArticulosLista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Estos son nuestros articulos</h1>
    <asp:GridView ID="dgvArticulos" runat="server" CssClass="table" AutoGenerateColumns="false">
        <Columns>   
            <asp:BoundField Headertext="Codigo Articulo" DataField="CodigoArticulo" />
            <asp:BoundField Headertext="Nombre" DataField="NombreArticulo" />
            <asp:BoundField Headertext="Categoria" DataField="Categoria.Descripcion" />
            <asp:BoundField Headertext="Marca" DataField="Marca.Descripcion" />
        </Columns>
        <%--<asp:Repeater runat="server" id="repRepetidor">
            <ItemTemplate>

            </ItemTemplate>
        </asp:Repeater>--%>
    </asp:GridView>
    
</asp:Content>