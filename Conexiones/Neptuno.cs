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
            string s_CantidadPorUnidad, decimal i_PrecioUnidad, short i16_UnidadesEnExistencia,
            short i16_UnidadesEnPedido, int i_NivelNuevoPedido, bool b_Suspendido)
        {
            IdProducto = i_IdProducto;
            NombreProducto = nomeProducto;
            IdProveedor = i_IdProveedor;
            IdCategoria = i_IdCategoria;
            CantidadPorUnidad = s_CantidadPorUnidad;
            PrecioUnidad = i_PrecioUnidad;
            UnidadesEnExistencia = i16_UnidadesEnExistencia;
            UnidadesEnPedido = i16_UnidadesEnPedido;
            NivelNuevoPedido = i_NivelNuevoPedido;
            Suspendido = b_Suspendido;
        }

        // Metodos
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public int IdProveedor { get; set; }
        public int IdCategoria { get; set; }
        public string CantidadPorUnidad { get; set; }
        public decimal PrecioUnidad { get; set; }
        public short UnidadesEnExistencia { get; set; }
        public short UnidadesEnPedido { get; set; }
        public int NivelNuevoPedido { get; set; }
        public bool Suspendido { get; set; }
    }
}