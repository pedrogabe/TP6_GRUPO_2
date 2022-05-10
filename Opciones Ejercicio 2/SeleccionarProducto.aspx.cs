using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

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

        public DataTable crearTabla()
        {
            DataTable dt = new DataTable();
            DataColumn columna = new DataColumn("IdProducto", System.Type.GetType("System.Int32"));
            dt.Columns.Add(columna);
            columna = new DataColumn("NombreProducto", System.Type.GetType("System.String"));
            dt.Columns.Add(columna);
            columna = new DataColumn("IdProveedor", System.Type.GetType("System.Int32"));
            dt.Columns.Add(columna);
            columna = new DataColumn("PrecioUnidad", System.Type.GetType("System.Decimal"));
            dt.Columns.Add(columna);
            return dt;
        }

        public void agregarFila(DataTable tabla,int IdProducto, String NombreProducto, int IdProveedor, Decimal PrecioUnidad)
        {
            DataRow dr = tabla.NewRow();
            dr["IdProducto"] = IdProducto;
            dr["NombreProducto"] = NombreProducto;
            dr["IdProveedor"] = IdProveedor;
            dr["PrecioUnidad"] = PrecioUnidad;

            tabla.Rows.Add(dr);

        }

       

        protected void gvSeleccionarProducto_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            int i_IdProducto = Convert.ToInt32(((Label)gvSeleccionarProducto.Rows[e.NewSelectedIndex].FindControl("lblIdProducto")).Text);
            String s_NombreProducto = ((Label)gvSeleccionarProducto.Rows[e.NewSelectedIndex].FindControl("lblNombreProducto")).Text;
            int i_IdProveedor = Convert.ToInt32(((Label)gvSeleccionarProducto.Rows[e.NewSelectedIndex].FindControl("lblIdProveedor")).Text);
            decimal d_PrecioUnidad = Convert.ToDecimal(((Label)gvSeleccionarProducto.Rows[e.NewSelectedIndex].FindControl("lblPrecioUnidad")).Text);
            lblMensaje.Text = "Producto agregado: "+s_NombreProducto;

            if (Session["tabla"] == null)
            {
                Session["tabla"] = crearTabla();
            }
            agregarFila(((DataTable)Session["tabla"]), i_IdProducto, s_NombreProducto, i_IdProveedor, d_PrecioUnidad);
        }
    }
}