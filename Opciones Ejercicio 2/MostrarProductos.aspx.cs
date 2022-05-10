using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP6_GRUPO2.Opciones_Ejercicio_2
{
    public partial class MostrarProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["tabla"]!=null)
            {
                grdSeleccionados.DataSource = Session["tabla"];
                grdSeleccionados.DataBind();
            }

        }
    }
}