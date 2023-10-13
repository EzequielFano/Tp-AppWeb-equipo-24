<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ArticleManager_Web.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <div class="row">
        <div class="col-2"></div>
            <div class="col">
             <h1>Bienvenido a nuestro carrito de compras</h1>
            </div>
        <div class="col-2"></div>
    </div>

        <div class="row">
            <div class="col-3"></div>
                <div class="col">
                 <h3>Por favor debes loguearte para poder continuar</h3>
                </div>
            <div class="col-3"></div>
        </div>
          <div class="row">
      <div class="col-5"></div>
          <div class="col">
        <asp:Button ID="btnLogueate" runat="server" Font-Size="XX-Large" BackColor="DarkGreen" CssClass="btn btn-primary" Text="Ir al login" OnClick="btnLogueate_Click"/>
          </div>
      <div class="col-3"></div>
  </div>
            

        
      
    

</asp:Content>
