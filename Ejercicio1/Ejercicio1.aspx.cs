﻿using System;
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

        protected void gvProductos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvProductos.EditIndex = e.NewEditIndex;
            LoadGridView();
        }

        protected void gvProductos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvProductos.EditIndex = -1;
            LoadGridView();
        }

        protected void gvProductos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string s_IdProducto = ((Label)gvProductos.Rows[e.RowIndex].FindControl("lbl_eit_id")).Text;
            string s_Nombre = ((TextBox)gvProductos.Rows[e.RowIndex].FindControl("txt_eit_NombreProducto")).Text;
            string s_Cantidad = ((TextBox)gvProductos.Rows[e.RowIndex].FindControl("txt_eit_CantidadPorUnidad")).Text;
            string s_Precio = ((TextBox)gvProductos.Rows[e.RowIndex].FindControl("txt_eit_PrecioUnidad")).Text;
            int? affected = DB.DBClass.NonQuery("ActualizaProducto @0, @1, @2, @3", s_IdProducto, s_Nombre, s_Cantidad, s_Precio);
            gvProductos.EditIndex = -1;
            if (affected == 1) { lbl_event.Text = "Editado exitosamente"; }
            else { lbl_event.Text = "Error!"; }
            LoadGridView();
        }
    }
}