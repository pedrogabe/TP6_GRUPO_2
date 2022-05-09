using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP6_GRUPO2.Opciones_Ejercicio_2
{
    public partial class SeleccionarProducto : System.Web.UI.Page
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
            gvSeleccionarProducto.DataSource = GestionNeptuno.ObtenerTodosLosProductos();
            gvSeleccionarProducto.DataBind();
        }

        protected void gvSeleccionarProducto_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvSeleccionarProducto.PageIndex = e.NewPageIndex;
            LoadGridView();
        }


        protected void gvSeleccionarProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        protected void gvSeleccionarProducto_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            String s_IdProducto = ((Label)gvSeleccionarProducto.Rows[e.NewSelectedIndex].FindControl("lblIdProducto")).Text;
            String s_NombreProducto = ((Label)gvSeleccionarProducto.Rows[e.NewSelectedIndex].FindControl("lblNombreProducto")).Text;
            String s_IdProveedor = ((Label)gvSeleccionarProducto.Rows[e.NewSelectedIndex].FindControl("lblIdProveedor")).Text;
            String s_PrecioUnidad = ((Label)gvSeleccionarProducto.Rows[e.NewSelectedIndex].FindControl("lblPrecioUnidad")).Text;
            lblMensaje.Text = "Producto agregado: "+s_NombreProducto;


        }
    }
}