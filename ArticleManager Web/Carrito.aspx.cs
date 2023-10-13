using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Collections.Specialized.BitVector32;

namespace ArticleManager_Web
{
    public partial class Carrito : System.Web.UI.Page
    {
        public static List<Articulo> articulosCarrito { get; set; }
        public int cantidad { get; set; }
        public List<int> idArticulo { get; set; }
        public List<Imagen> ListaImagenes { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            List<Articulo> aux = new List<Articulo>();
            articulosCarrito = (List<Articulo>)Session["ArticulosCarrito"];
            //if (idArticulo == null)
            //{
            //    idArticulo = new List<int>();
            //    idArticulo = (List<int>)Session["idArticulo"];
            //}
            //int cantId = idArticulo.Count();
            //cantidad = articulosCarrito.Count();
            //for(int i = 0; i<cantId; i++)
            //{
            //aux = negocio.TraerListadoCompletoxId(idArticulo[i]);
            //articulosCarrito.Add(aux[i]);
            //}
            if (!IsPostBack)
            {
                rpRepetidor.DataSource = articulosCarrito;
                rpRepetidor.DataBind();
            }

            //idArticulo = Session["idArticulo"].ToString();
            //rpCarrito.DataSource = articulosCarrito;
            //rpCarrito.DataBind();
            //ListaImagenes = negocio.verImagenesArticulo(int.Parse(idArticulo));
            //rpRepetidorImg.DataSource = ListaImagenes[0];


         
        }
    }
}