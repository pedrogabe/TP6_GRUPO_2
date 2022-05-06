using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP6_GRUPO2
{
    public class Neptuno
    {
        // Constructores
        public Neptuno() { }
        public Neptuno(int i_IdProducto, string nomeProducto, int i_IdProveedor, int i_IdCategoria,
            string cantidadUnidad, decimal i_PrecioUnidad, short i16_UnidadesExistencia,
            short i16_UnidadesPedido, int i_NivelNuevoPedido, bool b_Suspendido)
        {
            IdProducto = i_IdProducto;
            NombreProducto = nomeProducto;
            IdProveedor = i_IdProveedor;
            IdCategoria = i_IdCategoria;
            CantidadUnidad = cantidadUnidad;
            PrecioUnidad = i_PrecioUnidad;
            UnidadesExistencia = i16_UnidadesExistencia;
            UnidadesPedido = i16_UnidadesPedido;
            NivelNuevoPedido = i_NivelNuevoPedido;
            Suspendido = b_Suspendido;
        }

        // Metodos
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public int IdProveedor { get; set; }
        public int IdCategoria { get; set; }
        public string CantidadUnidad { get; set; }
        public decimal PrecioUnidad { get; set; }
        public short UnidadesExistencia { get; set; }
        public short UnidadesPedido { get; set; }
        public int NivelNuevoPedido { get; set; }
        public bool Suspendido { get; set; }
    }
}