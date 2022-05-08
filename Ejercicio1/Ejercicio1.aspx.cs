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

        protected void gvProductos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvProductos.PageIndex = e.NewPageIndex;
            LoadGridView();
        }

        protected void gvProductos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            // Buscar en el itemtemplate el IDPRODUCTO
            string s_IdProducto = ((Label)gvProductos.Rows[e.RowIndex].FindControl("lbl_it_IDProducto")).Text;

            // Eliminar producto a partir del IDPRODUCTO obtenido e informar estado
            lbl_event.Text = GestionNeptuno.EliminarProducto(s_IdProducto);

            // Refrescar gridview
            LoadGridView();
        }
    }
}