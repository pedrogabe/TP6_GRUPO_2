using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

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
            GestionNeptuno gProductos = new GestionNeptuno();
            gvSeleccionarProducto.DataSource = gProductos.ObtenerTodosLosProductos();
            gvSeleccionarProducto.DataBind();
        }

        protected void gvSeleccionarProductos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvSeleccionarProducto.PageIndex = e.NewPageIndex;
            LoadGridView();
        }

        protected void gvSeleccionarProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       public DataTable CrearTable()
        {
            DataTable dt = new DataTable();
            DataColumn columna = new DataColumn("IdProducto", System.Type.GetType("System.String"));
            dt.Columns.Add(columna);
            columna = new DataColumn("NombreProducto", System.Type.GetType("System.String"));
            dt.Columns.Add(columna);
            columna = new DataColumn("IdProveedor", System.Type.GetType("System.String"));
            dt.Columns.Add(columna);
            columna = new DataColumn("PrecioUnidad", System.Type.GetType("System.String"));
            dt.Columns.Add(columna);
            return dt;
        }

        public void AgregarFila(DataTable tabla, String idproducto, String nombreproducto, String idproveedor, String preciounidad)
        {
            DataRow dr = tabla.NewRow();
            dr["IdProducto"] = idproducto;
            dr["NombreProducto"] = nombreproducto;
            dr["IdProveedor"] = idproveedor;
            dr["PrecioUnidad"] = preciounidad;
            tabla.Rows.Add(dr);
        }

        protected void gvSeleccionarProducto_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            if (Session["tabla"] == null)
            {
                Session["tabla"] = CrearTable();
                String s_IdProducto = ((Label)gvSeleccionarProducto.Rows[e.NewSelectedIndex].FindControl("lblIdProducto")).Text;
                String s_NombreProducto = ((Label)gvSeleccionarProducto.Rows[e.NewSelectedIndex].FindControl("lblNombreProducto")).Text;
                String s_IdProveedor = ((Label)gvSeleccionarProducto.Rows[e.NewSelectedIndex].FindControl("lblIdProveedor")).Text;
                String s_PrecioUnidad = ((Label)gvSeleccionarProducto.Rows[e.NewSelectedIndex].FindControl("lblPrecioUnidad")).Text;
                lblMensaje.Text = "Producto agregado: " + s_NombreProducto;
                AgregarFila((DataTable)Session["tabla"], s_IdProducto, s_NombreProducto, s_IdProveedor, s_PrecioUnidad);
            }

        }
    }
}