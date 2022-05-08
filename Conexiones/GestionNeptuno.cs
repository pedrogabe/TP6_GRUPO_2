using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace TP6_GRUPO2
{
    public class GestionNeptuno
    {
        // Constructor
        public GestionNeptuno() { }

        // Metodos
        private DataTable ObtenerTabla(string query)
        {
            try
            {
                DataSet ds = DB.DBClass.Query(query);
                return ds.Tables[0];
            }
            catch (ArgumentNullException)
            {
                System.Diagnostics.Trace.WriteLine("Invalid query");
                throw;
            }
        }

        /// <summary>
        /// Elimina un producto de la base de datos a partir de una ID de producto
        /// </summary>
        /// <param name="id">ID de producto</param>
        /// <returns>Estado de la accion</returns>
        public static string EliminarProducto(string id)
        {
            // Filas afectadas
            int? affected;
            affected = DB.DBClass.NonQuery("DELETE FROM Productos where Productos.IdProducto =" + id);
            if (affected == 0) return "ID de producto inexistente";
            else if (affected == 1) return "Producto eliminado";
            else return "Error al eliminar producto";
        }
        public DataTable ObtenerTodosLosProductos()
        {
            return ObtenerTabla("SELECT * FROM Productos");
        }
    }
}