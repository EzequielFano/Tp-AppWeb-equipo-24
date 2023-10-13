using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;


namespace ArticleManager_Web
{
    public partial class Articulos1 : System.Web.UI.Page
    {
        public List<Articulo> ListaArticulos { get; set; }
        static public List<Articulo> ArticulosCarrito { get; set; }
        static public int cantidad { get; set; }
        
        public List<Imagen> ListaImagenes { get; set; }

        public List<int> idArticulo { get; set; }

        public bool session { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            session = Session["session"] != null ? (bool)Session["session"] : false;
            ArticulosNegocio negocio = new ArticulosNegocio();
            ListaArticulos = negocio.TraerListadoSP();
            if (!IsPostBack)
            {
                rpRepetidor.DataSource = ListaArticulos;
                rpRepetidor.DataBind();
            }
        }

        protected void btnCarrito_Click(object sender, EventArgs e)
        {

            string valor = ((Button)sender).CommandArgument;
           
            ArticulosNegocio negocio = new ArticulosNegocio();
            List<Imagen> auxImg = new List<Imagen>();

            List<Articulo> auxArticulo = negocio.TraerListadoCompletoxId(int.Parse(valor));
           // auxImg = negocio.verImagenesArticulo(int.Parse(valor));
            if (ArticulosCarrito == null)
            {
                ArticulosCarrito = new List<Articulo>();
            }
            ArticulosCarrito.Add(auxArticulo[0]);

            if (idArticulo == null)
            {
                idArticulo = new List<int>();
            }
            idArticulo.Add(int.Parse(valor));
            cantidad = ArticulosCarrito.Count();
            Session.Add("ArticulosCarrito", ArticulosCarrito);
            Session.Add("idArticulo", idArticulo);
            Session.Add("cantidad", cantidad);
            Response.Redirect("Articulos.aspx", false);

        }

        
    }
}