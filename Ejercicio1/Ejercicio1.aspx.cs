using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP6_GRUPO2
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadGridView();
            }
        }

        protected void LoadGridView()
        {
            GestionNeptuno gProductos = new GestionNeptuno();
            gvProductos.DataSource = gProductos.ObtenerTodosLosProductos();
            gvProductos.DataBind();
        }
    }
}