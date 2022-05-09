using System;
using System.Data;
using DB;

namespace TP6_GRUPO2
{
    public class GestionNeptuno
    {
        // Constructor
        public GestionNeptuno() { }

        // Metodos

        /// <summary>
        /// Elimina un producto de la base de datos a partir de una ID de producto
        /// </summary>
        /// <param name="id">ID de producto</param>
        /// <returns>Estado de la accion</returns>
        public static string EliminarProducto(string id)
        {
            // Filas afectadas
            int? affected;
            affected = DBClass.NonQuery("DELETE FROM Productos where Productos.IdProducto =" + id);
            if (affected == 0) return "ID de producto inexistente";
            else if (affected == 1) return "Producto eliminado";
            else return "Error al eliminar producto";
        }
        public DataTable ObtenerTodosLosProductos()
        {
            return DBClass.ObtenerTabla("SELECT * FROM Productos");
        }

        /// <summary>
        /// Actualiza un producto de la base de datos a partir de una ID de producto
        /// </summary>
        /// <param name="id">ID de producto</param>
        /// <returns>Estado de la accion</returns>
        public static string ActualizarProducto(string id, string nombre, string cantidad, string precio)
        {
            int? affected = DBClass.NonQuery("ActualizaProducto @0, @1, @2, @3", id, nombre, cantidad, precio);
            if (affected == 0) return "ID de producto inexistente";
            if (affected == 1) return "Editado exitosamente";
            else return "Error!";
        }
    }
}