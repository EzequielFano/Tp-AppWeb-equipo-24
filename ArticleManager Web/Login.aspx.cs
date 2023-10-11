using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ArticleManager_Web
{
    public partial class Login : System.Web.UI.Page
    {
        public string user { get; set; }
        public string password { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            user = Session["user"]!=null ? Session["user"].ToString() : "" ;  
            password = Session["password"] != null ? Session["user"].ToString() : "";
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            password = txtPassword.Text;   
            Session.Add("user", user);
            Session.Add("password", password);
            Response.Redirect("Login.aspx", false);
        }

        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            
            Session.Add("user", "");
            Session.Add("password", "");
            Response.Redirect("Login.aspx", false);
        }
    }
}