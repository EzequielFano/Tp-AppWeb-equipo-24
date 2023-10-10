using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;
using System.Runtime.InteropServices;

namespace ArticleManager_Web
{
    public partial class Detalles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            ArticulosNegocio negocio = new ArticulosNegocio();
            string id = Request.QueryString["id"];
            dgvDetalles.DataSource = negocio.verDetallesArticulo(int.Parse(id));
            dgvDetalles.DataBind();



        }
    }
}