using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

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
        public DataTable ObtenerTodosLosProductos()
        {
            return ObtenerTabla("SELECT * FROM Productos");
        }
    }
}