using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using TO;

namespace BL
{
    public class Detalle_FacturaBL
    {
        public int Consecutivo_Factura;
        public int Codigo_Producto;
        public int Cantidad;
        public Detalles_FacturaDAO detalleDAO = new Detalles_FacturaDAO();

        public void agregarDetalle(String factura, String producto, int cantidad)
        {
            try
            {
                this.Consecutivo_Factura = int.Parse(factura);
                this.Codigo_Producto = int.Parse(producto);
                this.Cantidad = cantidad;

                Detalles_FacturaTO detalleTO = new Detalles_FacturaTO();
                detalleTO.Consecutivo_Factura = this.Consecutivo_Factura;
                detalleTO.Codigo_Producto = this.Codigo_Producto;
                detalleTO.Cantidad = this.Cantidad;

                detalleDAO = new Detalles_FacturaDAO();
                detalleDAO.insertarDetalle(detalleTO);
            }
            catch (Exception)
            {
                throw;
            }
            
        }

    }
}
