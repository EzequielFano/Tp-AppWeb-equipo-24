<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ArticleManager_Web.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <%if (user == "" || password=="")
        {%>

    <h3>Ingrese sus datos para iniciar la sesion: </h3>
    <div class="mb-3">
        <label for="formGroupExampleInput" class="form-label">Usuario:</label>
        <br />
        <asp:TextBox ID="txtUser" runat="server" placeholder="Nombre de usuario..."></asp:TextBox>
    </div>
    <div class="mb-3">
        <label for="formGroupExampleInput2" class="form-label">Password:</label>
        <br />
        <asp:TextBox ID="txtPassword" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
    </div>
    <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" OnClick="btnIngresar_Click" />

    <%}
        else
        { %>

    <h3>Tu sesion ya esta iniciada!</h3>
    <br />
    <asp:Button ID="btnCerrarSesion" runat="server" Text="Cerrar sesion" OnClick="btnCerrarSesion_Click" />
    <a href="Default.aspx">Volver al inicio</a>

    <%}%>
</asp:Content>
