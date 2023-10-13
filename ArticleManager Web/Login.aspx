<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ArticleManager_Web.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <%if (!session)
        {%>

    <h3>Ingrese sus datos para iniciar la sesion: </h3>
     <div class="row">
        <div class="col-1"></div>
        <div class="col">
    <div class="mb-3">
        <label for="exampleInputEmail1" class="form-label">Usuario</label>
        <asp:TextBox cssClass="form-control" ID="txtUser" runat="server" />
    </div>
    <div class="mb-3">
        <label for="exampleInputPassword1" class="form-label">Contraseña</label>
        <asp:TextBox type="Password" CssClass="form-control" ID="txtPassword" runat="server" />
    </div>
    <asp:Button ID="btnIngresar" CssClass="btn btn-primary" runat="server" Text="Ingresar" OnClick="btnIngresar_Click" />
     </div>
        <div class="col-7"></div>

 </div> 

    <%}
        else
        { %>

    <h3>Te logueaste exitoxamente a nuestro carrito de compras</h3>
    <br />
    <asp:Button ID="btnCerrarSesion" runat="server" CssClass="btn btn-primary" Text="Cerrar sesion" OnClick="btnCerrarSesion_Click" />
    <asp:Button ID="btnVolver" runat="server" Text="Volver al inicio" CssClass="btn btn-primary" OnClick="btnVolver_Click" />

    <%}%>
</asp:Content>
