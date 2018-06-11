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

        public void agregarDetalle(String factura, String producto, String cantidad)
        {
            try
            {
                this.Consecutivo_Factura = int.Parse(factura);
                this.Codigo_Producto = int.Parse(producto);
                this.Cantidad = int.Parse(cantidad);

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

        public List<Detalle_FacturaBL> obtenerDetalles(int numeroFactura)
        {
            this.Consecutivo_Factura = numeroFactura;

            Detalles_FacturaTO detalleTO = new Detalles_FacturaTO();
            detalleTO.Consecutivo_Factura = this.Consecutivo_Factura;

            List<Detalles_FacturaTO> lista = new List<Detalles_FacturaTO>();
            List<Detalle_FacturaBL> listaBL = new List<Detalle_FacturaBL>();
            lista = detalleDAO.obtenerDetalles(detalleTO);

            if (lista != null)
            {
                Detalle_FacturaBL dBL;
                for (int i = 0; i < lista.Count; i++)
                {
                    dBL = new Detalle_FacturaBL();
                    dBL.Cantidad = lista[i].Cantidad;
                    dBL.Codigo_Producto = lista[i].Codigo_Producto;
                    dBL.Consecutivo_Factura = lista[i].Consecutivo_Factura;
                    listaBL.Add(dBL);
                }
            }
            return listaBL;
        }

    }
}
