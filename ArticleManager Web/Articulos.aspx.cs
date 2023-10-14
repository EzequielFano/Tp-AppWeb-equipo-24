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

        protected void btnLogueate_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx",false);
        }
        protected void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            List<Articulo> lista = new List<Articulo>();
            List<Articulo> auxArticulo = negocio.TraerListadoSP();
            string busqueda = txtBuscador.Text;
            if (busqueda.Length > 1)
            {
                lista = auxArticulo.FindAll(x => x.NombreArticulo.ToUpper().Contains(busqueda.ToUpper())
                || x.CodigoArticulo.ToUpper().Contains(busqueda.ToUpper())
                || x.Descripcion.ToUpper().Contains(busqueda.ToUpper())
                || x.Marca.Descripcion.ToUpper().Contains(busqueda.ToUpper())
                || x.Categoria.Descripcion.ToUpper().Contains(busqueda.ToUpper()));
            }
            else
            {
                lista = auxArticulo;
            }
            //El filtro explota. falta terminar.
        }
    }
}